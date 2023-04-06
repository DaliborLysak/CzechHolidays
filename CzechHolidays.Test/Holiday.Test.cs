using Xunit;

namespace CzechHolidays.Test;
public class HolidayTest
{
    [Theory]
    [InlineData(1, 1, 1, "", "", "01.01.0001  ")]
    [InlineData(2023, 3, 14, "TestName", "TestDescription", "14.03.2023 TestName TestDescription")]
    public void ToStringTest(
        int actualYear, int actualMonth, int actualDay, string actualName, string actualDescription, string expectedToString)
    {
        var holiday = new Holiday()
        {
            YearNumber = actualYear,
            MonthNumber = actualMonth,
            DayNumber = actualDay,
            Name = actualName,
            Description = actualDescription
        };

        var actualToString = holiday.ToString();
        
        Assert.Equal(expectedToString, actualToString);
    }
}