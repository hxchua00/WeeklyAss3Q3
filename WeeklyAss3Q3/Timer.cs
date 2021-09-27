using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeeklyAss3Q3
{
    class Timer
    {
        private int count = 0;
        bool IsCounterRunning = false;

        public void StartCount()
        {
            IsCounterRunning = true;
            count = 0;
            while (IsCounterRunning)
            {
                Thread.Sleep(5000);
                count++;
                Console.WriteLine("Count added.");
                Console.WriteLine();
                Console.WriteLine("Stop count? y / n ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        StopCount();
                        break;
                    default:
                        break;

                }

            }
            
        }
        public void StopCount()
        {
            if(IsCounterRunning == true)
            {
                IsCounterRunning = false;
            }
            else
            {
                return;
            }
            Console.WriteLine("Count: " + count);
        }
    }
}
