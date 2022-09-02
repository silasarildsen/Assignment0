// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace Assignment0;
class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter year: ");
        string input = Console.ReadLine();
        int year;
        bool isParsable = Int32.TryParse(input, out year);
        var ly = new LeapYear();
        string output;

        if (isParsable)
        {
            try
            {
                output = ly.IsLeapYear(year) ? "yay" : "nay";   
            }
            catch (System.Exception e)
            {
                output = e.Message;
            }
            Console.WriteLine(output);   
        }else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}