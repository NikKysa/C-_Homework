// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N:");
// int n = Convert.ToInt32(Console.ReadLine());

// string NumRange(int m, int n)
// {
//     if (m <= n)
//         return $"{m} " + NumRange(m + 1, n);
//     else return ("Введенное число N должно быть больше числа M");
// }
// Console.WriteLine(NumRange(m, n));




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// Console.WriteLine("Введите число M:");
// int  m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N:");
// int  n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// if(m <= n)
// {
//    Console.WriteLine("Ошибка введения данных!"); 
// }
// else
// {
//      while(n <= m)
//     {
//         sum += n;
//         n++;
//     }
//     Console.WriteLine("Сумма чисел: " + sum);
// }




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(A(m, n));
// int A(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m != 0 && n == 0) return A(m - 1, 1);
//     if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
//     return A(m,n);            
// }
// Console.WriteLine();