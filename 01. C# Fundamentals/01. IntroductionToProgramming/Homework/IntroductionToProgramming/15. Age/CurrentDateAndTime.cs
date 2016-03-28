namespace _15.Age
{
    using System;

    public class CurrentDateAndTime
    {
        public static void Main()
        {
            string[] birthday = Console.ReadLine().Split('.');
            int monthOfBirth = int.Parse(birthday[0]);
            int dayOfBirth = int.Parse(birthday[1]);
            int yearOfBirth = int.Parse(birthday[2]);
            string[] dateTimeNow = DateTime.Now.ToString().Split(new char[] { '/', ':', '.', ' ' });
            int currentMonth = int.Parse(dateTimeNow[0]);
            int currentDay = int.Parse(dateTimeNow[1]);
            int currentYear = int.Parse(dateTimeNow[2]);

            int currentYears = 0;

            if (currentMonth >= monthOfBirth)
            {
                if (currentMonth > monthOfBirth)
                {
                    currentYears = currentYear - yearOfBirth;
                }
                else
                {
                    if (currentDay >= dayOfBirth)
                    {
                        currentYears = currentYear - yearOfBirth;
                    }
                    else
                    {
                        currentYears = (currentYear - yearOfBirth) - 1;
                    }
                }
            }
            else
            {
                currentYears = (currentYear - yearOfBirth) - 1;
            }

            Console.WriteLine("{0}", currentYears);
            Console.WriteLine("{0}", currentYears + 10);
        }
    }
}

// Write a program that reads your birthday(in the format MM.DD.YYYY) 
// from the console and prints on the console how old you are you now and how old will you be after 10 years.