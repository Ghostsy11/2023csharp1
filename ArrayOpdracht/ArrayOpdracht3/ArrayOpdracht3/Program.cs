using System;

namespace ArrayOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] nameparts = new string[] { "mar",  "chu"  , "io" , "li" ,  "pika" , "nk" };


            Console.WriteLine(nameparts[0] + nameparts[1] +nameparts[2] + nameparts[3] + nameparts[4] + nameparts[5]);
             
            string[] names = new string[] {"link " , "pikachu " ,  "linko " , "chumar " };
            Console.WriteLine(names[0] + names[1] + names[2] +names[3]);

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            //maak nu de volgende namen en schrijf het naar de console:

            //link

            //pikachu

            //linkio

            //chumar
        }
    }
}