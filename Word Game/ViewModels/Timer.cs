namespace View.ViewModels
{
    internal class CustomTimer
    {
        private DateTime startTime;
        private TimeSpan time;

        public CustomTimer(TimeSpan time)
        {
            this.time = time;
            startTime = DateTime.Now;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public bool IsTimeOver()
        {
            return DateTime.Now - startTime >time;
        }

        public TimeSpan RemainingTime()
        {
            return time - (DateTime.Now - startTime);
        }
    }
}
