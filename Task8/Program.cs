using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfGrannys;
            int waitingTime = 10;
            int hours=0;
            int minutes=0;
            int minutesInHour = 60;

            Console.WriteLine("Введите количество старушек");
            countOfGrannys = Int32.Parse(Console.ReadLine());
            if(countOfGrannys > 0)
            {
                hours = (countOfGrannys * waitingTime) / minutesInHour;
                minutes = (countOfGrannys * waitingTime) % minutesInHour;
            }
            Console.WriteLine("Вам нужно ждать "+hours+" часов 10"+minutes + " минут");
        }
    }
}
