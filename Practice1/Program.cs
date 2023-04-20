using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            addition.Add();
            OddEven oddEven = new OddEven();
            oddEven.check();
            
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
