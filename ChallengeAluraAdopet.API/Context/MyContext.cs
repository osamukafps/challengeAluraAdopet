using ChallengeAluraAdopet.API.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAluraAdopet.API.Context;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }
    
    public DbSet<Tutor> Tutor { get; set; }

    public static void TestConnection(string connectionString)
    {
        try
        {
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            connection.Close();
            
            Console.WriteLine("Connection made successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred during the connection!" +
                              $"Error: {ex.Message}");
            throw ex;
        }
    }
}