using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MediaPlayer
    {
        public void playMusic()
        {
            Console.WriteLine("Play a song...");
            Console.ReadKey();
        }

        public void playVideo()
        {
            Console.WriteLine("Play a video...");
            Console.ReadKey();
        }

        public void showPictures()
        {
            Console.WriteLine("Show a picture...");
            Console.ReadKey();
        }
    }
}
