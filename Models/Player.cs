using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Models
{
    internal class Player
    {
        static int DEFAULT_AGE = 18;
        private int _id; 
        private string _name;
        private int _age ;

        public int Id { get { return _id; } }

        public string Name { get { return _name; } }

        public int Age { get { return _age; } }


        public Player(int id , string name)
        {
            _id = id;
            _name = name;
            _age = DEFAULT_AGE;

        }
        public Player(int id , string name , int age):this(id ,name) {
            _age = age; 
        }

        public static Player WhoIsElder(Player[] players)
        {
            int maxAge = 0;
            Player playerWithMaxAge = null;
            foreach (Player player in players)
            {
                if (player.Age > maxAge)
                {
                    playerWithMaxAge = player;
                    maxAge = player.Age;
                }
            }
            return playerWithMaxAge;

        }

        public override string ToString()
        {
            return $"Id : {Id} \nName : {Name} \nAge : {Age}";
        }
    }
}
