using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqpractice
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static void Main(string[] args)
        {
            Human[] humans = { new Human { Name = "tarou", Age = 33},
                               new Human { Name = "zirou", Age = 22},
                               new Human { Name = "sabrou", Age = 44} };

            var orderByHuman = humans.OrderBy(x => x.Name);
            foreach(var human in orderByHuman)
            {
                Console.WriteLine(human.Name);
            }
            var reverseHuman = humans.Reverse();
            foreach (var human in reverseHuman)
            {
                Console.WriteLine(human.Name);
            }
            Console.ReadLine();

        }
    }
}

    
　　　