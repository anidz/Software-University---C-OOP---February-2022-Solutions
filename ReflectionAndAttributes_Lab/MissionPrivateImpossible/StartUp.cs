﻿using System;

namespace MissionPrivateImpossible
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var spy = new Spy();

            string result = spy.RevealPrivateMethods("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }

}
