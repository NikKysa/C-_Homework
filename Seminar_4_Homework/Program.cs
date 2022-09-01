// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число A:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int exp = Exponentiation(num1, num2);
// Console.WriteLine("Ответ: " + exp);

// if (num2 <= 0)
// {
//   Console.WriteLine("Число В не соответствует условию");
// }

// int Exponentiation(int num1, int num2)
// {
//     int result = 1;
//     for (int i = 1; i <= num2; i++)
//         if (num2 > 0)
//         {
//             result *=  num1;
//         }
//     return result;
// }



// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetSum(num));

// int GetSum(int number)
// {
//     int sum=0;
//     while(number>0)
//     {
//         sum+=number%10;
//         number/=10;
//     }
//     return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] array = { 1, 2, 5, 7, 19, 6, 1, 33 };
// int i;

// for (i = 0; i < array.Length; i++)
// {
//     array[i]*=1;
// }
// Console.WriteLine("[{0}]", String.Join(", ", array));