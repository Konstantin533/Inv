using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSema
{
    public class CarSem // Семафор
    {
        static Semaphore sem = new Semaphore(2, 2);
        int count = 3;
        public CarSem(int i) 
        {
            var carThread = new Thread(Parking);
            carThread.Name = $"Водитель {i}";
            carThread.Start();
        }

        public void Parking()
        {
            while(count>0)
            {
                sem.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} заезжает на парковку");
                Console.WriteLine($"{Thread.CurrentThread.Name} паркуется");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} выезжает с парковки");
                sem.Release();
                count--;
                Thread.Sleep(1000);
            }
        }
    }
}
