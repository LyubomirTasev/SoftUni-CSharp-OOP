using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(Name)} should not be empty.");
                }

                this.name = value;
            }
        }

        public int GetTeamRating => TeamRating();

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            Player player = this.players.FirstOrDefault(x => x.Name == name);

            if (player is null)
            {
                throw new InvalidOperationException($"Player {name} is not in {this.Name} team.");
            }

            this.players.Remove(player);
        }

        private int TeamRating()
        {
            int rating = default;

            foreach (Player player in players)
            {
                rating += player.GetSkillLevel;
            }

            if (rating == 0)
            {
                return 0;
            }

            return rating / players.Count;
        }
    }
}
