using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqpractice
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            var HumanList = new[]
            {
                new { Name = "山下", age = 44, weight = 50},
                new { Name = "山田", age = 58, weight = 90},
                new { Name = "吉田", age = 90, weight = 38},
                new { Name = "花子", age = 28, weight = 35},
            };

            foreach (var human in HumanList)
            {
                Console.WriteLine(human);
            }
            Console.ReadLine();
        }
    }
}

    
