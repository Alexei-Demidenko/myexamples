using System;
using System.Text.RegularExpressions;

namespace Head_20_RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Александр, Андрей, Алексей";
            Regex myReg = new("Алекс"); // создание регулярного выражения
            Regex myReg2 = new(@"^[A-с]\w*");

            Console.WriteLine($"Строка data = {data}");
            Console.WriteLine($"Регулярноен выражения:\nmyReg = {myReg}\nmyReg2 ={myReg2}");
            Console.WriteLine($"\nПроверяем содержит ли строка data регулярного выражения myReg: {myReg.IsMatch(data)}");
            Console.WriteLine($"\nПроверяем содержит ли строка data регулярного выражения myReg2: {myReg2.IsMatch(data)}");
            Console.WriteLine($"\nКоличество вхождений myReg в data: {myReg.Matches(data).Count}");
            Console.WriteLine($"\nЗаменяем в data вхождений myReg на ALEX: {myReg.Replace(data, "ALEX")}");

            Console.ReadKey();
        }
    }
}
