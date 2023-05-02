using System.Linq;
using Xunit;

namespace CzechHolidays.Test;
public class HolidaysTest
{
    [Fact]
    public void GetOpenShopsDaysTest()
    {
        var openShopsDays = new Holidays().GetOpenShopsDays();

        Assert.Equal(5, openShopsDays.ToList().Count);
    }
}