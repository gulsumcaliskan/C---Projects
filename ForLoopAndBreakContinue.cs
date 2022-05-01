using System;

namespace ForLoopBreakContinue
{
    class Programme
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter a number: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            
            int oddTotal = 0;
            int evenTotal = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    oddTotal += i;
                }
                else
                {
                    evenTotal += i;
                }
            }
            Console.WriteLine("Odd Total : " + oddTotal);
            Console.WriteLine("Even Total : " + evenTotal);

            //break, continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;                    
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
