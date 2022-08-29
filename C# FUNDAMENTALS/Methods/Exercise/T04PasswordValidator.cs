using System;

namespace T04PasswordValidator
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
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool hasPasswordOnlyLettersAndDigits(string password)
        {
            bool hasPasswordJustLettersAndDigits = false;

            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];
                if ((currentSymbol >= 48 && currentSymbol <= 57) || (currentSymbol >= 65 && currentSymbol <= 90)
                    || (currentSymbol >= 97 && currentSymbol <= 122))
                {
                    hasPasswordJustLettersAndDigits = true;
                }
                else
                {
                    hasPasswordJustLettersAndDigits = false;
                    break;
                }
            }

            if (!hasPasswordJustLettersAndDigits)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static bool hasPasswordAtleast2Digits(string password)
        {
            bool hasPasswordAtLeast2Digits = false;
            int countOfDigist = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currSymbol = password[i];
                if (currSymbol >= 48 && currSymbol <= 57)
                {
                    countOfDigist++;
                    if (countOfDigist >= 2)
                    {
                        hasPasswordAtLeast2Digits = true;

                    }
                }
            }
            if (!hasPasswordAtLeast2Digits)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
