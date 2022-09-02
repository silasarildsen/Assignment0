namespace Assignment0;
public class LeapYear
{
    public LeapYear(){
        
    }
    public bool IsLeapYear(int year)
    {
        if (year % 4 == 0 && !(year % 100 == 0 && !(year % 400 == 0))) return true;
        else return false;
    }
}