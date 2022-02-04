using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials.Linq
{
    internal class Aggregates
    {
        ///

        int[] numbers = { 1, 2, 3, 4 };

        public void RunningTotalWithAggregate()
        {
            //main use of aggregates is handling running expressions like running total as shownin below example and any thing
            Console.WriteLine(numbers.Aggregate((a, b) => a + b));
            Console.WriteLine(numbers.Aggregate((a, b) => a * b));
            //here 2 is seed parameters which addted to very first element 
            Console.WriteLine(numbers.Aggregate(2,(a, b) => a + b));
            //just consider you appended one constant on beginning of liat elements { 1, 2, 3, 4 };==>{2, 1, 2, 3, 4 }; and continues as regular aggregates
            Console.WriteLine(numbers.Aggregate(2, (a, b) => a * b));
        }
    }
}
