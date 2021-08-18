using System;

namespace Head_12_Generic_Type
{
    internal class Program
    {
        internal static void Main()
        {
            Room room = new() { RoomName = "Номер 101", RoomArea = 95, Free = true };
            Room room2 = new() { RoomName = "Номер 222", RoomArea = 35, Free = false };
            Room room3 = new() { RoomName = "Номер 333", RoomArea = 40, Free = true };
            Room room4 = new() { RoomName = "Номер 404", RoomArea = 75, Free = false };
            ClassExample<Room> classExample = new();
            try
            {
                classExample.Add(room);
                classExample.Add(room2);
                classExample.Add(room3);
                classExample.Add(room4);
                classExample.Add(room4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"\n\tСодержимое RommCollection:");
            foreach (var valueRoom in classExample.RommCollection)
            {
                ClassExample<Room>.Print(valueRoom);
            }
            Console.WriteLine($"\n\tСодержимое RommCollection после сортировке по полю RoomArea:");
            classExample.RommCollection.Sort(classExample);
            foreach (var valueRoom in classExample.RommCollection)
            {
                ClassExample<Room>.Print(valueRoom);
            }
        }
    }
}
