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
			SqlDataReader reader = cmd.ExecuteReader();
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
			reader.Close();
			connection.Close();

			return table;
		}
    }
}
