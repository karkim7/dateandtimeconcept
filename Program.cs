

using System;

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

    }
}
