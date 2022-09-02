// See https://aka.ms/new-console-template for more information
namespace Assignment0;
class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter year: ");    
        int year = int.Parse(Console.ReadLine());
        var ly = new LeapYear();
        string output = ly.IsLeapYear(year) ? "yay" : "nay";
        Console.WriteLine(output);
    }
}