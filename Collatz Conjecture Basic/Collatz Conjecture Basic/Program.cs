using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public static void Main(string[] args)
        {

            long number;
            int count = 0;
            long max = 0;
            String value;

            while ((value = readInt("Please enter an integer greater than 1:")) != "end")
            {
                if (!Int64.TryParse(value, out number) || number <= 0 || number == 1)
                {
                    Console.WriteLine("ERROR - Invalid input");
                }
                else
                {

                    while (number != 1)
                    {

                        if (number % 2 != 0)
                        {
                            number = number * 3 + 1;
                        }
                        else
                        {
                            number = number / 2;
                        }


                        ++count;

                        if (number > max)
                            max = number;





                    }

                    Console.WriteLine("The number " + value + " reduced to 1 in " + count + " generations");
                    Console.WriteLine("The largest value in the sequence was " + max);
                    count = 0;
                    max = 0;

                }
            }

        }

        public static String readInt(String prompt)
        {
            Console.Write(prompt + " ");
            String input = Console.ReadLine();
            return input;
        }
    }
}
