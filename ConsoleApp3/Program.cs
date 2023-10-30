using ConsoleApp3;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

//var connectionStr = "Data Source=STHQ0123-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;";

//interpolasya ile deyer elevae etmek yalnisdir 
//dugun variant asagidaki kimidir
//using var connection = new SqlConnection(connectionStr);

//string Name = "Nazim";
//string Surname = "Nazim";
//int id = 21;

//var command = $"INSERT INTO Authors(Id,FirstName,LastName) VALUES(21,@name,@surname)";

//var command = $"UPDATE Authors SET FirstName='Fazil' WHERE Id = {id}";

//var command = "DELETE FROM Authors WHERE Id = 21";




var connectionStr = "Data Source=STHQ0123-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;";

using var connection = new SqlConnection(connectionStr);

var command = "SELECT * FROM Authors";



var list = connection.Query<Authors>(command).ToList();

foreach (var item in list)
{
    Console.WriteLine(item);
}

