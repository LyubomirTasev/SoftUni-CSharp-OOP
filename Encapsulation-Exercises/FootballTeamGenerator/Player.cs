using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private const int MinStatValue = 0;
        private const int MaxStatValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name,
                      int endurance,
                      int sprint,
                      int dribble,
                      int passing,
                      int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(Name)} should not be empty.");
                }

                this.name = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                ValidateStat(value, nameof(Endurance));

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                ValidateStat(value, nameof(Sprint));

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                ValidateStat(value, nameof(Dribble));

                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                ValidateStat(value, nameof(Passing));

                this.passing = value;
            }
        }

        public int Shooting
        {
            get => this.shooting;
            private set
            {
                ValidateStat(value, nameof(Shooting));

                this.shooting = value;
            }
        }

        public int GetSkillLevel => SkillLevel();

        private int SkillLevel()
        {
            double count = 5.0;
            return (int)Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / count);
        }

        private void ValidateStat(int value, string statName)
        {
            if (value <= MinStatValue || value >= MaxStatValue)
            {
                throw new ArgumentException($"{statName} should be between {MinStatValue} and {MaxStatValue}.");
            }
        }

    }
}
