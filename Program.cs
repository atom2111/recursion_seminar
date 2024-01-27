// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void PrintNumbers()
// {
//     Console.WriteLine("Введите число M: ");
//     int m = int.Parse(Console.ReadLine());

//     Console.WriteLine("Введите число N: ");
//     int n = int.Parse(Console.ReadLine());

//     PrintNaturalNumbers(m, n);
// }

// void PrintNaturalNumbers(int start, int end)
// {
//     if(start > end)
//     {
//         return;
//     }

//     Console.Write(start + " ");

//     PrintNaturalNumbers(start + 1, end);
// }

// PrintNumbers();

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int[,] memo = new int[100, 100];

// int FunctionAkkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return FunctionAkkerman(m - 1, 1);
//     }
//     else
//     {
//         return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
//     }
// }

// int result = FunctionAkkerman(2, 3);
// Console.WriteLine("Результат: " + result);

// Пример работы функции Аккермана:
// Akkerman(2, 3) = Akkerman(1, Akkerman(2, 2))
//               = Akkerman(1, Akkerman(1, Akkerman(2, 1)))
//               = Akkerman(1, Akkerman(1, Akkerman(1, Akkerman(2, 0))))
//               = Akkerman(1, Akkerman(1, Akkerman(1, 2)))
//               = Akkerman(1, Akkerman(1, Akkerman(0, Akkerman(1, 1))))
//               = Akkerman(1, Akkerman(1, Akkerman(0, Akkerman(0, Akkerman(1, 0)))))
//               = Akkerman(1, Akkerman(1, Akkerman(0, Akkerman(0, 2))))
//               = Akkerman(1, Akkerman(1, Akkerman(0, 3)))
//               = Akkerman(1, Akkerman(1, 4))
//               = Akkerman(1, Akkerman(0, Akkerman(1, 3)))
//               = Akkerman(1, Akkerman(0, Akkerman(0, Akkerman(1, 2))))
//               = Akkerman(1, Akkerman(0, Akkerman(0, Akkerman(0, Akkerman(1, 1)))))
//               = Akkerman(1, Akkerman(0, Akkerman(0, Akkerman(0, Akkerman(0, Akkerman(1, 0))))))
//               = Akkerman(1, Akkerman(0, Akkerman(0, Akkerman(0, Akkerman(0, 2)))))
//               = Akkerman(1, Akkerman(0, Akkerman(0, Akkerman(0, 3))))
//               = Akkerman(1, Akkerman(0, Akkerman(0, 4)))
//               = Akkerman(1, Akkerman(0, 5))
//               = Akkerman(1, 6)
//               = 9

// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// void PrintArrayReverse(int[] arr, int index)
// {
//     if(index >= 0)
//     {
//         Console.Write(arr[index] + " ");
//         PrintArrayReverse(arr, index - 1);
//     }
// }

// Console.WriteLine("Массив, начиная с конца: ");
// PrintArrayReverse(array, array.Length - 1);