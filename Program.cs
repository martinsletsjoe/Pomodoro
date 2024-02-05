using System.Data.SqlClient;
using System.Data.SqlTypes;
using Dapper;
using Pomodoro.Model;

namespace Pomodoro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            const string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pomodoro;Integrated Security=True;";



            app.MapGet("/pomodoro", async () =>
            {
                try
                {
                    var conn = new SqlConnection(connStr);
                    const string sql = "SELECT Id, EndTime, StartTime FROM Pomodoro ORDER BY StartTime DESC";
                    var pomodoroItems = await conn.QueryAsync<PomodoroItem>(sql);
                    return pomodoroItems;
                }
                catch (Exception ex)
                {
                    return null;
                }
            });

            app.MapPost("/pomodoro", async (PomodoroItem pomodoroItem) =>
            {
                var conn = new SqlConnection(connStr);
                const string sql = "INSERT Pomodoro(Id, EndTime, StartTime) VALUES(@Id, @EndTime, @StartTime)";
                var rowsAffected = await conn.ExecuteAsync(sql, pomodoroItem);
                return rowsAffected;
            });

            app.MapDelete("/pomodoro/{id}", async (Guid id ) =>
            {
                    var conn = new SqlConnection(connStr);
                    const string sql = "DELETE FROM Pomodoro WHERE Id = @Id";
                    var rowsAffected = await conn.ExecuteAsync(sql, new { Id = id });
                    return rowsAffected;
            });



            app.UseStaticFiles();
            app.Run();
        }
    }
}
