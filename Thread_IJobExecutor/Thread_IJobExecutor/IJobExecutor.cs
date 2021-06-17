using System;
using System.Collections.Generic;
using System.Text;

namespace Thread_IJobExecutor
{
    interface IJobExecutor
    {
        /// Кол-во задач в очереди на обработку
        int Amount { get; }

        /// <summary>
        /// Запустить обработку очереди и установить максимальное кол-во   параллельных задач
        /// </summary>
        /// <param_name="maxConcurrent">максимальное кол-во одновременн        выполняемых задач</param>
        void Start(int maxConcurrent);

        /// <summary>
        /// Остановить обработку очереди и выполнять задачи
        /// </summary>
        void Stop();

        /// <summary>
        /// Добавить задачу в очередь
        /// </summary>
        /// <param_name="action"></param>
        void Add();

        // Конец программы
        void End();
    }
}
