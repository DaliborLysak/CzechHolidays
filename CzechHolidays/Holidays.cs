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

    public IEnumerable<Holiday> GetCatalogForYear(int year)
    {
        return this.holidayCatalog.GetCatalog(year);
    }

    public IEnumerable<Holiday> GetOpenShopsDays()
    {
        return this.holidayCatalog.GetCatalog(2000).Where(d => d.ShopsOpen == true);
    }
}