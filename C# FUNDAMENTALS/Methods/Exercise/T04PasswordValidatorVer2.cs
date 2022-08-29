using System;

namespace T04PasswordValidatorVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (IsPasswordLongBetween6And10Characters(password) && hasPasswordOnlyLettersAndDigits(password)
                && hasPasswordAtleast2Digits(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (!IsPasswordLongBetween6And10Characters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!hasPasswordOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!hasPasswordAtleast2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }

        static bool IsPasswordLongBetween6And10Characters(string password)
        {

            return password.Length >= 6 && password.Length <= 10 ? true : false;

        }

        static bool hasPasswordOnlyLettersAndDigits(string password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];
                if (!char.IsLetterOrDigit(currentSymbol))
                {
                    return false;
                }
            }

            return true;

        }

        static bool hasPasswordAtleast2Digits(string password)
        {

            int countOfDigist = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currSymbol = password[i];
                if (char.IsDigit(currSymbol))
                {
                    countOfDigist++;

                }
            }

            return countOfDigist >= 2 ? true : false;
        }
    }
}
