namespace CzechHolidays;
public class Holiday
{
    public string Name { get; set; } = string.Empty;
    public int YearNumber { get; set; } = 2000;
    public int MonthNumber { get; set; } = 1;
    public int DayNumber { get; set; } = 1;
    public string Description = string.Empty;
    public bool ShopsOpen { get; set; }

    public DateTime AsDateTime()
    {
        return new DateTime(this.YearNumber, this.MonthNumber, this.DayNumber);
    }

    public override string ToString()
    {
        return $"{this.AsDateTime().ToString("dd.MM.yyyy")} {this.Name} {this.Description}";
    }
}
