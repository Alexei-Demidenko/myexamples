using System;
using System.Linq;

namespace Head_8_IQueryable
{
    class Program
    {
        public struct People
        {
            public string name;
            public int age;
            public DateTime Date_of_birth;
            public bool alive;
        }
        private static void Main(string[] args)
        {
            People[] arraypeople = new People[100];

            Random rnd = new Random();
            RandomDateTime date = new RandomDateTime();
            for (int i = 0; i < 100; i++)
            {
                arraypeople[i].name = Guid.NewGuid().ToString("n").Substring(0, 10);
                arraypeople[i].age = rnd.Next(1, 99);
                arraypeople[i].Date_of_birth = date.Next();
                if (rnd.Next(1, 99) > 40)
                    arraypeople[i].alive = true;
                else
                    arraypeople[i].alive = false;
                Console.WriteLine($"Имя={arraypeople[i].name}--Возрост={arraypeople[i].age}--Дата рождения={arraypeople[i].Date_of_birth.ToString("d")}--Живой={arraypeople[i].alive}");
            }
            Console.WriteLine("\nВыборка живые, сортировка по возростанию по возрастанию:");
            WithWhere(arraypeople);
            Console.WriteLine("\nВыборка по возросту >90, по убыванию:");
            WithOrderByDescending(arraypeople);
            WithAny(arraypeople);
            WithSumMaxMin(arraypeople);
        }
        public static void Print(IOrderedEnumerable<People> arraypeople)
        {
            foreach (People item in arraypeople)
            {
                Console.WriteLine($"Имя = {item.name}--Возрост={item.age}--Дата рождения={item.Date_of_birth:d}--Живой={item.alive}");
            }
            Console.WriteLine();
        }

        //выборка живые, по возрастанию        
        public static void WithWhere(People[] people)
        {
            IOrderedEnumerable<People> arraypeople = people.Where(e => e.alive).OrderBy(e => e.age);
            Print(arraypeople);
        }

        //выборка по возросту, по убыванию
        public static void WithOrderByDescending(People[] people)
        {
            IOrderedEnumerable<People> arraypeople = people.Where(e => e.age > 90)
                .OrderByDescending(e => e.age);
            Print(arraypeople);
        }

        //превышает ли возраст 20 и имя начинается с буквы "е" 
        public static void WithAny(People[] Arraypeople)
        {
            if (Arraypeople.Any(u => u.age < 20))
                Console.WriteLine("Есть пользователи с возрастом меньше 20");
            else
                Console.WriteLine("У всех пользователей возраст больше 20");

            if (Arraypeople.Any(u => u.name.StartsWith("e")))
                Console.WriteLine("Есть пользователи, у которых имя начинается с - E");
            else
                Console.WriteLine("Отсутствуют пользователи, у которых имя начинается с - E");
            Console.WriteLine();

        }

        //sum, min, max по возросту
        public static void WithSumMaxMin(People[] Arraypeople)
        {
            Console.WriteLine($"Сумма по столб. age всех живых = {Arraypeople.Where(e => e.alive).Sum(u => u.age)}");
            Console.WriteLine($"Мин. возрост  = {Arraypeople.Min(u => u.age)}");
            Console.WriteLine($"Последний родился в = {Arraypeople.Max(u => u.Date_of_birth)}");
        }
    }
}
