﻿using System;
using ValidationAttributes.Core;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //var person = new Person
            // (
            //     null,
            //     -1
            // );

            //bool isValidEntity = Validator.IsValid(person);

            //Console.WriteLine(isValidEntity);

           
            {
                Engine engine = new Engine();

                engine.Proceed();
            }
        }
    }
}
