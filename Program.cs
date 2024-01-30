using Pomodoro.Model;

namespace Pomodoro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            var inMemoryDb = new List<PomodoroItem>()
            {
                new PomodoroItem(new DateTime(2024,1,1,13,0,0), new DateTime(2024,1,1,14,0,0)),
                new PomodoroItem(new DateTime(2024,1,1,13,0,0), new DateTime(2024,1,1,14,0,0)),
            };

        app.MapGet("/pomodoro", () =>
            {
                return inMemoryDb;
            });

            app.UseStaticFiles();
            app.Run();
        }
    }
}

//stopwatch klasse ferdig i c#