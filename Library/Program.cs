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
        static Program()
        {
			
        }

        static void Main(string[] args)
		{
			//Console.WriteLine(Library.GetAuthorID("Roger", "Zelazny"));
			Library.SelectAuthors();
			//Library.InsertBook("Nine Princes in Amber", "Roger", "Zelazny");

			//List<string> fields = new List<string> { "Books.title", "Authors.first_name", "Authors.last_name" };
			//List<string> tables = new List<string> { "Books", "Authors" };
			//Library.Select(fields, tables, new List<string> { "Books.author_id", "Authors.id" });

		}
	}
}
