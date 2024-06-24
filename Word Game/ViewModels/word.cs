using View.Model;

namespace View.ViewModels
{
    internal class word
    {
        public WordInfo  Info { get; set; }
        public WordScore Score { get; set; }
        public WordView View { get; set; }
        public WordCheck Check { get; set; }

        public word(string clue, string value)
        {
            Info = new WordInfo(clue, value);
            Score = new WordScore(Info.NumberOfLetters());
            View = new WordView(value);
            Check = new WordCheck(value);
        }

        public void GetALetter()
        {
            Score.DeductPoint();
            View.GetALetter();
        }

        public bool WordCheck(string clue)
        {
            return Check.CheckIt(clue);
        }

        public string WordView()
        {
            return View.GetView();
                    }

    }
}
