using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Head_21_Thread_IJobExecutor
{
    internal class Job : IJobExecutor
    {
        // Блокирующая очередь.
        private static readonly BlockingCollection<int> Queue = new();
        // Кол-во задач в очереди на обработку
        public int Amount { get; set; }
        public Task[] Threads = new Task[1];
        // Запускаем обработку очереди
        public void Start(int maxConcurrent)
        {
            Threads = new Task[maxConcurrent];
            for (var i = 0; i < Threads.Length; i++)
            {
                var num = i + 1;
                Threads[i] = Task.Factory.StartNew(() => ProcessQueue($"Поток {num}"));
            }
        }
        // Создаем очередь
        public void Add()
        {
            for (var i = 0; i < Amount; i++)
            {
                Queue.Add(i);
            }
        }
        //в очереди больше никогда не будет добавлено никаких данных
        public void Stop()
        {
            Queue.CompleteAdding();
        }
        // Удаляет и возвращает первый элемент в очереди
        private static int Dequeue()
        {
            return Queue.Take();
        }
        // Достает элементы из очереди и обрабатывает их
        private static void ProcessQueue(object taskName)
        {
            while (true)
            {
                try
                {
                    // Достаем следующий элемент из очереди. Если элементов ноль и свойство очереди IsCompleted = false, поток будет заблокирован пока элементы не появятся.
                    var item = Dequeue();
                    // Выводим на экран
                    Console.WriteLine($"{taskName}: процесс {item}.");
                    Thread.Sleep(750);
                }
                catch (InvalidOperationException)
                {
                    // Обеспечиваем выход из бесконечного цикла при завершении работы приложения
                    Console.WriteLine($"{taskName} закончил работу.");
                    return;
                }
            }
        }
        // Ждем окончания работы всех потоков
        public void End()
        {
            Task.WaitAll(Threads);
            Console.WriteLine("Все потоки завершили выполнение.");
        }
    }
}
