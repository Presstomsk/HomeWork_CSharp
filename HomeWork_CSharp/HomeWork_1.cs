

using System;

namespace HomeWork_CSharp
{
    class HomeWork_1
    {
        static void Main()
        {
            // ДЗ1.Написать программу, которая считывает символы с клавиатуры,
            //пока не будет введена точка.
            //Программа должна сосчитать количество введенных пользователем пробелов.
            
            Console.WriteLine("------HomeWork_1------");
            Console.WriteLine();
            Console.Write("Введите символы с клавиатуры: ");
            char symbol;
            int counter = 0;
            do
            {
                symbol = Console.ReadKey().KeyChar;
                if (symbol == ' ')
                    counter++;
            }
            while (symbol != '.');
            Console.WriteLine();
            Console.WriteLine($"Число пробелов: {counter}");
            Console.WriteLine();

            // ДЗ 2.Числовые значения символов нижнего регистра в коде ASCII
            // отличаются от значений символов верхнего регистра на величину 32.
            // Используя эту информацию, написать программу,
            // которая считывает с клавиатуры и конвертирует все символы
            // нижнего регистра в символы верхнего регистра и наоборот.

            Console.WriteLine("------HomeWork_2------");
            Console.WriteLine();
            Console.Write("Введите строку с клавиатуры: ");
            int size=50;
            char[] arr=new char[size];
            counter = 0;
            do
            {
                arr[counter] = Console.ReadKey().KeyChar;
                counter++;
               
            }
            while ((counter!=arr.Length)&&(arr[counter - 1] != 13));
            Console.WriteLine();
            for (int i = 0; i < counter-1; i++)
            {               
                
                if ((arr[i] >= 97) && (arr[i] <= 122))
                    arr[i] =(char)((int)arr[i]-32);
                else if ((arr[i] >= 65) && (arr[i] <= 90))
                    arr[i] = (char)((int)arr[i] + 32);
            }
            Console.Write("Результат конвертирования: ");
            for (int i = 0; i < counter - 1; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
