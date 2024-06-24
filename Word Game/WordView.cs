namespace View
{
    internal class WordView
    {
        private char[] openedLetters;
        private string value;
        private Random random;

        public WordView(string value)
        {
            this.value = value;
            openedLetters = new char[value.Length];
            random = new Random();
        }
    
    public void GetALetter()
        {
            while (true) 
            {
                int index = random.Next(value.Length);

                if (openedLetters[index]=='\0')
                {
                    openedLetters[index] = value[index];
                        break;
                                        }
            }
        }
    
        public   string GetView()
        {
            char[] view = new char[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                view[i] = openedLetters[i] != '\0' ? openedLetters[i]:'*';
            }
            return new string(view);
        }
    
    }
}
