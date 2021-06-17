using System;

namespace Thread_IJobExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Job job = new Job();
            job.Amount = 50;
            job.Start(7);
            job.End();
        }
    }
}
