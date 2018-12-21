using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoTestService
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText($"{DateTime.Now:yyyyMMdd-hhmmss}.txt", $"It is {DateTime.Now.ToShortTimeString()} and all is well!");
        }
    }
}
