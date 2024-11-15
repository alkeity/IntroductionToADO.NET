using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Academy
{
	internal class Connector
	{
		static readonly string connectionStr = ConfigurationManager.ConnectionStrings["AcademyConnectionString"].ConnectionString;
		static SqlConnection connection;
        static Connector()
        {
            connection = new SqlConnection(connectionStr);
        }

        public static DataTable Select(string columns, string tables, string conditions = "")
        {
			DataTable table = new DataTable();
			string cmdStr = $"SELECT {columns} FROM {tables}";
			if (conditions.Length > 0)
			{
				cmdStr += $" WHERE {conditions}";
			}
			SqlCommand cmd = new SqlCommand(cmdStr, connection);

			connection.Open();
			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.HasRows)
					{
						for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
						while (reader.Read())
						{
							DataRow row = table.NewRow();
							for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
							table.Rows.Add(row);
						}
					}
				}
			}
			finally { connection.Close(); }

			return table;
		}

		public static List<string> SelectColumn(string column, string table)
		{
			List<string> values = new List<string>();
			string cmdStr = $"SELECT {column} FROM {table}";

			SqlCommand cmd = new SqlCommand(cmdStr, connection);

			connection.Open();
			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.HasRows)
					{
						while (reader.Read()) values.Add(reader[0].ToString());
					}
				}
			}
			finally { connection.Close(); }

			return values;
		}

		public static void InsertGroup(string groupName, string fieldName)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			cmd.Parameters.Add("@study_field_name", SqlDbType.NVarChar, 150).Value = fieldName;
			cmd.Parameters.Add("@group_name", SqlDbType.VarChar, 16).Value = groupName;
			cmd.CommandText = $"IF NOT EXISTS(SELECT * FROM Groups WHERE group_name = @group_name) " +
			$"BEGIN " +
			$"INSERT INTO Groups (group_name, study_field_id) " +
			$"VALUES (@group_name, (SELECT id FROM StudyFields WHERE study_field_name = @study_field_name)); " +
			$"END";

			connection.Open();
			if (cmd.ExecuteNonQuery() <= 0)
			{
				connection.Close();
				throw new Exception($"Group \"{groupName}\" already exists");
			}
			connection.Close();
		}
    }
}
