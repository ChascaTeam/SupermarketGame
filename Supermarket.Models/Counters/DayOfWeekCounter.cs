namespace Supermarket.Models.Counters
{
    using System;

    public class DayOfWeekCounter
    {
        private DayOfWeek weekDay;

        public string GetDayOfWeek(int day)
        {
            var dayOfWeek = day % 7;

            if (Enum.TryParse(dayOfWeek.ToString(), out this.weekDay))
            {
                return this.weekDay.ToString();               
            }

            return "";
        }
    }
}
