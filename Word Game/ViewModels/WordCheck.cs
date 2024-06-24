namespace View.ViewModels
{
    internal class WordCheck
    {
        private string value;

        public WordCheck(string value)
        {
            this.value = value;
        }

        public bool CheckIt(string guess)
        {
            return string.Equals(value,guess,StringComparison.OrdinalIgnoreCase);
        }
    }
}
