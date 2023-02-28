using System;

namespace ForOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            float[] vectors = new float[] { 6, 7, 8, 1, 4, 0 };//2 vectoren (6,7,8) en (1,4,0) achter elkaar net als bij shaders

            for (int i = 0; i < 1; i++)
            {
                float x = vectors[(i)];//pak hier de waarde op index i (x)
                float y = vectors[(i+1)] ;//pak hier de waarde op index i + 1 (y)
                float z = vectors[(i+2)] ;//pak hier de waarde op index i + 2 (z)
                Console.WriteLine($"vector1 {x}, {y}, {z}");
            }

            for (int i = 3; i < 4; i++)
            {
                float x = vectors[(i)];//pak hier de waarde op index i (x)
                float y = vectors[(i+1)] ;//pak hier de waarde op index i + 1 (y)
                float z = vectors[(i+2)] ;//pak hier de waarde op index i + 2 (z)
                Console.WriteLine($"vector2 {x}, {y}, {z}");
            }

            for (int i = 0; i < vectors.Length; i = i+3 )
            {
                float x = vectors[(i)];//pak hier de waarde op index i (x)
                float y = vectors[(i + 1)];//pak hier de waarde op index i + 1 (y)
                float z = vectors[(i + 2)];//pak hier de waarde op index i + 2 (z)
                Console.WriteLine($"vectors {x}, {y}, {z}");
            }

        }
    }
}