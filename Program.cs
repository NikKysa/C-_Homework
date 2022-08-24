// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трехзначное число:");
// int num = Convert.ToInt32(Console.ReadLine());
// string stringNum = Convert.ToString(num);

// Console.WriteLine("Вторая цифра числа: " + stringNum [1]);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);

// if (numText.Length > 2)
// {
//     Console.WriteLine("Третья цифра: " + numText[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("выходной день");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("это не день недели");
}
else Console.WriteLine("будние");