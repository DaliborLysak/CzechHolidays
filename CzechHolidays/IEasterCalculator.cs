namespace CzechHolidays;
public interface IEasterCalculator
{
    Holiday GetEasterDependedDay(int year, int dayShift, string name, string description);
}