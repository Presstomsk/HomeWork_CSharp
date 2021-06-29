

using System;
using System.Linq;

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
            int size = 50;
            char[] arr = new char[size];
            counter = 0;
            do
            {
                arr[counter] = Console.ReadKey().KeyChar;
                counter++;

            }
            while ((counter != arr.Length) && (arr[counter - 1] != 13));
            Console.WriteLine();
            for (int i = 0; i < counter - 1; i++)
            {

                if ((arr[i] >= 97) && (arr[i] <= 122))
                    arr[i] = (char)((int)arr[i] - 32);
                else if ((arr[i] >= 65) && (arr[i] <= 90))
                    arr[i] = (char)((int)arr[i] + 32);
            }
            Console.Write("Результат конвертирования: ");
            for (int i = 0; i < counter - 1; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
            //ДЗ 3.Даны целые положительные числа A и B(A<B).
            //Вывести все целые числа от A до B включительно;
            //каждое число должно выводиться на новой строке;
            //при этом каждое число должно выводиться количество раз,
            //равное его значению. Например: если А = 3, а В = 7,
            //то программа должна сформировать в консоли следующий вывод:
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7

            Console.WriteLine("------HomeWork_3------");
            Console.WriteLine();
            int A, B, C;
            Console.Write("Введите значение числа A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение числа B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                C = A;
                A = B;
                B = C;
            }
            for (; A <= B; A++)
            {
                for (int i = 0; i < A; i++)
                {
                    Console.Write($"{A}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //ДЗ 4.Даны 2 массива размерности M и N соответственно.
            //Необходимо переписать в третий массив общие элементы
            //первых двух массивов без повторений.
            /*
            Console.WriteLine("------HomeWork_4------");
            Console.WriteLine();
            int[] arr1, arr2;
            int[] arr1WithoutRepetitions, finalArr;
            int M, N;
            Console.Write("Введите размер первого массива: ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размер второго массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            arr1 = new int[M];
            arr2 = new int[N];
            Console.Write("Первый массив: ");
            RandomArray(arr1);
            PrintArray(arr1);
            Console.Write("Второй массив: ");
            RandomArray(arr2);
            PrintArray(arr2);
            bool flag = true;
            arr1WithoutRepetitions = new int[NumberOfUniqueNumbersInArr(arr1)];
            Console.WriteLine(NumberOfUniqueNumbersInArr(arr1));
            /*counter = 0;
            for (int i = 0; i < M; i++)
            {   
                for (int j = 0; j < i; j++)
                {
                    if (arr1[i] == arr1[j])
                    { 
                        flag = false;
                        break;
                    }
                    flag = true;
                }
                if (flag)
                {
                    arr1WithoutRepetitions[counter] = arr1[i];
                    counter++;
                }
            }
            PrintArray(arr1WithoutRepetitions);*/
        }
        static void RandomArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
        }
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        static int NumberOfUniqueNumbersInArr(int[] array)
        {
            int max = array.Max();
            int min = array.Min();
            int numberOfUniqueNumbers = 0;
            int[] arrOfFlags = new int[max - min + 1];
            for (int i = 0; i < arrOfFlags.Length; i++)
            {
                for (int j = 0; j < array.Length; i++)
                {
                    if (arrOfFlags[array[j] - min] == 0) arrOfFlags[array[j] - min] += 1;
                }
            }
            for (int i = 0; i < arrOfFlags.Length; i++)
            {
                numberOfUniqueNumbers += arrOfFlags[i];
            }
            return max;
        }

    
    }
}
