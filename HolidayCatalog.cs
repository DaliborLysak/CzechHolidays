namespace CzechHolidays;
internal class HolidayCatalog
{
    internal HolidayCatalog(EasterCalculator easterCalculator)
    {
        this.easterCalculator = easterCalculator;
    }

    private readonly EasterCalculator easterCalculator;

    public IEnumerable<Holiday> GetCzechCatalog(int year)
    {
        var holidays = new List<Holiday>()
            {
                new Holiday() { MonthNumber = 1, DayNumber = 1, YearNumber = year, Name ="Nový rok, Den obnovy samostatného českého státu", Description = "https://cs.wikipedia.org/wiki/Den_obnovy_samostatn%C3%A9ho_%C4%8Desk%C3%A9ho_st%C3%A1tu" },
                this.easterCalculator.GetEasterDependedDay(year, -2, "Velký pátek", "https://cs.wikipedia.org/wiki/Velk%C3%BD_p%C3%A1tek"),
                this.easterCalculator.GetEasterDependedDay(year, +1, "Velikonoční pondělí", "https://cs.wikipedia.org/wiki/Velikono%C4%8Dn%C3%AD_pond%C4%9Bl%C3%AD"),
                new Holiday() { MonthNumber = 5, DayNumber = 1, YearNumber = year, Name = "Svátek práce", Description = "https://cs.wikipedia.org/wiki/Sv%C3%A1tek_pr%C3%A1ce" },
                new Holiday() { MonthNumber = 5, DayNumber = 8, YearNumber = year, Name = "Den vítězství", Description = "https://cs.wikipedia.org/wiki/Den_v%C3%ADt%C4%9Bzstv%C3%AD#5._kv%C4%9Bten" },
                new Holiday() { MonthNumber = 7, DayNumber = 5, YearNumber = year, Name = "Den slovanských věrozvěstů Cyrila a Metoděje", Description = "https://cs.wikipedia.org/wiki/Den_slovansk%C3%BDch_v%C4%9Brozv%C4%9Bst%C5%AF_Cyrila_a_Metod%C4%9Bje" },
                new Holiday() { MonthNumber = 7, DayNumber = 6, YearNumber = year, Name = "Den upálení mistra Jana Husa", Description = "https://cs.wikipedia.org/wiki/Den_up%C3%A1len%C3%AD_mistra_Jana_Husa" },
                new Holiday() { MonthNumber = 9, DayNumber = 28, YearNumber = year, Name = "Den české státnosti", Description = "https://cs.wikipedia.org/wiki/Den_%C4%8Desk%C3%A9_st%C3%A1tnosti" },
                new Holiday() { MonthNumber = 10, DayNumber = 28, YearNumber = year, Name = "Den vzniku samostatného československého státu", Description = "Den vzniku samostatného československého státu" },
                new Holiday() { MonthNumber = 11, DayNumber = 17, YearNumber = year, Name = "Den boje za svobodu a demokracii", Description = "" },
                new Holiday() { MonthNumber = 12, DayNumber = 24, YearNumber = year, Name = "Štědrý den", Description = "https://cs.wikipedia.org/wiki/%C5%A0t%C4%9Bdr%C3%BD_den" },
                new Holiday() { MonthNumber = 12, DayNumber = 25, YearNumber = year, Name = "1. svátek vánoční", Description = "https://cs.wikipedia.org/wiki/Slavnost_Narozen%C3%AD_P%C3%A1n%C4%9B" },
                new Holiday() { MonthNumber = 12, DayNumber = 26, YearNumber = year, Name = "2. svátek vánoční", Description = "https://cs.wikipedia.org/wiki/Sv%C3%A1tek_svat%C3%A9ho_%C5%A0t%C4%9Bp%C3%A1na" }
            };

        return holidays;
    }
}