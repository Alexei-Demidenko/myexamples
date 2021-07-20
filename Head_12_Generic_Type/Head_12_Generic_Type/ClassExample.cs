using System;
using System.Collections.Generic;

namespace Head_12_Generic_Type
{
    internal class ClassExample<T>: IComparer<T> where T : Room
    {
        public List<T> RommCollection { get; } = new() { };
        public void Add(T ValueRoom)
        {
            if (!string.IsNullOrEmpty(ValueRoom.RoomName))
            {
                RommCollection.Add(ValueRoom);
                Console.WriteLine($"Комната:-{ValueRoom.RoomName}- добавлена в списке.");
            }
        }
        internal static void Print(T ValueRoom)
        {
            if (ValueRoom.Free)
            {
                Console.WriteLine($"Комната: -{ValueRoom.RoomName}-, с плозщадью {ValueRoom.RoomArea} кв. м. - свободна");
            }
            else
            {
                Console.WriteLine($"Комната: -{ValueRoom.RoomName}-, с плозщадью {ValueRoom.RoomArea} кв. м. - занята");
            }
        }
        public int Compare(T ValueRoom1, T ValueRoom2)
        {
            if (ValueRoom1.RoomArea > ValueRoom2.RoomArea)
            {
                return 1;
            }
            else if (ValueRoom1.RoomArea < ValueRoom2.RoomArea)
            {
                return -1;
            }
            return 0;
        }
    }
}
