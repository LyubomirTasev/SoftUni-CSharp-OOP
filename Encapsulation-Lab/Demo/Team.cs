using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Team
    {
        private string name;
        private List<DemoClass> firstTeam;
        private List<DemoClass> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<DemoClass>();
            this.reserveTeam = new List<DemoClass>();
        }

        public string Name => this.name;
        public IReadOnlyList<DemoClass> FirstTeam => this.firstTeam;
        public IReadOnlyList<DemoClass> ReserveTeam => this.reserveTeam;

        public void AddPlayer(DemoClass player)
        {
            if (player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }
    }
}
