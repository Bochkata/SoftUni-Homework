using System;
using System.Collections.Generic;
using System.Linq;
using T07MilitaryElite.Enums;
using T07MilitaryElite.Models;

namespace T07MilitaryElite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string command;
            List<Soldier> soldiers = new List<Soldier>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case nameof(Private):
                        string privateID = tokens[1];
                        string privateFirstName = tokens[2];
                        string privateLastName = tokens[3];
                        decimal privateSalary = decimal.Parse(tokens[4]);
                        soldiers.Add(new Private(privateID, privateFirstName, privateLastName, privateSalary));
                        break;
                    case nameof(LieutenantGeneral):
                        string leutenantID = tokens[1];
                        string leutenantFirstName = tokens[2];
                        string leutenantLastName = tokens[3];
                        decimal leutenantSalary = decimal.Parse(tokens[4]);
                        LieutenantGeneral leutenantGeneral = new LieutenantGeneral(leutenantID, leutenantFirstName,
                            leutenantLastName, leutenantSalary);
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            Private priv = (Private)soldiers.FirstOrDefault(x => x.ID == tokens[i]);
                            leutenantGeneral.Privates.Add(priv);
                        }
                        soldiers.Add(leutenantGeneral);
                        break;
                    case nameof(Engineer):

                        string engineerID = tokens[1];
                        string engineerFirstName = tokens[2];
                        string engineerLastName = tokens[3];
                        decimal engineerSalary = decimal.Parse(tokens[4]);
                        bool isCorpsValid = Enum.TryParse(tokens[5], out Corps corpsEng);
                        if (!isCorpsValid)
                        {
                            continue;
                        }

                        Engineer engineer = new Engineer(engineerID, engineerFirstName, engineerLastName,
                            engineerSalary, corpsEng); ;
                        for (int i = 6; i < tokens.Length - 1; i += 2)
                        {
                            string repairPartName = tokens[i];
                            int repairHoursWorkded = int.Parse(tokens[i + 1]);
                            Repair repairPart = new Repair(repairPartName, repairHoursWorkded);
                            engineer.Repairs.Add(repairPart);
                        }
                        soldiers.Add(engineer); break;
                    case nameof(Commando):
                        string commandoID = tokens[1];
                        string commandoFirstName = tokens[2];
                        string commandoLastName = tokens[3];
                        decimal commandoSalary = decimal.Parse(tokens[4]);
                        bool isCommCorpsValid = Enum.TryParse(tokens[5], out Corps commandoCorps);
                        if (!isCommCorpsValid)
                        {
                            continue;
                        }

                        Commando commando = new Commando(commandoID, commandoFirstName, commandoLastName,
                            commandoSalary, commandoCorps);
                        for (int i = 6; i < tokens.Length - 1; i += 2)
                        {
                            string missionCodeName = tokens[i];
                            string missionState = tokens[i + 1];
                            bool isValidMission = Enum.TryParse(missionState, out MissionState commandoMissionState);
                            if (isValidMission)
                            {
                                Mission mission = new Mission(missionCodeName, commandoMissionState);
                                commando.Missions.Add(mission);
                            }
                        }
                        soldiers.Add(commando);
                        break;
                    case nameof(Spy):
                        string spyID = tokens[1];
                        string spyFirstName = tokens[2];
                        string spyLastName = tokens[3];
                        int spyCodeNumber = int.Parse(tokens[4]);
                        Spy spy = new Spy(spyID, spyFirstName, spyLastName, spyCodeNumber);
                        soldiers.Add(spy);
                        break;
                        }
            }

            foreach (Soldier sold in soldiers)
            {
                Console.WriteLine(sold.ToString());
            }
        }
    }
}
