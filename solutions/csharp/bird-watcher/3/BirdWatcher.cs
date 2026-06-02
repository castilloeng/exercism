using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[]{0,2,5,3,7,8,4};
    
    public int Today()
    {
        //return birdsPerDay[birdsPerDay.Length-1];
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        //birdsPerDay[6]+=1;
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        if (birdsPerDay.Contains(0)){
         return true;   
        }
            
        
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for(int index=0; index<numberOfDays; index++)
        {
            count+= birdsPerDay[index];
        }

        return count;
    }

    public int BusyDays()
    {

        return birdsPerDay.Count(n => n >= 5);

        
    }
}
