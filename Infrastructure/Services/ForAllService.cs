using Dapper;
using Domain.Dtos;
using Npgsql;

namespace Infrastructure.Services;

public class ForAllService
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=WebApidb;User Id=postgres;Password=s.arda1717;";
    public ForAllService()
    {
        
    }

    public List<Task1Dto> GetTask1()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select * from orders o JOIN products p ON o.productid = p.id;";
            var result = connection.Query<Task1Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task2Dto> GetTask2()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select * from orders o Join products p on o.productid = p.id where p.company = 'Apple';";
            var result = connection.Query<Task2Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task3Dto> GetTask3()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "SELECT p.productname, o.price from orders o join products p on o.productid = p.id where o.price>1000;";
            var result = connection.Query<Task3Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task4Dto> GetTask4()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "SELECT c.*, p.productname from customers c left join products p  on c.id = p.id;";
            var result = connection.Query<Task4Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task5Dto> GetTask5()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select * from customers c full outer join products p on c.id = p.id;";
            var result = connection.Query<Task5Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task6Dto> GetTask6()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select * from customers c Right join products p on c.id = p.id;";
            var result = connection.Query<Task6Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task7Dto> GetTask7()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select c.firstname, o.productcount as number_of_order from customers c join orders o on o.customerid = c.id group by c.firstname, o.productcount;";
            var result = connection.Query<Task7Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task8Dto> GetTask8()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select p.productname, o.price from products p join orders o on p.id = o.id group by p.productname, o.price, o.customerid;";
            var result = connection.Query<Task8Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task9Dto> GetTask9()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select productname, company from products where company IN ('Samsung', 'Xiaomi','Apple')Order by company;";
            var result = connection.Query<Task9Dto>(sql);
            return result.ToList();
        }
    }
    public List<Task10Dto> GetTask10()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = "select productname, company from products where company != 'Samsung' and company != 'Xiaomi' and company != 'Apple';";
            var result = connection.Query<Task10Dto>(sql);
            return result.ToList();
        }
    }
}