using System;
using System.Collections.Generic;
using System.Linq;

namespace T07StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine()) * 2;

            Dictionary<string, List<double>> allStudentsAllGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfCommands; i+=2)
            {
                string currentStudent = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (!allStudentsAllGrades.ContainsKey(currentStudent))
                {
                    allStudentsAllGrades.Add(currentStudent, new List<double>());
                    allStudentsAllGrades[currentStudent].Add(currentGrade);

                }
                else
                {
                    allStudentsAllGrades[currentStudent].Add(currentGrade);

                }
                
            }

            allStudentsAllGrades = allStudentsAllGrades
                .Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(x=>x.Value.Average())
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (KeyValuePair<string, List<double>> student in allStudentsAllGrades)
            {
                
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }

        }
        
    }
}
