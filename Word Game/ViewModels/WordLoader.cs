using View.Model;

namespace View.ViewModels
{
    internal class WordLoader
    {
        public List<WordInfo> Words { get; set; }
        private readonly string jsonFilePath;

        public WordLoader()
        {
            Words = new List<WordInfo>();
           

            #region Örnek kelimeler
            Words.Add(new WordInfo("zamanı gösteren alet.", "Saat"));
            Words.Add(new WordInfo("Hızlı hızlı yürüme anlamındaki söz", "Koşma"));

            #endregion
        }

        public List<WordInfo> LoadWords()
        {
            return Words;
        }
    }
}
