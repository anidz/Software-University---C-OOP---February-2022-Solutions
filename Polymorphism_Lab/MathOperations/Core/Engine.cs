﻿using Operations.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Core
{
    public class Engine
    {
        public void Proceed()
        {
            MathOperations mo = new MathOperations();

            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
        }
    }
}
