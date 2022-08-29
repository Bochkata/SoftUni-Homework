using System;

namespace T09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());

            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double spentMoney = saberPrice * countOfStudents + saberPrice * Math.Ceiling(0.10 * countOfStudents) + 
                robePrice * countOfStudents + beltPrice * countOfStudents;

            if (countOfStudents >= 6)
            {
                double freeBelts = Math.Floor(1.0 * countOfStudents / 6);
                spentMoney -= freeBelts * beltPrice;
            
            }
            if (availableMoney >= spentMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {spentMoney:f2}lv.");

            }
            else if (spentMoney > availableMoney)
            {
                Console.WriteLine($"John will need {Math.Abs(spentMoney - availableMoney):f2}lv more.");
            
            }

        }
    }
}
