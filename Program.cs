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
                new PomodoroItem(),

            };

            app.MapGet("/test", () =>
            {
                return inMemoryDb;
            });

            app.UseStaticFiles();
            app.Run();
        }
    }
}
