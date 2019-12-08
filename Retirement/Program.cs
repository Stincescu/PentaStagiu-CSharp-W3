using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    class Program
    {
       public enum Genders
        {
           Female,
            Male
        }
       public static DateTime GetUserBirthDate()
        {
            Console.Write("Please enter the year of birth: ");
            string year = Console.ReadLine();

            Console.Write("Please enter the month of birth: ");
            string month = Console.ReadLine();

            Console.WriteLine("Please enter the day of birth: ");
            string day = Console.ReadLine();

            int y = int.Parse(year);
            int m = int.Parse(month);
            int d = int.Parse(day);

            DateTime dateOfBirth = new DateTime(y, m, d);

            return dateOfBirth;
        }
       public static int ConvertToAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Now;
            TimeSpan age = now - dateOfBirth;
            int ageInYears = (int)age.TotalDays / 365;

            return ageInYears;
        }
       public static string ValidateGender(char? genderInput)
        {
            string genderValid = null;

            if (genderInput == 'M' || genderInput == 'm')
            {
                genderValid =nameof(Genders.Male);
            }
            else if (genderInput == 'F' || genderInput == 'f')
            {
                genderValid =nameof(Genders.Female);  
            }
            else
            {
                genderValid = null;
                Console.WriteLine("\nYou have entered and invalid gender");
            }
            return genderValid;
        }
       public static void CheckRetirementAge(string genderValid, int ageInYears)
        {
            if (genderValid != null)
            {
                if (genderValid == "Female")
                {
                    if (ageInYears < 63)
                    {
                        Console.WriteLine($"\nYou may retire in {63 - ageInYears} years");
                    }
                    else
                    {
                        Console.WriteLine("\nCongratulations, you are retired!");
                    }
                }
                else
                {
                    if (ageInYears < 65)
                    {
                        Console.WriteLine($"\nYou may retire in {65 - ageInYears} years");
                    }
                    else
                    {
                        Console.WriteLine("\nCongratulations, you are retired!");
                    }

                }
            }
        }

       static void Main(string[] args)
        {
            DateTime dateOfBirthUser = GetUserBirthDate();
            int ageInYears=ConvertToAge(dateOfBirthUser);
            Console.WriteLine($"Your age is {ageInYears}");

            Console.WriteLine("Please enter your gender M/F");
            char? genderInput = null;
            genderInput = Console.ReadKey().KeyChar;
            
            string genderValid = null;
            genderValid = ValidateGender(genderInput);

            CheckRetirementAge(genderValid, ageInYears);
        }
        
    }
}
