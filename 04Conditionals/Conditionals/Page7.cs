namespace Conditionals
{
    public class CalendarFun
    {

        public static int GetDaysInMonth(int monthNumber)
        {
            int daysInMonth = -1;
            switch (monthNumber)
            {
                case 1:
                    daysInMonth = 28;
                    break;
                case 3:
                case 5:
                case 8:
                case 10:
                    daysInMonth = 30;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }
            return daysInMonth;
        }

        public static int GetDaysInMonth(string monthName)
        {
            int daysInMonth = -1;
            switch (monthName)
            {
                case "February":
                    daysInMonth = 28;
                    break;
                case "April":
                case "June":
                case "November":
                case "September":
                    daysInMonth = 30;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }
            return daysInMonth;
        }
    }
}