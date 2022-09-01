// Задача 3. Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();


int Prompt(string message)//метод получения данных от пользователя
{
    System.Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[,] CreateArray(int row, int col)
{
    int[,] matrix = new int[row, col];
    return matrix;
}

void FillArrayRandomNumber(int[,] matrix, int NumStart, int NumEnd)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int col = 0;
        while (col < matrix.GetLength(1))
        {
            matrix[row, col] = new Random().Next(NumStart, NumEnd);
            col++;
        }
    }
}

void PrintArray(int[,] matrix) // метод печати массива в консоль
{
    for (int row = 0; row < matrix.GetLength(0); row++) //строки
    {
        for (int col = 0; col < matrix.GetLength(1); col++) //колонки
        {
            System.Console.Write($"  {matrix[row, col]}  "); // печать массива
        }
        System.Console.WriteLine(""); //перенос строки
    }
}



System.Console.WriteLine("Диапазон случайных чисел");
System.Console.WriteLine(" ");
int start = Prompt("Начало диапазона:");
int end = Prompt("Конец диапазона:");
Console.Clear();

System.Console.WriteLine("Длинна массива");
System.Console.WriteLine(" ");
int row = Prompt("Колическтво строк:");
int col = Prompt("Количество колонок:");
Console.Clear();

int[,] matrix = CreateArray(row, col);
FillArrayRandomNumber(matrix, start, end);
System.Console.WriteLine("Сгенерированный массив:");
System.Console.WriteLine("");
PrintArray(matrix);
