using System;

namespace ForOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] straten = new string[] { "", "" };

            for (int i = 0; i < straten.Length; i++)
            {
                string straat = "assaas";// haal de waarde uit de straten array die op index i staat met []
                Console.WriteLine(straat);
            }
        }
    }
}