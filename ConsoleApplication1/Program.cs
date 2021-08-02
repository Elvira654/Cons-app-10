using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Napisati program koji na osnovu trajanja telefonskog razgovora i cijene u minutama
izračunava cijenu telefonskog razgovora, ako je vikendom popust od 10%. U programu
treba predvidjeti unos indikatora za dan razgovora 1-radni dan, 2-vikend.*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, x;
            do
            {
            Console.WriteLine("Odaberite termin razgovora (1-radni dan, 2-vikend): ");
             x = int.Parse(Console.ReadLine());
            } while (x < 1 || x > 2);

            Console.WriteLine("Duzina trajanja razgovora: ");
            min = int.Parse(Console.ReadLine());

            if (x == 1)
                Console.WriteLine("Cijena razgovora je " + (min * 0.14));
            else
                Console.WriteLine("Cijena razgovora je " + (min * 0.14 * 0.9));

            Console.ReadKey();
        }
    }
}
