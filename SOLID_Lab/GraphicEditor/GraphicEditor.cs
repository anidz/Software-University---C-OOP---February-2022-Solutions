﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GraphicEditor
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            if (shape is Circle)
            {
                Console.WriteLine("I'm Circle");
            }
            else if (shape is Rectangle)
            {
                Console.WriteLine("I'm Recangle");
            }
            else if (shape is Square)
            {
                Console.WriteLine("I'm Square");
            }
        }
    }
}
