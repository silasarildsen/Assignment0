namespace Assignment0;
public class LeapYear
{
    public LeapYear(){
        
    }
    public bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            throw new Exception("Year must be over 1582");
        }
        return year % 4 == 0 && !(year % 100 == 0 && !(year % 400 == 0));
    }
}