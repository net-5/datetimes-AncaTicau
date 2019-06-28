using System;
using System.Globalization;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDaysBetweenTwoDates();

            DisplayDateAndTimeInAstring();

            GetTimeInMiliseconds();

            GetTheDates30BeforeAndAfterCurrentDate();

            CalculateNumberOfDaysBetweenTwoDates();

            GetDateSixMonthFromCurrent();

            AddFiveSecondsToCurrentTime();

            PrintYesterdayTodayTomorrow();

            AddYearsToCurrentDate();

            GetNextFiveDaysFromToday();

            GetFirstAndLastSecondOfAday();

            CalculateAge();

            DisplayDate();

            GetSundaysOfYear();

            GetFirstMondayOfWeek();

            Console.ReadKey();
        }

        // Write a program to get days between two dates.

        public static void GetDaysBetweenTwoDates()
        {
            DateTime mozartBirthday = new DateTime(1756, 1, 27);
            DateTime mozartDeath = new DateTime(1791, 12, 5);

            TimeSpan daysAlive = mozartDeath.Subtract(mozartBirthday);
            Console.WriteLine(daysAlive.TotalDays + " days");
        }

        // Write a program to display the date and time in a human-friendly string.

        public static void DisplayDateAndTimeInAstring()
        {
            Console.WriteLine("\nExercise 2:");

            Console.WriteLine("The date and time now is {0}.", DateTime.Now.ToLongDateString());
        }

        // Write a program to get current time in milliseconds.

        public static void GetTimeInMiliseconds()
        {
            Console.WriteLine("\nExercise 3:");

            Console.WriteLine(Math.Floor((DateTime.Now - DateTime.Now.Date).TotalMilliseconds));
        }

        // Write a program to get the dates 30 days before and after from the current date, and display it to the console

        public static void GetTheDates30BeforeAndAfterCurrentDate()
        {
            Console.WriteLine("\nExercise 4: ");

            Console.WriteLine(DateTime.Now.AddDays(30).ToLongDateString());
            Console.WriteLine(DateTime.Now.AddDays(-30).ToLongDateString());
        }

        // Write a program to calculate a number of days between two dates.

        public static void CalculateNumberOfDaysBetweenTwoDates()
        {
            Console.WriteLine("\nExercise 5: ");

            DateTime firstDate = new DateTime(1988, 4, 10);
            DateTime secondDate = new DateTime(2000, 1, 1);
            TimeSpan numberOfDaysBetweenDates = secondDate - firstDate;
            Console.WriteLine(numberOfDaysBetweenDates.TotalDays);
        }

        // Write a program that calculates the date six months from the current date.

        public static void GetDateSixMonthFromCurrent()
        {
            Console.WriteLine("\nExercise 6: ");

            Console.WriteLine(DateTime.Now.AddMonths(6).ToLongDateString());
        }

        // Write a program to add 5 seconds to the current time and print it to the console.

        public static void AddFiveSecondsToCurrentTime()
        {
            Console.WriteLine("\nExercise 7: ");

            Console.WriteLine(DateTime.Now.AddSeconds(5));
        }

        // Write a program to print yesterday, today, tomorrow.

        public static void PrintYesterdayTodayTomorrow()
        {
            Console.WriteLine("\nExercise 8: ");

            Console.WriteLine("Today : {0}", DateTime.Now.ToShortDateString());
            Console.WriteLine("Yesterday : {0}", DateTime.Now.AddDays(-1).ToShortDateString());
            Console.WriteLine("Tomorrow : {0}", DateTime.Now.AddDays(1).ToShortDateString());
        }

        // Write a program to add N year(s) to the current date and display the new date.

        public static void AddYearsToCurrentDate()
        {
            Console.WriteLine("\nExercise 9: ");

            Console.WriteLine("Please enter a number, that represents the number of years that you want to be added to the current date.");
            int yearsToAdd = int.Parse(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddYears(yearsToAdd).ToShortDateString());
        }

        // Write program to print next 5 days starting from today.

        public static void GetNextFiveDaysFromToday()
        {
            Console.WriteLine("\nExercise 10: ");

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.AddDays(1).DayOfWeek);
            Console.WriteLine(DateTime.Now.AddDays(2).DayOfWeek);
            Console.WriteLine(DateTime.Now.AddDays(3).DayOfWeek);
            Console.WriteLine(DateTime.Now.AddDays(4).DayOfWeek);
        }

        // Write a program to get the first and last second of a day.

        public static void GetFirstAndLastSecondOfAday()
        {
            Console.WriteLine("\nExercise 11: ");

            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Date.AddDays(1).AddSeconds(-1));
        }

        // Given a date of birth, calculate the age of a person.

        public static void CalculateAge()
        {
            Console.WriteLine("\nExercise 12: ");

            DateTime dateOfBirth = new DateTime(1986, 9, 23);
            int age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age--;
            }

            Console.WriteLine("Your age is :{0}", age);
        }

        // Write a program to display the:
        // a) Current date and time
        // b) Current year
        // c) Month of year
        // d) Week number of the year
        // e) Weekday of the week
        // f) Day of year
        // g) Day of the month
        // h) Day of week
        // j) if the current year is a leap year or not

        public static void DisplayDate()
        {
            Console.WriteLine("\nExercise 13 : ");

            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Current date and time is: {currentDate}.");
            Console.WriteLine($"Current year is {currentDate.Year}.");
            Console.WriteLine($"Current month of the year is : {currentDate.Month}.");
            Console.WriteLine("Week number of the year: " + CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(currentDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday));
            Console.WriteLine($"Current day of the week is : {currentDate.DayOfWeek}.");
            Console.WriteLine($"Current day of the year is : {currentDate.DayOfYear}.");
            Console.WriteLine($"Current day of the month is : {currentDate.Day}.");

            if (currentDate.Day == (int)DayOfWeek.Saturday || currentDate.Day == (int)DayOfWeek.Sunday)
            {
                Console.WriteLine("Today is not a weekday...unfortunately.");
            }
            else
            {
                Console.WriteLine($"Current weekday is :{currentDate.DayOfWeek}.");
            }

            if (DateTime.IsLeapYear(currentDate.Date.Year))
            {
                Console.WriteLine("This year {0} is a leap year.", currentDate.Date.Year);
            }
            else
            {
                Console.WriteLine("This year, {0}, is not a leap year.", currentDate.Date.Year);
            }
        }

        // Write a program to select all the Sundays of a specified year and display their dates
        // Output:
        // 2020 - 01 - 05
        // 2020 - 01 - 12
        // 2020 - 01 - 19

        public static void GetSundaysOfYear()
        {
            Console.WriteLine("\nExercise number 14 : ");

            DateTime specifiedYear = new DateTime(2020, 1, 1);
            DateTime newDate = specifiedYear;

            do
            {
                if (newDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(newDate.ToString("yyyy - MM - dd"));
                }

                newDate = newDate.AddDays(1);
            } while (newDate.DayOfYear > specifiedYear.DayOfYear);
        }

        // Write a program to find the date of the first Monday of a given week
        // Input  : 2015, 50
        // Output: Mon Dec 14 00:00:00 2015

        public static void GetFirstMondayOfWeek()
        {
            Console.WriteLine("\nExercise 15: ");

            int year = 2015;
            int week = 50;

            DateTime specifiedYear = new DateTime(year, 1, 1);

            var specifiedYearMonday = specifiedYear.AddDays(week * 7 - (int)specifiedYear.DayOfWeek + 1);

            Console.WriteLine(specifiedYearMonday.ToLongDateString());
        }
    }
}


