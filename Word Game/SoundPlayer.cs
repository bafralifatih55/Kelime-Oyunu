using System.Media;
using System.Windows.Controls;

namespace View
{
    internal class PlaySound
    {
        private string location;
        private SoundPlayer player;

        public PlaySound(string location  )
        {
            this.location = location;
            player = new SoundPlayer(location);
                    }
    
    public void Play()
        {
            player.Play();
                    }
    }
}
