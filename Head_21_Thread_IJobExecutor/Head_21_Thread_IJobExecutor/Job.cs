using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Head_21_Thread_IJobExecutor
{
    internal class Job : IJobExecutor
    {
        // Блокирующая очередь.
        private static readonly BlockingCollection<int> queue = new();
        // Кол-во задач в очереди на обработку
        public int Amount { get; set; }
        // Запускаем обработку очереди
        public void Start(int maxConcurrent)
        {
            Task[] threads = new Task[maxConcurrent];
            for (int i = 0; i < threads.Length; i++)
            {
                int num = i + 1;
                threads[i] = Task.Factory.StartNew(() => ProcessQueue($"Поток {num}"));
            }
            Add();
            Stop();
            // Ждем окончания работы всех потоков
            Task.WaitAll(threads);
        }
        // Создаем очередь
        public void Add()
        {
            for (int i = 0; i < Amount; i++)
            {
                queue.Add(i);
            }
        }
        //в очереди больше никогда не будет добавлено никаких данных
        public void Stop()
        {
            queue.CompleteAdding();
        }

        // Удаляет и возвращает первый элемент в очереди
        private static int Dequeue()
        {
            return queue.Take();
        }

        // Достает элементы из очереди и обрабатывает их
        private static void ProcessQueue(object taskName)
        {
            while (true)
            {
                try
                {
                    // Достаем следующий элемент из очереди. Если элементов ноль и свойство очереди IsCompleted = false, поток будет заблокирован пока элементы не появятся.
                    int item = Dequeue();
                    // Выводим на экран
                    Console.WriteLine($"{taskName}: процесс {item}.");
                    Thread.Sleep(1000);
                }
                catch (InvalidOperationException)
                {
                    // Обеспечиваем выход из бесконечного цикла при завершении работы приложения
                    Console.WriteLine($"{taskName} закончил работу.");
                    return;
                }
            }
        }
        public void End()
        {
            Console.WriteLine("Все потоки завершили выполнение.");
        }
    }
}
