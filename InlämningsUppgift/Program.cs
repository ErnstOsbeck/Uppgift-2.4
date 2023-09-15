using System;

namespace uppgift_2._4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket känar den första?");
            int lön1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket känar den andra?");
            int lön2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket känar den tredje?");
            int lön3 = int.Parse(Console.ReadLine());
            int medel = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medellönen är " + medel + "kronor");
            Console.Read();
        }
    }
}