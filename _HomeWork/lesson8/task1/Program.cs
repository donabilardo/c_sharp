//  Задача 1: Задайте двумерный массив. 
//  Напишите программу, которая упорядочит 
//  по убыванию элементы каждой строки двумерного массива.

/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


Console.Clear();



/* int[] matrix = new int[] { 1, 4, 7, 2 };


for (int i = 0; i < matrix.Length; i++)
{
    for (int j = 0; j < matrix.Length - 1; j++)
    {
        if (matrix[j] < matrix[j + 1])
        {
            int tmp = matrix[j];
            matrix[j] = matrix[j + 1];
            matrix[j + 1] = tmp;
        }
    }
}


for (int i = 0; i < matrix.Length; i++)
{
    System.Console.Write($"{matrix[i]}\t");
} */

int[,] matrix = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };




for (int i = 0; i)
