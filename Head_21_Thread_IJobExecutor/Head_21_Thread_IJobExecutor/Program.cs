
namespace Head_21_Thread_IJobExecutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job job = new();
            job.Amount = 50;
            job.Start(7);
            job.End();
        }
    }
}
