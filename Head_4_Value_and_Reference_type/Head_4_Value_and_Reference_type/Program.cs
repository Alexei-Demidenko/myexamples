using System;

namespace Head_4_Value_and_Reference_type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Типы значений и их капирование");
            Value_type value1 = new() { X = 1 };
            Value_type value2 = value1; //Копирование Value type
            Print_Value_type(value1, value2);
            value2.X = 2;//Присваеваем новое значение для value2.X
            Console.WriteLine($"Присвоили value2.X = 2");
            Print_Value_type(value1, value2);

            static void Print_Value_type(Value_type val1, Value_type val2)
            {
                Console.WriteLine($"value1.X={val1.X}\nvalue2.X ={ val2.X}");
            }

            Console.WriteLine("\nСсылочные типы и их капирование");
            Reference_type reference1 = new() { Y = 2, Z = 3 };
            Reference_type reference2 = reference1;//Копирование Reference type
            Print_Reference_type(reference1, reference1);
            reference2.Y = 9;
            Console.WriteLine($"Присвоили reference2.Y = 9");
            Print_Reference_type(reference1, reference1);
            static void Print_Reference_type(Reference_type val1, Reference_type val2)
            {
                Console.WriteLine($"reference1: Y={val1.Y}  Z={val1.Z}");
                Console.WriteLine($"reference2: Y={val2.Y}  Z={val2.Z}");
            }

            Console.WriteLine("\nСоставные типы");
            Value_type_and_Reference_type val_ref_type = new();
            val_ref_type.X = 1;
            val_ref_type.reference_type = reference1;
            Print_val_ref_type(val_ref_type);
            Console.WriteLine($"Присвоили reference2.Y = 123");
            reference2.Y = 123;
            Print_val_ref_type(val_ref_type);
            static void Print_val_ref_type(Value_type_and_Reference_type val)
            {
                Console.WriteLine($"val_ref_type:\nval_ref_type.X={val.X}\nval_ref_type.reference_type.Y={val.reference_type.Y}" +
                 $"\nval_ref_type.reference_type.Z={val.reference_type.Z}");
            }

            //Модификатор ref
            Console.WriteLine("\nМодификатор ref");
            Console.WriteLine($"Начальное значение переменной value1.X  = {value1.X}");
            Increment(value1);
            Console.WriteLine($"Значение переменной value1.X после метода Increment = {value1.X}");
            IncrementRef(ref value1);
            Console.WriteLine($"Значение переменной value1.X после метода IncrementRef = {value1.X}");

            static void Increment(Value_type value1) //Передаем переменнюу по значению
            {
                value1.X++;
                Console.WriteLine($"Значение переменной value1.X в метода Increment = {value1.X}");
            }
            static void IncrementRef(ref Value_type value1) //Передаем переменнюу по ссылке
            {
                value1.X++;
                Console.WriteLine($"Значение переменной value1.X в метода IncrementRef = {value1.X}");
            }

            //Модификатор in, out
            Console.WriteLine("\nМодификатор in, out");
            Console.WriteLine($"Начальное значение переменной value1.X  = {value1.X}");
            Sum(in reference1, in reference2, out value1);
            Console.WriteLine($"Значение переменной value1.X после метода Sum = {value1.X}");

            static void Sum(in Reference_type reference1, in Reference_type reference2, out Value_type value1)
            {
                value1.X = reference1.Y + reference1.Z + reference2.Y + reference2.Z;
            }

        }
    }
}

