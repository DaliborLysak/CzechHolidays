namespace CzechHolidays;
public class Holidays
{
    public Holidays()
    {
        this.easterCalculator = new EasterCalculator();
        this.holidayCatalog = new HolidayCatalog(this.easterCalculator);
    }

    private readonly EasterCalculator easterCalculator;
    private readonly HolidayCatalog holidayCatalog;

    public IEnumerable<Holiday> GetCzechCatalogForYear(int year)
    {
        return this.holidayCatalog.GetCzechCatalog(year);
    }
}