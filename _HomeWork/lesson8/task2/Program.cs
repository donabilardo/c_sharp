/* Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

#region  Поиск строки в которой сумма элементов больше остальных

int[] SearchMaxRow(int[,] array) //пишем результат в одномерный массив
{

    int[] result = new int[array.GetLength(0)];
    int sum = 0;
    int IndexResult = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        result[IndexResult] = sum;
        IndexResult++;
        sum = 0;
    }
    return result; // получаем одномерный массив с суммами каждой строки
}

int SearchInResult(int[] array) // поиск максимальной суммы из массива с рузультатами
{
    int MaxRow = array[0];
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxRow)
        {
            MaxRow = array[i];
            result = i;
        }
    }
    return result;
}

void PrintResult(int[] array) //печать результатов в поиске
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"сумма в {i} строке = {array[i]}");
    }
    System.Console.WriteLine(String.Empty);
}

#endregion


int[,] matrix = CreateArray(Prompt("Введите число строк:"), Prompt("введите число колонок:"));
Console.Clear();
FillArrayRandomNum(matrix);
System.Console.WriteLine("Сгенерирован массив:");
PrintArray(matrix);
System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Сумма чисел в отдельно взятой строке");
int[] arr = SearchMaxRow(matrix);
PrintResult(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальная сумма чисел в {SearchInResult(arr)} строке");
System.Console.WriteLine();
System.Console.WriteLine("Для выхода. нажмите любую клавишу...");
Console.ReadKey();