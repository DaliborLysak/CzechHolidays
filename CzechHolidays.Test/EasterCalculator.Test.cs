using Xunit;

namespace CzechHolidays.Test;
public class EasterCalculatorTest
{
    [Theory]
    [InlineData(2050, 4, 10)]
    [InlineData(2023, 4, 9)]
    [InlineData(2010, 4, 4)]
    [InlineData(2000, 4, 23)]
    public void GetEasterSundayTest(int actualYear, int expectedMonth, int expectedDay)
    {
        var easterCalculator = new EasterCalculator();

        var actualHoliday = easterCalculator.GetEasterDependedDay(actualYear, 0, string.Empty, string.Empty, false);

        Assert.Equal(expectedMonth, actualHoliday.MonthNumber);
        Assert.Equal(expectedDay, actualHoliday.DayNumber);
    }
}