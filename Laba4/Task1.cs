using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Task1
    {
        public void Show(object[] args)
        {
            foreach (object arg in args)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{arg.GetType().ToString().Split(new char[] { '.' }).Last()}: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(arg);
            }
        }
    }
}    