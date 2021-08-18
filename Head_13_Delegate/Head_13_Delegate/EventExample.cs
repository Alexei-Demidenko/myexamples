using System;

namespace Head_13_Delegate
{
    internal class EventExample
    {
        //Свойство OnChange содержит список всех callback-методов подписчиков 
        public event Action OnChange = delegate { };

        public void Mothod()
        {
            Console.WriteLine("\nВызов метода  Mothod из класса EventExample");
            //Вызов OnChange
            OnChange();
        }
    }
}
