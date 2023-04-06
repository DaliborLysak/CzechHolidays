namespace CzechHolidays;
internal class EasterCalculator : IEasterCalculator
{
    public Holiday GetEasterDependedDay(int year, int dayShift, string name, string description)
    {
        var easterSunday = this.GetEasterSunday(year);
        var date = new DateTime(year, easterSunday.MonthNumber, easterSunday.DayNumber).AddDays(dayShift);
        return new Holiday() { YearNumber = year, MonthNumber = date.Month, DayNumber = date.Day, Name = name, Description = description };
    }

    private Holiday GetEasterSunday(int year)
    {
        var day = 0;
        var month = 0;
        var doubleDecade = year % 19;
        var centuries = year / 100;
        var x = (centuries - (centuries / 4) - ((8 * centuries + 13) / 25) + 19 * doubleDecade + 15) % 30;
        var y = x - (x / 28) * (1 - (x / 28) * (29 / (x + 1)) * ((21 - doubleDecade) / 11));

        day = y - ((year + (year / 4) + y + 2 - centuries + (centuries / 4)) % 7) + 28;
        month = 3;

        if (day > 31)
        {
            month++;
            day -= 31;
        }

        return new Holiday() { MonthNumber = month, DayNumber = day };
    }
}