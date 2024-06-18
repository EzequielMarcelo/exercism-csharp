using System;
using System.Linq;

class BirdCount
{
    private int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this._birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() =>
        new int[] { 0, 2, 5, 3, 7, 8, 4 };   

    public int Today() =>
        _birdsPerDay.LastOrDefault();    

    public void IncrementTodaysCount()
    {
        _birdsPerDay[_birdsPerDay.Count() - 1]++;        
    }

    public bool HasDayWithoutBirds() =>
        _birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays) =>
        _birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays() => _birdsPerDay.Count(x => x >= 5);
}
