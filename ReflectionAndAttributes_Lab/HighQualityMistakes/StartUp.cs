using System;

namespace HighQualityMistakes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var spy = new Spy();

            string result = spy.AnalyzeAcessModifiers("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}
