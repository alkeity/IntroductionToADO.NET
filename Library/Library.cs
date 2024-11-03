﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class Library
	{
		const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library_PD311;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		static SqlConnection connection;

        static Library()
        {
			connection = new SqlConnection(connectionString);
		}

        public static void InsertAuthor(string firstName, string lastName)
		{
			string cmd = $"INSERT INTO Authors(first_name, last_name) VALUES('@first_name', '@last_name')";
			SqlCommand command = new SqlCommand();
			command.Parameters.AddWithValue("@first_name", firstName);
			command.Parameters.AddWithValue("@last_name", lastName);
			command.Connection = connection;
			command.CommandText = cmd;
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}

		public static void InsertBook(string title, string firstName, string lastName)
		{
			int authorId = GetAuthorID(firstName, lastName);
			string commandString = $"INSERT INTO Books(title, author_id) VALUES('@title', @author_id)";

			SqlCommand command = new SqlCommand();
			command.CommandText = commandString;
			command.Connection = connection;
			command.Parameters.AddWithValue("@title", title);
			command.Parameters.AddWithValue("@author_id", authorId);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}

		public static int GetAuthorID(string firstName, string lastName)
		{
			string commandString = $"(SELECT id FROM Authors WHERE first_name = @first_name AND last_name = @last_name)";
			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.Parameters.AddWithValue("@first_name", firstName);
			command.Parameters.AddWithValue("@last_name", lastName);
			command.CommandText = commandString;
			connection.Open();
			int authorId = Convert.ToInt32(command.ExecuteScalar());
			connection.Close();
			return authorId;
		}

		public static void Select(List<string> fields, List<string> tables, params List<string>[] joinOn)
		{
			int padding = 32;
			string commandText = "SELECT @fields FROM @tables";
			string fieldsString = "", tablesString = "", joinOnString = "";
			for (int i = 0; i < fields.Count; i++)
			{
				fieldsString += fields[i];
				if (i < fields.Count - 1) { fieldsString += ", "; }
			}
			commandText += " FROM ";
			for (int i = 0; i < tables.Count; i++)
			{
				tablesString += tables[i];
				if (i < tables.Count - 1) { tablesString += ", "; }
			}
			if (joinOn.Length > 0)
			{
				commandText += " WHERE @join_on";
				for (int i = 0; i < joinOn.Length; i++)
				{
					joinOnString += $"{joinOn[i][0]} = {joinOn[i][1]}";
					if (i < joinOn.Length - 1) { joinOnString += " AND "; }
				}
			}

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = commandText;
			command.Parameters.AddWithValue("@fields", fieldsString);
			command.Parameters.AddWithValue("@tables", tablesString);
			command.Parameters.AddWithValue("@join_on", joinOnString);

			connection.Open();

			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
				{
					Console.Write(reader.GetName(i).PadRight(padding));
				}
				Console.WriteLine();

				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
					}
					Console.WriteLine();
				}
			}
			reader.Close();
			connection.Close();
		}

		public static void SelectAuthors()
		{
			SqlCommand command = new SqlCommand();
			command.CommandText = "SELECT * FROM Authors";
			command.Connection = connection;
			connection.Open();

			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
				{
					Console.Write(reader.GetName(i).PadRight(14));
				}
				Console.WriteLine();

				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetValue(i).ToString().PadRight(14));
					}
					Console.WriteLine();
				}
			}
			reader.Close();
			connection.Close();
		}
	}
}
