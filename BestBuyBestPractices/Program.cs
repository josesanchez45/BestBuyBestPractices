using BestBuyBestPractices;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

#region Departments
//var departmentRepo = new DapperDepartmentRepository (conn);

//departmentRepo.InsertDepartment("Pet Items");

//var departments = departmentRepo.GetAllDepartments();



//foreach (var department in departments)
//{
//    Console.WriteLine(department.DepartmentID);
//    Console.WriteLine(department.Name);
//    Console.WriteLine();
//}
#endregion

#region Products
var productRepo = new DapperProductRepository (conn);

var products = productRepo.GetAllProducts();

foreach (var item in products)
{
    Console.WriteLine($"Product ID: {item.ProductID}");
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"Is it on sale: {item.OnSale}");
    Console.WriteLine($"Price: {item.Price}");
    Console.WriteLine($"Stock Level: {item.StockLevel}");
    Console.WriteLine();
    Console.WriteLine();
}
#endregion