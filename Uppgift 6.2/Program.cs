using System;
namespace Uppgift_6._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal:");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            StörstaVärde(tal1, tal2);
            Console.WriteLine($"Det Största tal är: {StörstaVärde(tal1, tal2)}");
        }

        static int StörstaVärde(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
            if (tal1 < tal2)
            {
                return tal2;
            }
            else
            {
                return tal1;
            }
            if (tal1 == tal2)
            {
                return tal1;
                return tal2;
            }
            else
            {
                return tal2;
                return tal1;
            }
        }
    }
}