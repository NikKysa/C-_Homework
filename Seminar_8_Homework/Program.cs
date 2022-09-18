// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine(" ");

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//         {
//             if (matrix[i, k] < matrix[i, k + 1])
//             {
//                 int count = matrix[i, k];
//                 matrix[i, k] = matrix[i, k + 1];
//                 matrix[i, k + 1] = count;
//             }
//         }
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


// int [,] GetMatrix (int rows, int columns, int min, int max)
// {
//     int [,] array = new int [rows,columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(min,max);
//             Console.Write(array[i,j]+"\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int [,] newArray = GetMatrix(4,5,0,11);

// int minRow = int.MaxValue;
// int minIndex = 0;
// for (int i = 0; i < newArray.GetLength(0); i++)
// {
//     int sumRow = 0;
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//         sumRow = sumRow + newArray[i,j];
//     }
//     Console.WriteLine($"Сумма строки {i+1} равна {sumRow}");
//     if(sumRow < minRow) 
//     {
//         minRow = sumRow;
//         minIndex = i;
//     } 
// }
// Console.WriteLine($"Минимальная сумма в строке {minIndex+1}");




// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.


// Console.WriteLine("Введите количество строк 1 матрицы:");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов 1 матрицы:");
// int columns1 = Convert.ToInt32(Console.ReadLine());

// int rows2 = columns1;
// int columns2 = rows1;

// Console.WriteLine("Матрица 1: ");
//     int[,] matrix1 = new int[rows1, columns1];

//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix1.GetLength(1); j++)
//         {
//             matrix1[i, j] = new Random().Next(0, 11);
//             Console.Write(matrix1[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

// Console.WriteLine("Матрица 2: ");
//     int[,] matrix2 = new int[rows2, columns2];

//     for (int i = 0; i < matrix2.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             matrix2[i, j] = new Random().Next(0, 11);
//             Console.Write(matrix2[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(" ");
// Console.WriteLine("Произведение матриц: ");

//     int[,] matrixAnswer = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix2.GetLength(0); k++)
//             {
//                 matrixAnswer[i, j] += matrix1[i, k] * matrix2[k, j];
//             }
//             Console.Write(matrixAnswer[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }




// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.


// int[] array2D = new int[90];
// for (int i = 0; i < array2D.Length; i++)
// {
//     array2D[i] = 10 + i;
// }
// for (int i = 0; i < array2D.Length; i++)
// {
//     int j = new Random().Next(array2D.Length);
//     int temp = array2D[j];
//     array2D[j] = array2D[i];
//     array2D[i] = temp;
// }

// int[,,] GetMatrix(int tables, int rows, int columns, int min, int max)
// {
//     int m = 0;
//     int[,,] array = new int[tables, rows, columns];
//     for (int k = 0; k < array.GetLength(0); k++)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             for (int j = 0; j < array.GetLength(2); j++)
//             {
//                 array[k, i, j] = array2D[m];
//                 Console.Write($"{array[k, i, j]} ({k},{i},{j})  ");
//                 m++;
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,,] array3D = GetMatrix(2, 2, 2, 10, 100);




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:


// int[,] array = new int[4, 4];
// int number = 0;
// int i = 0;
// int j = 0;

// for (j = 0; j < array.GetLength(1); j++)
// {
//     array[i, j] = number + 1;
//     number++;
// }
// j = 3;
// for (i = 1; i < array.GetLength(0); i++)
// {
//     array[i, j] = number + 1;
//     number++;
// }
// i = 3;
// for (j = 2; j >= 0; j--)
// {
//     array[i, j] = number + 1;
//     number++;
// }
// j = 0;
// for (i = 2; i >= 1; i--)
// {
//     array[i, j] = number + 1;
//     number++;
// }
// i = 1;
// for (j = 1; j <= 2; j++)
// {
//     array[i, j] = number + 1;
//     number++;
// }
// i = 2;
// for (j = 2; j >= 1; j--)
// {
//     array[i, j] = number + 1;
//     number++;
// }

// for (i = 0; i < array.GetLength(0); i++)
// {
//     for (j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write(array[i, j] + "\t");
//     }
//     Console.WriteLine();
// }