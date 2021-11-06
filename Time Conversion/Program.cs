/*
Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock. Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.

Complete the timeConversion function which takes 1 argument, a string s and returns a string denoting the 24-hr formatted time.

Sample Input 0

07:05:45PM
Sample Output 0

19:05:45
*/

using System;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();

            string result = timeConversion("12:45:54PM");

            Console.WriteLine(result);
        }

        static string timeConversion(string s)
        {
            string[] temp = s.Split(':');
            int hr = Convert.ToInt32(temp[0]);
            string min = temp[1];
            string sec = temp[2].Substring(0, 2);
            string format = temp[2].Substring(2, 2);


            if (format == "PM")
                hr += 12;
            else
            {
                if (hr == 12)
                    hr = 0;
            }

            hr = hr == 24 ? 12 : hr;

            return hr.ToString("D2") + ":" + min + ":" + sec;
        }
    }
}
