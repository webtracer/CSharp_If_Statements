using System;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature outside? ");
            string temperature = Console.ReadLine();
            int numTemp; // = int.Parse(temperature);
            int num;

            if (int.TryParse(temperature, out num))
            {
                numTemp = num;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine($"Value entered was not a number, it was {temperature}, temperature was set to 0");
            }

            if(numTemp < 40)
            {
                Console.WriteLine("You will need your coat today");
            }else if(numTemp < 60)
            {
                Console.WriteLine("Pants and a hoodie should suffice");
            }else if(numTemp > 90)
            {
                Console.WriteLine("Looks like a scorcher ... Enjoy!");
            }else
            {
                Console.WriteLine("Shorts and tee shirt are good");
            }

            Console.Read();
        }
    }
}
