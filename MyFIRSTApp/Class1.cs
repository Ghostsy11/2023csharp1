using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ClassOefening
{
    // internal wordt gebruikt om het functies toegankelijk te maken.
    internal class ClassStructureExercise  // dit is een class 
    {
        private readonly string accountName; // dit is een variable

        internal ClassStructureExercise(string accountName) // constructor en dit is hoe we ook start we de data op. 
        {
            this.accountName = accountName;
        }

        internal void ShowGreetingInConsole() // dit is een  functies en wat kunnen we met data doen.
        {
            string greeting = "hello";
            Console.WriteLine(greeting + " " + accountName);
        }

        internal void Show1To10() // dit is een functie
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2) // dit is een functie
        {

            int dx = x2 - x1;
            int dy = y2 - y1;

            double lengthSquared = (dx * dx) + (dy * dy);

            double length = Math.Sqrt(lengthSquared);
            return length;

        }
        internal int MultiplyToPower2(int value) // dit is een functie
        {
            int result = value * value;
            return result;
        }

    }
}
