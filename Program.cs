using System;
// Created by Naisarg Patel (301215678).
namespace Lab3_301215678
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUTS
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                             "Friday", "Saturday", "Sunday" };

            string[] weekdaysUsage = { "Off-peak", "Off-peak", "Off-peak", "Off-peak", "Off-peak", "Off-peak", "Off-peak",
                                       "Mid-peak", "Mid-peak", "Mid-peak", "Mid-peak", "On-peak", "On-peak", "On-peak", "On-peak", "On-peak",
                                       "On-peak", "Mid-peak", "Mid-peak", "Off-peak", "Off-peak", "Off-peak", "Off-peak", "Off-peak" };

            const string WEEKEND_USAGE = "Off-peak";

            int[] hours = { 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 24, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 };

            // PROCESSING and OUTPUT
            for (int day = 0; day < days.Length; day++)
            {
                if (day < 5)
                {
                    Console.WriteLine(days[day]);
                    Console.WriteLine("-------------------------");
                    for (int count = 0; count < 24; count++)
                    {
                        if (count < 12)
                        {
                            Console.WriteLine($"{hours[count],2} am: {weekdaysUsage[count],3}");
                        }
                        else if (hours[count] == 24)
                        {
                            Console.WriteLine($"{hours[count-12],2} pm: {weekdaysUsage[count],3}");
                        }
                        else
                        {
                            Console.WriteLine($"{hours[count-12],2} pm: {weekdaysUsage[count],3}");
                        }
                    }
                    Console.WriteLine("-------------------------");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(days[day]);
                    Console.WriteLine("-------------------------");
                    for (int count=0; count<24; count++)
                    {
                        if (count < 12)
                        {
                            Console.WriteLine($"{hours[count],2} am: {WEEKEND_USAGE,3}");
                        }
                        else if (hours[count] == 24)
                        {
                            Console.WriteLine($"{hours[count - 12],2} pm: {WEEKEND_USAGE,3}");
                        }
                        else
                        {
                            Console.WriteLine($"{hours[count - 12],2} pm: {WEEKEND_USAGE,3}");
                        }
                    }
                    Console.WriteLine("-------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}


