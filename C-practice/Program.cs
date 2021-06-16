using System;
using System.Collections.Generic;
using System.Linq;

namespace Linqpractice
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 47, 29, 99, 75, 87 };

            Console.WriteLine(list.Count); //要素のカウント
            Console.WriteLine(list.Remove(47));//要素の削除
            Console.WriteLine(list.First());//最初の要素の取得
            Console.WriteLine(list.Last());//最後の要素の取得
            
            foreach(int number in list)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}

    
