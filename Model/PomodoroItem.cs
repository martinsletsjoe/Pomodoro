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

        public string FormattedStartTime
        {
            get { return StartTime.ToString("HH:mm:ss"); }
        }   
        public string FormattedEndTime
        {
            get { return EndTime?.ToString("HH:mm:ss"); }
        }


        //public void StartTimer()
        //{
        //    StartTime = DateTime.Now;
        //}

    }
}
