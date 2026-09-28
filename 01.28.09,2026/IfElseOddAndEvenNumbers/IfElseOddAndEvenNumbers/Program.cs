using System.Diagnostics.Contracts;

namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib numbrit
            //number tuleb ära pärsida
            Console.WriteLine("sisesta number");


            //if ja else juures toimub kontroll, et
            //kas on paaris ja paaritu nr
            //mida % operaator tähendab
            //see leiab jäägi komakohast ja nii kaua kontrollib, kas on 0
            string arv = Console.ReadLine();
            int number = int.Parse(arv);

            if (number % 2 == 0)
            {
                Console.WriteLine("see on paaris arv");

            }
            else
            {
                Console.WriteLine("see on paaritu arv");

            }





            //kutsuda paarisarvu ja paarituarvu tekst välja
            //läbi meetodi kutsumise

        }

        static void EvenNumber()
        {
            Console.WriteLine("Paaris");
        }

        static void Oddnumber()
        {
            Console.WriteLine("Paaritu");
        }
    }
}
