// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Сколько чисел вы хотите ввести? ");
// int numb = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[numb];

// int PositiveCount(int count)
// {
//     int countOfPositive = 0;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         if (array[i] > 0)
//         {
//             countOfPositive += 1;
//         }
//         Console.WriteLine("[{0}]", string.Join(",", array));
//     }
//     return countOfPositive;
// }
// int posCount = PositiveCount(numb);
// Console.Write($"количество положительных чисел = {posCount}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите число k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите число b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2 && b1 == b2) Console.WriteLine($"Прямые совпали");
// else
// {
//     if (k1 == k2) Console.WriteLine($"Прямые параллельны");
//     else
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine($"Точка пересечения = ({x}); ({y})");
//     }
// }