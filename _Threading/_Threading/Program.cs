using System;
using System.Threading;

namespace _Threading
{
    class Program
    {
        static object locker = new object();
        public static int number = 4;
        static void Main(string[] args)
        {
            // получаем текущий поток
            Thread t = Thread.CurrentThread;
            t.Name = "Метод Main";
            ThreadInfo(t);

            //новые потоки 
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Lowest;
            Thread thread3 = new Thread(new ParameterizedThreadStart(mythread3));

            thread1.Start();
            thread2.Start();
            thread3.Start(number);
            Console.ReadLine();
        }
        static void mythread1()
        {
            lock (locker)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Поток 1 выводит " + i);
                    Thread.Sleep(100);
                }
            }
        }

        static void mythread2()
        {
            lock (locker)
            {
                for (int i = 10; i < 20; i++)
                {
                    Console.WriteLine("Поток 2 выводит " + i);number++;
                    Thread.Sleep(100);
                }
            }
            
        }

        static void mythread3(object x)
        {
            lock (locker)
            {
                for (int i = 0; i < 10; i++)
                {
                    number++;
                    Console.WriteLine($"Поток 3 выводит: {number}+{(int)x}={number + (int)x}");                    
                    Thread.Sleep(100);
                }
            }
        }
        static void ThreadInfo(Thread t)
        {                       
            Console.WriteLine($"Имя потока: {t.Name}");
            Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
            Console.WriteLine($"Приоритет потока: {t.Priority}");
            Console.WriteLine($"Статус потока: {t.ThreadState}");

            // получаем домен приложения
            Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}\n");

        }
    }
}
