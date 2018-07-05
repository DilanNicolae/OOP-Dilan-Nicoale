using System;

namespace ConsoleApp3
{
    public class Camera
    {
        public void takePhoto()
        {
            Console.WriteLine("Take a photo...");

            Console.ReadKey();
        }

        public void recordVideo()
        {
            Console.WriteLine("Record a video...");
            Console.ReadKey();
        }
    }
}
