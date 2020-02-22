using System;

namespace Lab_01_Levchuk.Models
{
   internal static class BirthdayInfo
    {
        private static DateTime _birthday;
        //Eastern zodiacs helping array, for easier and faster computation of the "EasternZodiac" method
        private static string[] _eZodiacs = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat" };
        public static DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public static int GetAge(DateTime enteredDate)
        {
            int Age = DateTime.Now.Year - enteredDate.Year;
            if (enteredDate.AddYears(Age) > DateTime.Now) Age--;
            return Age;
        }

        public static bool IsBirthday(DateTime enteredDate)
        {
            if (DateTime.Now.Month == enteredDate.Month && DateTime.Now.Day == enteredDate.Day) return true;
            return false;
        }
       public static string WesternZodiac(DateTime enteredDate)
        {
            int Month = enteredDate.Month, Day = enteredDate.Day;
            switch (Month) {
                case 1:
                    if (Day < 20)
                        return "Capricorn";
                    else
                        return "Aquarius";
                case 2:
                    if (Day < 19)
                        return "Aquarius";
                    else
                        return "Pisces";
                case 3:
                        if (Day < 21)
                            return "Pisces";
                        else
                            return "Aries";
                case 4:
                        if (Day < 20)
                            return "Aries";
                        else
                            return "Taurus";
                case 5:
                        if (Day < 21)
                            return "Taurus";
                        else
                            return "Gemini";
                case 6:
                        if (Day < 21)
                            return "Gemini";
                        else
                            return "Cancer";
                case 7:
                        if (Day < 23)
                            return "Cancer";
                        else
                            return "Leo";
                case 8:
                        if (Day < 23)
                            return "Leo";
                        else
                            return "Virgo";
                case 9:
                        if (Day < 23)
                            return "Virgo";
                        else
                            return "Libra";
                case 10:
                        if (Day < 23)
                            return "Libra";
                        else
                            return "Scorpio";
                case 11:
                        if (Day < 22)
                            return "Scorpio";
                        else
                            return "Sagittarius";
                default:
                        if (Day < 22)
                            return "Sagittarius";
                        else
                            return "Capricorn";
            }
        }
        public static string EasternZodiac(DateTime enteredDate)
        {
            return _eZodiacs[enteredDate.Year % 12];
                }
        }
    }
