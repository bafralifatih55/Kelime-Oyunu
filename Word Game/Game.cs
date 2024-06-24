using System.Drawing;
using System.Windows;
using System.Windows.Threading;
using View.ViewModels;

namespace Word_Game
{
    internal class Game
    {
        private List<word> words;
        private int totalPoint;
        private int wordPoint;
        private int currentWordIndex;

        // Kelimenin açılan harf görüntüsünü ve ip ucunu aktarmak için
        public string WordClue => word.Info.Clue;
        public string WordOpenLetters => word.WordView();

        private CustomTimer gameTimer;
        private CustomTimer wordTimer;
        private DispatcherTimer timer;
        private word word;

        public Game()
        {
            WordLoader wordLoader = new WordLoader();
            gameTimer = new CustomTimer(TimeSpan.FromMinutes(4));
            word=new word("Test","Harika");

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.IsEnabled = true;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void NewQuestion()
        {
            gameTimer.Start();
        }

        public void getLetter()
        {
word.GetALetter();
                    }
        
        private void Timer_Tick(object? sender, EventArgs e)
        {
            
        }
    }
}
