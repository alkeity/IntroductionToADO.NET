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
			//SelectAuthors();

			string comm = "SELECT Books.title, Authors.first_name, Authors.last_name FROM Books, Authors WHERE Books.author_id = Authors.id";
			Console.WriteLine();
			SqlCommand command = new SqlCommand(comm, connection);

			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
				{
					Console.Write(reader.GetName(i).PadRight(32));
				}
				Console.WriteLine();

				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetValue(i).ToString().PadRight(32));
					}
					Console.WriteLine();
				}
			}
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
					//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
				}
			}
			connection.Close();
		}
	}
}
