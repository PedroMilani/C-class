using System;
using System.Diagnostics;

namespace Inheritance_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Pedro Milani");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Pedro Milani", "https://image.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("How great humans are?", "Pedro Milani", "https://video.com/greathumans", 300, true);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video.");
            Console.ReadKey();
            videoPost1.Stop();

            Console.ReadKey();
        }
    }
}
