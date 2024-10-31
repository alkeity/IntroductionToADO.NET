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
			List<string> fields = new List<string> { "Books.title", "Authors.first_name", "Authors.last_name" };
			List<string> tables = new List<string> { "Books", "Authors" };

			Select(fields, tables, new List<string> { "Books.author_id", "Authors.id" });
			//SelectAuthors();

			//string comm = "SELECT Books.title, Authors.first_name, Authors.last_name FROM Books, Authors WHERE Books.author_id = Authors.id";
			//Console.WriteLine();
			//SqlCommand command = new SqlCommand(comm, connection);

			//connection.Open();
			//SqlDataReader reader = command.ExecuteReader();
			//if (reader.HasRows)
			//{
			//	for (int i = 0; i < reader.FieldCount; i++)
			//	{
			//		Console.Write(reader.GetName(i).PadRight(32));
			//	}
			//	Console.WriteLine();

			//	while (reader.Read())
			//	{
			//		for (int i = 0; i < reader.FieldCount; i++)
			//		{
			//			Console.Write(reader.GetValue(i).ToString().PadRight(32));
			//		}
			//		Console.WriteLine();
			//	}
			//}
			//connection.Close();
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
			connection.Close();
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
			commandText += " WHERE ";
			for (int i = 0; i < join_on.Length; i++)
			{
				commandText += $"{join_on[i][0]} = {join_on[i][1]}";
				if (i < join_on.Length - 1) { commandText += " AND "; }
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
			connection.Close();
		}
	}
}
