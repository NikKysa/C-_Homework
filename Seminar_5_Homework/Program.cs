// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Console.WriteLine("Введите размер массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// if (numbers[i] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int j = 0; j < numbers.Length; j++)
//     {
//         numbers[j] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int j = 0; j < numbers.Length; j++)
//     {
//         Console.Write(numbers[j] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int [] array = { -4, -6, 89, 6 };
// int oddNumSum = 0;

// for (int i = 1; i < array.Length; i+=2)

//     oddNumSum+=array[i];

// Console.WriteLine("Сумма элементов на нечетных позициях = " + oddNumSum);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// int[] array = { 5, 8, 98, 3, 24 };
// int i, min, max, diff;
// min = array[0];
// max  = array[0];
// diff = 0;

// for (i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
//     diff = max - min;
// }

// Console.WriteLine("Разность между макс и мин = " + diff);
