namespace View.Model
{
    internal class WordInfo
    {
        public string Clue { get; private set; }
        public string Answer { get; private set; }

        public WordInfo(string clue, string answer)
        {
            Clue = clue;
            Answer = answer;
        }

        public int NumberOfLetters() => Answer.Count(c =>   !char.IsWhiteSpace(c));

    }
}
