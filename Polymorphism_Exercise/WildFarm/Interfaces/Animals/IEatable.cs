﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Interfaces.Animals
{
    public interface IEatable
    {
        void Eat(IFood food);
    }
}
