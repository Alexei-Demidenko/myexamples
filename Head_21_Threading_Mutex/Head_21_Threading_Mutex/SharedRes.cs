using System.Threading;

namespace Head_21_Threading_Mutex
{
    public class SharedRes
    {
        // общий ресурс(переменная Count), а также мьютекс (Mtx), управляющий доступом к ней.
        public static int Count = 0;
        public static Mutex Mtx = new();
    }
}
