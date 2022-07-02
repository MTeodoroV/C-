using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

class Program
{
    class DateAndTime
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 7, 2);
            // Console.WriteLine("Date: " + date); // Date: 02/07/2022 00:00:00
            // Console.WriteLine("Date: " + date.ToString("d")); // Date: 02/07/2022
            // Console.WriteLine("Date: " + date.ToString("d", new CultureInfo("pt-BR"))); // Date: 02/07/2022
            // Console.WriteLine("Date: " + date.ToString("dd/MM/yyyy")); // Date: 02/07/2022
        
            DateTime time = new DateTime(2022, 7, 2, 13, 14, 15, 987);
            // Console.WriteLine("Time: " + time); // Time: 02/07/2022 13:14:15
            // Console.WriteLine("Time: " + time.ToString("HH:mm:ss.fff")); // Time: 13:14:15.987

            // Console.WriteLine("Time: " + time.ToString("D")); // sábado, 2 de julho de 2022
            // Console.WriteLine("Time: " + time.ToString("m")); // 2 de julho
            // Console.WriteLine("Time: " + time.ToString("Y")); // julho de 2022
            // Console.WriteLine("Time: " + time.ToString("G")); // 02/07/2022 13:14:15
            // Console.WriteLine("Time: " + time.ToString("g")); // 02/07/2022 13:14
            //Console.WriteLine("Time: " + time.ToString("t")); // 13:14
            Console.WriteLine("Time: " + time.ToString("T")); // 13:14:15

            //RoadTrip
            // Console.WriteLine("Time: " + time.ToString("O")); // 2022-07-02T13:14:15.9870000
            // Console.WriteLine("Time: " + DateTime.Parse(time.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff")); // 02/07/2022 13:14:15.987

        }
    }
}