using System;

namespace Head_4_Value_and_Reference_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Типы значений и их копирование");
            ValueType value1 = new() { X = 1 };
            ValueType value2 = value1; //Копирование Value type
            PrintValueType(value1, value2);
            value2.X = 2;//Присваеваем новое значение для value2.X
            Console.WriteLine($"Присвоили value2.X = 2");
            PrintValueType(value1, value2);

            static void PrintValueType(ValueType val1, ValueType val2)
            {
                Console.WriteLine($"value1.X={ val1.X }\nvalue2.X ={ val2.X }");
            }

            Console.WriteLine("\nСсылочные типы и их копирование");
            ReferenceType reference1 = new() { Y = 2, Z = 3 };
            ReferenceType reference2 = reference1;//Копирование Reference type
            PrintReferenceType(reference1, reference1);
            reference2.Y = 9;
            Console.WriteLine($"Присвоили reference2.Y = 9");
            PrintReferenceType(reference1, reference1);
            static void PrintReferenceType(ReferenceType val1, ReferenceType val2)
            {
                Console.WriteLine($"reference1: Y={val1.Y}  Z={val1.Z}");
                Console.WriteLine($"reference2: Y={val2.Y}  Z={val2.Z}");
            }

            Console.WriteLine("\nСоставные типы");
            ValueTypeAndReferenceType val_ref_type = new();
            val_ref_type.X = 1;
            val_ref_type.reference_type = reference1;
            PrintValRefType(val_ref_type);
            Console.WriteLine($"Присвоили reference2.Y = 123");
            reference2.Y = 123;
            PrintValRefType(val_ref_type);
            static void PrintValRefType(ValueTypeAndReferenceType val)
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

            static void Increment(ValueType value1) //Передаем переменнюу по значению
            {
                value1.X++;
                Console.WriteLine($"Значение переменной value1.X в метода Increment = {value1.X}");
            }
            static void IncrementRef(ref ValueType value1) //Передаем переменнюу по ссылке
            {
                value1.X++;
                Console.WriteLine($"Значение переменной value1.X в метода IncrementRef = {value1.X}");
            }

            //Модификатор in, out
            Console.WriteLine("\nМодификатор in, out");
            Console.WriteLine($"Начальное значение переменной value1.X  = {value1.X}");
            Sum(in reference1, in reference2, out value1);
            Console.WriteLine($"Значение переменной value1.X после метода Sum = {value1.X}");

            static void Sum(in ReferenceType reference1, in ReferenceType reference2, out ValueType value1)
            {
                value1.X = reference1.Y + reference1.Z + reference2.Y + reference2.Z;
            }

        }
    }
}

