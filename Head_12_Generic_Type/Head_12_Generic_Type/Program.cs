using System;

namespace Head_12_Generic_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем список помещений
            var RoomName = new ClassExample<string>();

            //заполняем значениями
            RoomName.AddValue("Коридор");
            RoomName.AddValue("Кабинет");
            RoomName.AddValue("Кухня");

            ////Создаем список площадь помещений
            var RoomArea = new ClassExample<int>();
            RoomArea.AddValue(20);
            RoomArea.AddValue(35);
            RoomArea.AddValue(15);

            Console.WriteLine("Название помещений (список RoomName, тип string):");
            foreach (var item in RoomName.GetListValue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nПлощать помещений (список RoomArea, тип int):");
            foreach (var item in RoomArea.GetListValue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
