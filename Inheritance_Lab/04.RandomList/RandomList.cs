﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
       
            Random rand = new Random();

            public string RandomString()
        {
            var index = rand.Next(0, this.Count);
            var element = this[index];
            this.RemoveAt(index);

            return element;
        }
        

    }
}
