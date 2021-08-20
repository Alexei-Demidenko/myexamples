
namespace Head_21_Thread_IJobExecutor
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Job job = new();
            job.Start(6);
            job.Amount = 35;
            job.Add();
            job.Amount = 20;
            job.Add();
            job.Stop();
            job.End();
        }
    }
}
