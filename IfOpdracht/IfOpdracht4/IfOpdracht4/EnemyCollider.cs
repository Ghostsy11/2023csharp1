﻿namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            if (enemy.walker )
            {
                return false;
            }
            else 
            {


                return true;
            }




            

            
            
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
        }
        internal bool CanPassWater(Enemy enemy)
        {
            if (enemy.walker ) { return false; }

            else 
            {
                return true;
            }
          
        }

        
        

    }
}