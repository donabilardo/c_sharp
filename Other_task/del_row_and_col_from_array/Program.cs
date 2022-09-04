//  Задайте двумерный массив из целых чисел. 
//  Напишите программу, которая удалит строку и столбец, 
//  на пересечении которых расположен наименьший элемент массива.
/*     Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Наименьший элемент - 1, на выходе получим
    следующий массив:
    9 4 2
    2 2 6
    3 4 7 */

Console.Clear();

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

void PrintArray1(int[,] array) // печать двумерного массива
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

void PrintArray2(int[] array) // печать одномерного массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }
    System.Console.WriteLine(String.Empty);
}


int[] SearchMinIndex(int[,] array)
{
    int[] result = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[result[0], result[1]])
            {
                result[0] = j;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] DeleteMinDigit(int[,] array)
{
    int[] indexes = SearchMinIndex(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int l = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i != indexes[0] && j != indexes[1])
            {
                result[k, l] = array[i, j];
                l++;
            }
        }
        if (i != indexes[0]) k++;

    }


    return result;
}


int row = Prompt("Введите количество строк");
Console.Clear();
int col = Prompt("Введите количество колонок");
Console.Clear();
int[,] matrix = CreateArray(row, col);
FillArrayRandomNum(matrix);
System.Console.WriteLine($"Сгенерированный массив c числами 0 до 9, длинной  - {row} строк и {col} колонок");
PrintArray1(matrix);

System.Console.WriteLine("");

System.Console.WriteLine("Индексы у минимального числа");
PrintArray2(SearchMinIndex(matrix));
System.Console.WriteLine();
System.Console.WriteLine("Новый массив с удаленной строкой и столбцом с минимальным значением");
PrintArray1(DeleteMinDigit(matrix));