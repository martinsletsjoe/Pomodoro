namespace Pomodoro.Model
{
    public class PomodoroItem
    {
        public Guid Id { get; set; }
        public DateTime DoneTime { get; set; }
        public DateTime StartTime { get; set; }

        public PomodoroItem()
        {
            Id = Guid.NewGuid();
        }

    }
}
