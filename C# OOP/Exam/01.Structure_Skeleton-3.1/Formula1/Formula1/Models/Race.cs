using System;
using System.Collections.Generic;
using System.Text;
using Formula1.Models.Contracts;
using Formula1.Utilities;

namespace Formula1.Models
{
   public class Race:IRace
   {
       private string raceName;
       private int numberOfLaps;
       private bool tookPlace;
       private List<IPilot> pilots;

       public Race(string raceName, int numberOfLaps)
       {
           RaceName = raceName;
           NumberOfLaps = numberOfLaps;
           pilots = new List<IPilot>();
           TookPlace = false;
       }
        public string RaceName
        {
            get { return raceName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidRaceName, value));
                }

                raceName = value;
            }
        }
        public int NumberOfLaps
        {
            get { return numberOfLaps; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidLapNumbers, value));
                }

                numberOfLaps = value;
            }
        }
        public bool TookPlace
        {
            get { return tookPlace; }
             set
            {
                tookPlace = value;
            }
        }
        public ICollection<IPilot> Pilots => pilots;
        public void AddPilot(IPilot pilot)
        {
            pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            StringBuilder sb = new StringBuilder();
            string result = TookPlace ? "Yes" : "No";
            sb.AppendLine($"The {RaceName} race has:");
           sb.AppendLine($"Participants: {Pilots.Count}");
           sb.AppendLine($"Number of laps: {NumberOfLaps}");
           sb.AppendLine($"Took place: {result}");
           return sb.ToString().TrimEnd();

        }
    }
}
