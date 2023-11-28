using Xunit;

namespace CzechHolidays.Test;
public class HolidayTest
{
    [Theory]
    [InlineData(1, 1, 1, "", "", "01.01.0001 po  ")]
    [InlineData(2023, 3, 14, "TestName", "TestDescription", "14.03.2023 út TestName TestDescription")]
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

    [Theory]
    [InlineData(1, 1, 1, "", "", "dd.MM.yyyy ddd", "01.01.0001 po  ")]
    [InlineData(2023, 3, 14, "TestName", "TestDescription", "dd.MM.yyyy ddd", "14.03.2023 út TestName TestDescription")]
    [InlineData(1, 1, 1, "", "", "dd.MM.yyyy", "01.01.0001  ")]
    [InlineData(2023, 3, 14, "TestName", "TestDescription", "dd.MM.yyyy", "14.03.2023 TestName TestDescription")]
    public void ToStringFormatedTest(
        int actualYear,
        int actualMonth,
        int actualDay,
        string actualName,
        string actualDescription,
        string actualDateFormat,
        string expectedToString)
    {
        var holiday = new Holiday()
        {
            YearNumber = actualYear,
            MonthNumber = actualMonth,
            DayNumber = actualDay,
            Name = actualName,
            Description = actualDescription
        };

        var actualToString = holiday.ToString(actualDateFormat);

        Assert.Equal(expectedToString, actualToString);
    }
}