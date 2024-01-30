namespace Pomodoro.Model
{
    public class PomodoroItem
    {
        public Guid Id { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime StartTime { get; set; }

        public PomodoroItem(DateTime startTime, DateTime? endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            Id = Guid.NewGuid();
        }

        //public void StartTimer()
        //{
        //    StartTime = DateTime.Now;
        //}

    }
}
