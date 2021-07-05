using System;

namespace Head_13_Delegate
{
    public delegate void MathDelegate(double value1, double value2);

    internal class Program
    {
        static void Main(string[] args)
        {
            MathDelegate mathDelegate = Add;
            mathDelegate += Subtract;// MathDelegate указывает на два метода Add и Subtract
            Console.WriteLine("\nВызов делегата  mathDelegate:");
            mathDelegate(5, 2);// вызываются оба метода из mathDelegate
            mathDelegate -= Subtract; // удаляем метод Subtract из mathDelegate      
            MathDelegate mathDelegate2 = Subtract;
            MathDelegate mathDelegate3 = mathDelegate + mathDelegate2;// объединяем делегаты mathDelegate + mathDelegate2
            Console.WriteLine("\nВызов делегата  mathDelegate3 при помоши Invoke:");
            mathDelegate3.Invoke(7, 2);

            MathDelegate mathDelegateMulti = (x, y) =>
            {
                Console.WriteLine($"\nДелегат mathDelegateMulti: {x} * {y} = {x * y}");
            };
            mathDelegateMulti(7, 2);
            
            EventExample eventExample = new();// Инициализируем объект класса EventExample    
            eventExample.OnChange += () =>// подписываем вывод на событие OnChange 
            {
                // Устанавливаем красный цвет символов
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Произошло действие!Был вызован метод  Mothod.");
                // Сбрасываем настройки цвета
                Console.ResetColor();
            };
            eventExample.Mothod();// генерируем событие  
        }
        
        public static void Add(double value1, double value2)
        {
            Console.WriteLine($"Метода Add: {value1 + value2}");
        }
        public static void Subtract(double value1, double value2)
        {
            Console.WriteLine($"Метода Subtract: {value1 - value2}");
        }        
    }
}
