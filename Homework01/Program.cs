// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // Подсказка к дз с выводом вещественных чисел: Console.Write($"{array[i,j]:f2}"); В методе печати массива :)



// Console. WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console. ReadLine()!);
// Console. WriteLine("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console. ReadLine()!);
// double[,] array = new double[rows, columns];

// GetArray(array);
// PrintArray(array);

// void GetArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++) 
//         {
//             // Console.Write($"{array[i,j]} ");
//             Console.Write($" {array[i,j]:f2} ");
//         } 
//         Console.WriteLine();
//     }
// }







// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// // и возвращает значение этого элемента или же указание, что такого элемента нет.


// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[10, 10];

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// PrintArray(numbers);
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
//     Console.WriteLine($"Введенным индексам соответствует элемент: {numbers[rows, colums]}");
// else Console.WriteLine($"Элемента с указанными индексами {rows} и {colums} в заданном массиве нет");

// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//             for(int j = 0; j < array.GetLength(1); j++);        
    
// }













// // Задача 52. Задайте двумерный массив из целых чисел.
// // Найдите среднее арифметическое элементов в каждом столбце.


// Console. Write("Введите количество строк M массива: ");
// int rows = int.Parse(Console. ReadLine()!);
// Console. Write("Введите количество столбцов N массива: ");
// int columns = int.Parse(Console. ReadLine()!);

// int[,] array = GetArrayRandom(rows, columns, 0, 5);
// PrintArray(array);
// Console.WriteLine("----------------------------");
// GetAvgColumn(array);

// int[,] GetArrayRandom(int M, int N, int minValue, int maxValue)
// {
//     int[,] array = new int[M,N];
//         for(int i = 0; i < M; i++)
//         {
//             for(int j = 0; j < N; j++)
//             {
//             array [i, j] = new Random().Next(minValue, maxValue +1);
//             }
//         }
//         return array;
// }    

// void PrintArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {array[i,  j]} ");
//         } 
//         Console.WriteLine("]");
//     }
// }

// void GetAvgColumn(int[,] array)
// {
//     for(int j = 0; j < array.GetLength(1); j++)
//       {
//         int sum = 0;        
//         for(int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i,j];
//         }
// Console.Write($"{sum / array.GetLength(0)} ");}
                
//             }
//             Console.ReadLine(); 
