using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class CricketTeam
    {
        private List<Player> players = new List<Player>();

        public void AddPlayer(int playerId, string playerName, int playerAge)
        {
            if (players.Count < 11)
            {
                Player player = new Player(playerId, playerName, playerAge);
                players.Add(player);
                Console.WriteLine($"Player {playerName} added to the team.");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
            }
        }

        public void RemovePlayer(int playerId)
        {
            Player playerToRemove = players.Find(player => player.PlayerId == playerId);

            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player with ID {playerId} ({playerToRemove.PlayerName}) removed from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {playerId} not found in the team.");
            }
        }

        public Player GetPlayerDetailsById(int playerId)
        {
            return players.Find(player => player.PlayerId == playerId);
        }

        public Player GetPlayerDetailsByName(string playerName)
        {
            return players.Find(player => player.PlayerName.Equals(playerName, StringComparison.OrdinalIgnoreCase));
        }

        public List<Player> GetAllPlayerDetails()
        {
            return players;
        }
    }
}