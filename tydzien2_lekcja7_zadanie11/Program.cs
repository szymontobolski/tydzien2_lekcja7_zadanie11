using System;

namespace tydzien2_lekcja7_zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ocenę (cyfrę)");
            int ocena = int.Parse(Console.ReadLine());
            switch (ocena)
            {
                case 1:
                        Console.WriteLine("niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                        case 4:
                    Console.WriteLine("Dobry");
                    break;
                        case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujacy");
                    break;
            }
        }
    }
}
