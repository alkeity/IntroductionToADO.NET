using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Library
{
	internal class Program
	{
		const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library_PD311;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		static SqlConnection connection;

        static Program()
        {
			connection = new SqlConnection(connectionString);
        }

        static void Main(string[] args)
		{
			//InsertAuthor("Roger", "Zelazny");
			//SelectAuthors();
			InsertBook("Nine Princes in Amber", "Roger", "Zelazny");

			List<string> fields = new List<string> { "Books.title", "Authors.first_name", "Authors.last_name" };
			List<string> tables = new List<string> { "Books", "Authors" };
			Select(fields, tables, new List<string> { "Books.author_id", "Authors.id" });

		}

		static void InsertAuthor(string firstName, string lastName)
		{
			string cmd = $"INSERT INTO Authors(first_name, last_name) VALUES('{firstName}', '{lastName}')";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}

		static void InsertBook(string title, string firstName, string lastName)
		{
			int authorId = GetAuthorID(firstName, lastName);
			string commandString = $"INSERT INTO Books(title, author_id) VALUES('{title}', {authorId})";

			SqlCommand command = new SqlCommand(commandString, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}

		static void SelectAuthors()
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

		static int GetAuthorID(string firstName, string lastName)
		{
			string commandString = $"(SELECT id FROM Authors WHERE first_name = '{firstName}' AND last_name = '{lastName}')";
			SqlCommand command = new SqlCommand(commandString, connection);
			connection.Open();
			int authorId = Convert.ToInt32(command.ExecuteScalar());
			connection.Close();
			Console.WriteLine(authorId);
			return authorId;
		}


		static void Select(List<string> fields, List<string> tables, params List<string>[] join_on)
		{
			int padding = 32;
			string commandText = "SELECT ";
			for (int i = 0; i < fields.Count; i++)
			{
				commandText += fields[i];
				if (i < fields.Count - 1) { commandText += ", "; }
			}
			commandText += " FROM ";
			for (int i = 0; i < tables.Count; i++)
			{
				commandText += tables[i];
				if (i < tables.Count - 1) { commandText += ", "; }
			}
			if (join_on.Length > 0)
			{
				commandText += " WHERE ";
				for (int i = 0; i < join_on.Length; i++)
				{
					commandText += $"{join_on[i][0]} = {join_on[i][1]}";
					if (i < join_on.Length - 1) { commandText += " AND "; }
				}
			}
			
			//Console.WriteLine(commandText);

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = commandText;

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
	}
}
