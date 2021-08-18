using System;
using System.Collections.Generic;

namespace Head_12_Generic_Type
{
    internal class ClassExample<T>: IComparer<T> where T : Room
    {
        public List<T> RommCollection { get; } = new();
        public void Add(T valueRoom)
        {
            if (!string.IsNullOrEmpty(valueRoom.RoomName))
            {
                if (RommCollection.Contains(valueRoom))
                {
                    throw new Exception($"Комната:-{valueRoom.RoomName}- уже содержится в списке.");
                }
                else
                {
                    RommCollection.Add(valueRoom);
                    Console.WriteLine($"Комната:-{valueRoom.RoomName}- добавлена в списке.");
                }
            }
        }
        internal static void Print(T valueRoom)
        {
            if (valueRoom.Free)
            {
                Console.WriteLine($"Комната: -{valueRoom.RoomName}-, с плозщадью {valueRoom.RoomArea} кв. м. - свободна");
            }
            else
            {
                Console.WriteLine($"Комната: -{valueRoom.RoomName}-, с плозщадью {valueRoom.RoomArea} кв. м. - занята");
            }
        }
        public int Compare(T valueRoom1, T valueRoom2)
        {
            if (valueRoom2 != null && valueRoom1 != null && valueRoom1.RoomArea > valueRoom2.RoomArea)
            {
                return 1;
            }
            else if (valueRoom2 != null && valueRoom1 != null && valueRoom1.RoomArea < valueRoom2.RoomArea)
            {
                return -1;
            }
            return 0;
        }
    }
}
