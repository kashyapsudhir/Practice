using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Addition
    {
        public void Add()
        {
            Console.WriteLine("Enter your number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"sum of your number is = {c} ");
        }
    }
}
