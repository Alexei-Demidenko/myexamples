using System;
using System.Reflection;

namespace Head_18_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly asm = Assembly.LoadFrom("Head_8_IQueryable.dll");
                Console.WriteLine(asm.FullName);

                Type myType = asm.GetType("Head_8_IQueryable.RandomDateTime", false, true);

                Console.WriteLine("\nПоля:");
                foreach (FieldInfo field in myType.GetFields())
                {
                    Console.WriteLine($"{field.FieldType} {field.Name}");
                }

                Console.WriteLine("\nСвойства:");
                foreach (PropertyInfo prop in myType.GetProperties())
                {
                    Console.WriteLine($"{prop.PropertyType} {prop.Name}");
                }

                Console.WriteLine("\nМетоды:");
                foreach (MethodInfo method in myType.GetMethods())
                {
                    string modificator = "";
                    if (method.IsStatic)
                    {
                        modificator += "static ";
                    }

                    if (method.IsVirtual)
                    {
                        modificator += "virtual";
                    }

                    Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
                    //получаем все параметры
                    ParameterInfo[] parameters = method.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                        if (i + 1 < parameters.Length)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine(")");
                }

                Console.WriteLine("\nКонструкторы:");
                foreach (ConstructorInfo ctor in myType.GetConstructors())
                {
                    Console.Write(myType.Name + " (");
                    // получаем параметры конструктора
                    ParameterInfo[] parameters = ctor.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                        if (i + 1 < parameters.Length)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine(")");
                }

                object obj = Activator.CreateInstance(myType);

                Console.WriteLine($"\nВызов метода Next из класса RandomDateTime: {myType.GetMethod("Next").Invoke(obj, Array.Empty<object>())}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
