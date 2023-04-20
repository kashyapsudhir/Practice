using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class OddEven
    {
        public void check()
        {
            Console.WriteLine("Enter your number");
            int a = Convert.ToInt32(Console.ReadLine());
            /*int a = Int32.Parse(Console.ReadLine());*/
            if (a % 2 == 0)
            {
                Console.WriteLine($"This {a} is Even number");
            }
            else
            {
                Console.WriteLine($"This {a}  is Odd Number");
            }
        }
    }
}
