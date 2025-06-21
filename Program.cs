

using System;
using System.Diagnostics.CodeAnalysis;

//date and time
class Program
{
    static void Main(string[] args)
    {
        //current date and time
        DateTime X = DateTime.Now;
        Console.WriteLine("Today's date and time is: " + X);

        //Only date
        Console.WriteLine(" Displaying Only date: " + X.ToShortDateString());

        //Only time
        Console.WriteLine(" Display only time: " + X.ToShortTimeString());

        //add 5 days
        DateTime futureDate = X.AddDays(5);
        Console.WriteLine(" adding 5 more days:" + futureDate.ToShortDateString());

        //subtract -2 months
        DateTime subtract = X.AddMonths(-2);
        Console.WriteLine(" Deduct 2 months from today's date: " + subtract.ToShortDateString());
        

    }
}
