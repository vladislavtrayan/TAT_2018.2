using System;

namespace ControlTask2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UrlFinder urlFinder = new UrlFinder();
            string url = urlFinder.FindUrl("http://google.com");
            Console.WriteLine(url);
        
    }
}
