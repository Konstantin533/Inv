namespace HomeSema
{
    internal class Program
    {
        static void Main(string[] args)
        { //Семафор
            //for (int i = 0; i < 6; i++)
            //{
            //    var driver = new CarSem(i);
            //}


            //Монитор
            //int x = 0;
            //object locker = new();
            
            //for (int i = 1; i < 6; i++)
            //{
            //    Thread myThread = new(Print);
            //    myThread.Name = $"Поток {i}";
            //    myThread.Start();
            //}

            //void Print()
            //{
            //    bool acquiredLock = false;
            //    try
            //    {
            //        Monitor.Enter(locker, ref acquiredLock);
            //        x = 1;
            //        for (int i = 1; i < 6; i++)
            //        {
            //            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            //            x++;
            //            Thread.Sleep(100);
            //        }
            //    }
            //    finally
            //    {
            //        if (acquiredLock) Monitor.Exit(locker);
            //    }
            //}

            //Мьютекс
            int x = 0;
            Mutex mutexObj = new();

            
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new(Print);
                myThread.Name = $"Поток {i}";
                myThread.Start();
            }

            void Print()
            {
                mutexObj.WaitOne();     
                x = 1;
                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    x++;
                    Thread.Sleep(100);
                }
                mutexObj.ReleaseMutex();    
            }
        }
    }
}