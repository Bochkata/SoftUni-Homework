﻿

using System;
using CommandPattern.Core.Contracts;

namespace CommandPattern
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
           
            Environment.Exit(0);
            return null;
        }
    }
}
