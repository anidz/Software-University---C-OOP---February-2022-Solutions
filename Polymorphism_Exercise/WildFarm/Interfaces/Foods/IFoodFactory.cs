using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Interfaces
{
    public interface IFoodFactory
    {
        IFood CreateFood(string[] foodData);
    }
}
