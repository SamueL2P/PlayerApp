
using PlayerApp.Models;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = 
            {
                new Player(1 , "Samuel "),
                new Player(2 , "Arjun" , 23),
                new Player(3 , "Sam" , 34),
                new Player(4 , "Saroj" , 34),
                new Player(5 , "Ramesh" , 56),
                
            };

            
            Player player = Player.WhoIsElder(players);
            Console.WriteLine("Player with max age : ");
            Console.WriteLine(player);

            
            
        }
    }
}
