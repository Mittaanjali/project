using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Player
    {
        public int PlayerId { get; }
        public string PlayerName { get; }
        public int PlayerAge { get; }

        public Player(int playerId, string playerName, int playerAge)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            PlayerAge = playerAge;
        }
        public override string ToString()
        {
            return $"ID: {PlayerId}, Name: {PlayerName}, Age: {PlayerAge}";
        }
    }
}
