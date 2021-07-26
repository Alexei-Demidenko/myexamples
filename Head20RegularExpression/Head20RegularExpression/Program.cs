using System;
using System.Text.RegularExpressions;

namespace Head20RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ValueString = "Выделить числа из текста (1, 1000, 1 000 000, 100.23)";
            Console.WriteLine(ValueString);
            // Regex RegValue = new(@"\d(?=,)|\d{4}|\d{1}\s\d{3}\s\d{3}|\d{3}[.]{1}\d{2}"); //более обобщенное
            Regex RegValue = new(@"[1](?=,)|[1]{1}[0]{3}|[1]{1}\s[0]{3}\s[0]{3}|[1]{1}[0]{2}[.]{1}[2]{1}[3]{1}");
            MatchCollection valueCollection = RegValue.Matches(ValueString);
            foreach (object item in valueCollection)
            {
                Console.WriteLine($"{item}");
            }

            ValueString = "Выделить параметры из строки запроса (http://ya.ru/api?r=1&x=23)";
            Console.WriteLine($"\n{ValueString}");
            RegValue = new(@".(?==)|(?<==)\d*");
            valueCollection = RegValue.Matches(ValueString);
            for (int i = 0; i < valueCollection.Count - 1; i++)
            {
                Console.WriteLine($"{valueCollection[i]}={valueCollection[i + 1]}");
                i++;
            }

            ValueString = "Удалить  из выражения   повторяющиеся пробелы,  между токенами д.  б. 1  пробел.";
            Console.WriteLine($"\n{ValueString}");
            ValueString = Regex.Replace(ValueString, @"\s+", " ");
            Console.WriteLine(ValueString);

            Console.WriteLine("\n\tПроверяем что вводимое число - корректный номер телефона:");
            string[] ValueString2 = { "+373 77767852", "77767852", "0(775) 67852", "97767852" };
            RegValue = new(@"[+373 ]{1}[7]{2}\d{6}|[7]{2}\d{6}|[0(77]{1}\d{1}[)]{1}[ ]{1}\d{5}");
            for (int i = 0; i < ValueString2.Length; i++)
            {
                Console.WriteLine($"{ValueString2[i]} - корректный номер телефона:{RegValue.IsMatch(ValueString2[i])}");
            }
        }
    }
}
