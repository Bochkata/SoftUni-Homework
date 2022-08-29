using System;
using System.Collections.Generic;
using System.Linq;

namespace T08CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Dictionary<string, List<string>> allCompaniesAllEmployees = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] companyAndEmployeeID = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string currentCompanyName = companyAndEmployeeID[0];
                string currentEmployeeID = companyAndEmployeeID[1];

                if (!allCompaniesAllEmployees.ContainsKey(currentCompanyName))
                {
                    allCompaniesAllEmployees.Add(currentCompanyName, new List<string>());
                    allCompaniesAllEmployees[currentCompanyName].Add(currentEmployeeID);
                }
                else
                {
                    if (!allCompaniesAllEmployees[currentCompanyName].Contains(currentEmployeeID))
                    {
                        allCompaniesAllEmployees[currentCompanyName].Add(currentEmployeeID);
                    }
                }
                
                input = Console.ReadLine();
            }

            allCompaniesAllEmployees = allCompaniesAllEmployees.OrderBy(x => x.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (KeyValuePair<string, List<string>> company in allCompaniesAllEmployees)
            {
                Console.WriteLine($"{company.Key}");
                Console.WriteLine($"-- {String.Join("\n-- ", company.Value)}");
            }

        }
    }
}
