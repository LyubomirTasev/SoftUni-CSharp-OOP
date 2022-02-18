using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly(); }
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.firstTeam.AsReadOnly(); }
        }

        int firstTeamCount = 0;
        int secondTeamCount = 0;

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
                firstTeamCount++;
            }
            else
            {
                reserveTeam.Add(person);
                secondTeamCount++;
            }
        }

        public override string ToString()
        {
            return $"First team has {firstTeamCount} players.";
        }
    }
}
