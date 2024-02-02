namespace Pomodoro.Model
{
    public class PomodoroItem
    {
        public Guid Id { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime StartTime { get; set; }

        public PomodoroItem(DateTime startTime, DateTime? endTime) : this()
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public PomodoroItem()
        {
            Id = Guid.NewGuid();
        }
    }
}
