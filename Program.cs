using System;
using System.IO;

namespace _net_mp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] music = Directory.GetFiles(@"c:\MyDir\", "*.mp3");
            Console.WriteLine("Hello World!", music);
        }
    }
}
