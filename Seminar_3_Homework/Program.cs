// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);

// if (num >= 10000 && num <= 100000)
// {
//     if (result[0] == result[4] && result[1] == result[3])
//     {
//         Console.WriteLine("Число является палиндромом!");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом!");
//     }
// }
// else
// {
//     Console.WriteLine("Число не соответствует условию!");
// }


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

// Console.WriteLine(d);



// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int index = 1;

// while (index <= num)
// {
//     Console.WriteLine(Math.Pow(index, 3));
//     index++;
// }

// for (int count = 1; count<=num; count++) {
// 	double result = Math.Pow(count, 3);
// 	Console.WriteLine(result);
// }