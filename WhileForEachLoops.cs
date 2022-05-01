using System;

namespace WhileForeachLoops
{
    class Programme
    {
        static void Main(string[] args)
        {
            //While
            
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            int total = 0;
            while (count <= sayi)
            {
                total += number;
                count++;
            }
            Console.WriteLine(toplam / number);

            
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            //Foreach
            string[] cars = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var car in cars)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
