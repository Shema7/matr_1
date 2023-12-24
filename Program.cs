// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
// }
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t  ");
//         Console.WriteLine();
// }
 
//  Console.WriteLine("Введите координаты");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("такого числа нет");
//  else
//  {
//  object c = array.GetValue(a,b);
//  Console.WriteLine(c);
//  }

// ........................................................................................................
// Задача 2: Задайте двумерный массив.
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.
//  class Programm
//      {
//     static void Main(string[] args)
//         {
//             int[,] array = CreateArray(5, 5, 10, 1);
//             Console.WriteLine("До вызова функции ReplaceFirstRowWithLastRow:");
//             PrintArray(array);
//             ReplaceFirstRowWithLastRow(array);
//             Console.WriteLine("После вызова функции ReplaceFirstRowWithLastRow:");
//             PrintArray(array);
//         }
//          static int[,] CreateArray(int Rows, int Columns, int MaxValue, int MinValue)
//         {
//             int[,] Result = new int[Rows, Columns];
//             Random random = new Random();
//             for (int i = 0; i < Rows; i++)
//             {
//                 for (int j = 0; j < Columns; j++)
//                 {
//                     Result[i, j]=random.Next(MinValue, MaxValue);
//                 }

//             }
//             return Result;

//         }
//          static void ReplaceFirstRowWithLastRow(int[,] Array)
//         {
//             int tmp;
//             int Rows = Array.GetUpperBound(0)+1;
//             for (int i = 0; i < Array.Length/Rows; i++)
//             {
//                 tmp = Array[0, i];
//                 Array[0, i]=Array[Rows-1, i];
//                 Array[Rows-1, i]=tmp;
//             }

//         }
//         static void PrintArray(int[,] Array)
//         {
//             int Rows = Array.GetUpperBound(0)+1;
//             for (int i = 0; i < Rows; i++)
//             {
//                 for (int j = 0; j <Array.Length/Rows; j++)
//                 {
//                     Console.Write($"{Array[i, j]}\t");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }

// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }
//////////////////////////////
