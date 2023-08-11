using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnGPACalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputCollector collector = new InputCollector();
            collector.Input();
            Console.WriteLine();
        }
    }
}
