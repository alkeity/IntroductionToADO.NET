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

		internal static readonly Dictionary<string, int> studyFields;
		internal static readonly Dictionary<string, int> learningForms;
		static Connector()
        {
            connection = new SqlConnection(connectionStr);

			studyFields = SelectColumnWithID("study_field_name", "StudyFields");
			learningForms = SelectColumnWithID("form_name", "LearningForms");
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

		public static Dictionary<string, int> SelectColumnWithID(string column, string table)
		{
			Dictionary<string, int> values = new Dictionary<string, int>();

			string cmdStr = $"SELECT {column}, id FROM {table}";
			SqlCommand cmd = new SqlCommand(cmdStr, connection);

			connection.Open();
			try
			{
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.HasRows)
					{
						while (reader.Read()) values[reader[0].ToString()] = Convert.ToInt32(reader[1]);
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

		public static void InsertGroup(Group group)
		{
			string cmdStr = "IF NOT EXISTS(SELECT * FROM Groups WHERE group_name = @groupName) " +
				"BEGIN " +
				"INSERT INTO Groups (group_name, start_date, start_time, lesson_days, study_field_id, learning_form_id) " +
				"VALUES (@groupName, @startDate, @startTime, @lessonDays, @studyFieldID, @learningFormID);" +
				"END";

			SqlCommand cmd = new SqlCommand(cmdStr, connection);
			cmd.Parameters.Add("@groupName", SqlDbType.VarChar, 16).Value = group.Name;
			cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = group.StartDate;
			cmd.Parameters.Add("@startTime", SqlDbType.Time).Value = group.StartTime;
			cmd.Parameters.Add("@lessonDays", SqlDbType.TinyInt).Value = group.StudyDays;
			cmd.Parameters.Add("@studyFieldID", SqlDbType.Int).Value = group.StudyFieldID;
			cmd.Parameters.Add("@learningFormID", SqlDbType.Int).Value = group.LearningFormID;

			connection.Open();
			try
			{
				if (cmd.ExecuteNonQuery() <= 0) throw new Exception($"Group \"{group.Name}\" already exists");
			}
			finally { connection.Close(); }
		}

		public static void UpdateGroup(Group group)
		{
			string cmdStr = "UPDATE Groups SET " +
				"group_name = @groupName, start_date = @startDate, start_time = @startTime, lesson_days = @lessonDays," +
				" study_field_id = @studyFieldID, learning_form_id = @learningFormID " +
				"WHERE id = @ID";

			SqlCommand cmd = new SqlCommand(cmdStr, connection);
			cmd.Parameters.Add("@ID", SqlDbType.Int).Value = group.Id;
			cmd.Parameters.Add("@groupName", SqlDbType.VarChar, 16).Value = group.Name;
			cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = group.StartDate;
			cmd.Parameters.Add("@startTime", SqlDbType.Time).Value = group.StartTime;
			cmd.Parameters.Add("@lessonDays", SqlDbType.TinyInt).Value = group.StudyDays;
			cmd.Parameters.Add("@studyFieldID", SqlDbType.Int).Value = group.StudyFieldID;
			cmd.Parameters.Add("@learningFormID", SqlDbType.Int).Value = group.LearningFormID;

			connection.Open();
			try { cmd.ExecuteNonQuery(); }
			finally { connection.Close(); }
		}

	}
}
