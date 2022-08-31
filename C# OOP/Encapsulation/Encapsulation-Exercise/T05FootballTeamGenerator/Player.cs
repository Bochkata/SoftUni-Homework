

using System;

namespace FootballTeamGenerator
{
    public class Player
    {

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
                }
        }
       
        public int Endurance
        {
            get { return endurance; }
            private set
            {
                CheckValidation(nameof(Endurance), value);
                endurance = value;
            }
        }
        
        public int Sprint
        {
            get { return sprint; }
            private set
            {
                CheckValidation(nameof(Sprint), value);
                sprint = value;
            }
        }
       
        public int Dribble
        {
            get { return dribble; }
            private set
            {
                CheckValidation(nameof(Dribble), value);
                dribble = value;
            }
        }
       public int Passing
        {
            get { return passing; }
            private set
            {
                CheckValidation(nameof(Passing), value);
                passing = value;
            }
        }
        
        public int Shooting
        {
            get { return shooting; }
            private set
            {
                CheckValidation(nameof(Shooting), value);
                shooting = value;
            }
        }

        public int Stats => (int)Math.Round((endurance + sprint + dribble + passing + shooting) / 5.00);

        private void CheckValidation(string stat, int value)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{stat} should be between 0 and 100.");
            }
        }
    }
}
