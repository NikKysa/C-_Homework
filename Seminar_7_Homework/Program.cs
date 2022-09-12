// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] matrix = new double[rows, columns];

// Random rnd = new Random();
// void PrintArray(double[,] matrix)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         { Console.Write($"{matrix[i, j]} "); }
//         Console.WriteLine();
//     }
// }

// void FillArray(double[,] matrix)
// {
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         { matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100)/ 10.0); }
//     }
// }
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix = new int [rows,columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//         matrix[i, j] = Convert.ToInt32(new Random().Next(0, 100));
// }

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//         Console.Write(matrix[i, j] + "\t  ");
//     Console.WriteLine();
// }

// Console.WriteLine("Введите координаты");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > rows && b > columns)
//     Console.WriteLine("такого числа нет");
// else
// {
//     object c = matrix.GetValue(a, b);
//     Console.WriteLine(c);
// }



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
int sum = 0;
double avg = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        sum += matrix[i, j];
        avg = sum / rows;
        
        Console.Write(matrix[i, j] + "\t");
    }

    Console.WriteLine();
}

Console.WriteLine($"Среднее арифметическое каждого столбца = {avg}");