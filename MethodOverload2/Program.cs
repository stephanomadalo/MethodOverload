using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverloading
{
    internal class Program
    {

        








            static int Add(int numA, int numB)
            {
                return numA + numB;
            }
            static decimal Add(decimal numA, decimal numB)
            {
                return (numA + numB);
            }
            static string Add(int numA, int numB, bool isTrue)
            {
                var sum = 0;
                var answer = "";

                if (isTrue)
                {
                    sum = numA + numB;

                    if (sum == 1)
                    {
                        answer = $"{sum} dollar";
                    }
                    else
                    {
                        answer = $"{sum} dollars";
                    }



                }

                return answer;
        
        }

        private static void Main(string[] args)
        {

            Console.WriteLine(Add(-5, 6, true));


            Console.WriteLine(Add(-9, 1, true));


            Console.WriteLine(Add(9, 1, true));






        }
    }
}
