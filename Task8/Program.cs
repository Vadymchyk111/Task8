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
            int waitingTimeOfPerson = 10;
            int waitingHours=0;
            int waitingMinutes = 0;
            int minutesInHour = 60;

            Console.WriteLine("Введите количество старушек");
            countOfGrannys = Int32.Parse(Console.ReadLine());
            if(countOfGrannys > 0)
            {
                waitingHours = (countOfGrannys * waitingTimeOfPerson) / minutesInHour;
                waitingMinutes = (countOfGrannys * waitingTimeOfPerson) % minutesInHour;
            }
            Console.WriteLine("Вам нужно ждать "+ waitingHours + " часов 10"+ waitingMinutes + " минут");
        }
    }
}
