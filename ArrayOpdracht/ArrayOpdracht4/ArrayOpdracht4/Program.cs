using System;

namespace ArrayOpdracht4
{
   
    
        
    internal class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");

            
            Enemy[] enemies = new Enemy[10] ;
            //enemies[0] = new Enemy(1);
            
            //instance method
            Random random= new Random();
            //Random r2 = new Random();

            //static method
            //sMath.Ceiling(6.8f);

            //enemies[0];
            //enemies[0] = enemies;
            //enemies[1] = enemy;
            //enemies[2] = "Eenmy";


            
            //maak een array van 10 enemies het onderstaande code blok gaat werken


            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new Enemy(random.Next(0,2)) ;
                Console.WriteLine(enemies[i]);


            }
          
          
        }
    
    
    }

}