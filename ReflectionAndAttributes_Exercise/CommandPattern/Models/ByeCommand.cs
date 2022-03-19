﻿using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models
{
    public class ByeCommand : ICommand
    {
        public string Execute(string[] args)
        {
            var result = $"Bye, {args[0]}";

            return result;
        }
    }
}
