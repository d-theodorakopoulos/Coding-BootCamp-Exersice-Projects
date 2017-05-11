using System;

namespace VideoTest
{
    public class Programs
    {
        static void Main(string[] args)
        {
            Color red = new Color(255, 0, 0);
            Color green = new Color(0 , 255, 0);
            Color blue = new Color(0, 0, 255);

            Video youtubeVideo = new Video(20);
            Frame image = new Frame(10, 3);

            Console.WriteLine(image.ShowFrame());
           
            Console.WriteLine("press a key to continue!");
            Console.ReadKey();
        }
    }
}
