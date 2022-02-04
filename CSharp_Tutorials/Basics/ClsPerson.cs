using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tutorials.Basics
{
    internal class ClsPerson
    {
        string name;
        int id;
        //number==> int, float,double

        //total=1+2+3+4+5
        //
        int beginConfig=1;
        int endConfig = 100;
        int beginning;
        int end;
        int total=0;
        //1+2+3+4+5
      public  void SumNo()
        {
            Console.WriteLine("Enter beginning");
            beginning =Convert.ToInt16( Console.ReadLine());
            Console.WriteLine("Enter end");
            end = Convert.ToInt16(Console.ReadLine());
            Console.ReadKey();
            if(beginning>=beginConfig && end <=endConfig)
            {
                for(int i=beginning;i<=end;i++)
                {
                    total = total + i;
                }
                Console.Write("Total is "+total);

            }
            else
            {
                Console.WriteLine("Invalid input given by user");
            }
            Console.Read();
        }

    }
}
