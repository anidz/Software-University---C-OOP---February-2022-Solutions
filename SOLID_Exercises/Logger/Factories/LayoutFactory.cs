using Logger.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Factories
{
    public static class LayoutFactory
    {
        public static ILayout CreateLayout(string type)
        {
            return type switch
            {
                "SimpleLayout" => new SimpleLayout(),
                "XmlLayout" => new XmlLayout(),
                _ => throw new InvalidOperationException()
            };
        }
    }
}
