using System;
using System.IO;
using static VariableOpdracht2.TwitchStream;

namespace VariableOpdracht2
{
    internal class Program
    {
 
        //class variables & gebruik
        static void Main(string[] args)
        {
            
            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();
            twitchStream.FirstName = "Land";
            twitchStream.LastName = "Mark";
            twitchStream.streamGame = "EscapeFromTarkov";
            twitchStream.followers = 1000000;
            twitchStream.automod = true;


            //geef nu de stream de volgende waardes:
            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?




            Console.WriteLine(twitchStream.FirstName);
            Console.WriteLine(twitchStream.LastName);
            Console.WriteLine(twitchStream.streamGame);
            Console.WriteLine(twitchStream.followers);
            Console.WriteLine(twitchStream.automod);
        }
    }
}