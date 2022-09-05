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

#region  Запрос данных у пользователя, наполнение массива, печать массива

int Prompt(string message)//метод получения данных от пользователя
{
    System.Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[,] CreateArray(int row, int col) // создание пустого массива
{
    int[,] array = new int[row, col];
    return array;
}

void FillArrayRandomNum(int[,] array) // заполнение массива случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}

void PrintArray(int[,] array) // печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine(String.Empty);
    }

}

#endregion



#region  Сортировка методом "пузырька"

int[,] BubleSortArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            bool sort = true;
            for (int j = 0; j < matrix.GetLength(1) - 1 - k; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = tmp;
                    sort = false;
                }
            }
            if (sort) break;
        }
    }

    return matrix;
}

#endregion


int[,] matrix = CreateArray(Prompt("Введите число строк:"), Prompt("введите число колонок:"));
FillArrayRandomNum(matrix);
System.Console.WriteLine("Сгенерирован массив:");
PrintArray(matrix);
System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Отсортированный массив:");
BubleSortArray(matrix);
PrintArray(matrix);


