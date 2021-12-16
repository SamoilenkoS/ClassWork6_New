using System;
using System.Collections.Generic;
using System.Text;

namespace CWLibrary
{
    public class Animal
    {
        public string Name;

        public void SayMyName()
        {
            Console.WriteLine($"My name is {Name}!");
        }
    }
}
