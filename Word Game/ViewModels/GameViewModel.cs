using System.Security.Permissions;
using System.Windows;
using System.Windows.Input;
using View.Model;
using Word_Game;

namespace View.ViewModels
{
    internal class GameViewModel:NotifyPropertyChanged
    {
        private Game game;
        PlaySound playSound;
        private int _scoreBox;
        private string _clue;
        private string _guess;
        private string _openLetters;

        // Puan kasası
        public int ScoreBox { get => _scoreBox; 
            set => SetField(ref _scoreBox,value); }

        // Kelime ipucu 
        public string Clue
        {
            get => _clue;

            set
            {
                                SetField(ref _clue, value);
            }
        }

        // Kelime tahmin 
        public string Guess
        {
            get => _guess;
            set
            {
                                SetField(ref _guess, value);
                playSound.Play();
            }
        }

        // Açılan harfler 
        public string OpenLetters
        {
            get => _openLetters; 
            set
            {
                SetField(ref _openLetters, value);
            }
        }

        // Oyunu bitir
        public ICommand FinishGameCommand { get; set; }

        // Süreyi durdur
        public ICommand StopTimeCommand { get; set; }

        // Harf al
        public ICommand GetLetterCommand { get; set; }

        // cevap ver
        public ICommand AnswerCommand { get; set; }

        // Yeni soru isteme
        public ICommand NewQuestion { get; set; }

        public GameViewModel()
        {
            playSound = new PlaySound(@"Audio\Keyboard.wav");
            FinishGameCommand = new RelayCommand(FinishGameExecute);
            StopTimeCommand = new RelayCommand(StopTimeExecute);
            GetLetterCommand = new RelayCommand(GetLetterExecute);
            AnswerCommand = new RelayCommand(AnswerExecute);
            NewQuestion = new RelayCommand(NewQuestionExecute);
            game = new Game();
            //Açılan harfler ve ip ucu UI tarafına aktarılıyor
            _clue = game.WordClue;
            _openLetters=game.WordOpenLetters;
        }

        private void FinishGameExecute(object obj)
        {
            
        }

        private void StopTimeExecute(object obj)
        {

        }

        private void AnswerExecute(object obj)
        {

        }

        private void GetLetterExecute(object obj)
        {
            game.getLetter();
        }

        private void NewQuestionExecute(object obj)
        {
        }


    }
}
