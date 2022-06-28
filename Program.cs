using System;
using System.Linq;

namespace lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {3654, -87665, 73959, 28376,
                                     37462, 8374, 284, -3275,
                                     435, 45635, -3654, 46
                                     };

            var newArray = from x in array
                           where x > 0
                           select x % 10;
            newArray = newArray.Distinct();
            foreach (int x in newArray)
                Console.WriteLine(x);
        }
    }
}
