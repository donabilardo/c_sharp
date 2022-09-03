//  Задайте двумерный массив. 
//  Напишите программу, которая заменяет строки на столбцы. 
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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
            array[i, j] = new Random().Next(1, 9);
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

bool CheckLengthRowCol(int[,] array)// Проверка длинны строк и колонок в массиве
{
    int row = array.GetLength(0) - 1;
    int col = array.GetLength(1) - 1;
    if (row != col)
    {
        return false;
    }
    return true;
}

int row = Prompt("Введите количество строк");
Console.Clear();
int col = Prompt("Введите количество колонок");
Console.Clear();
int[,] matrix = CreateArray(row, col);
FillArrayRandomNum(matrix);
PrintArray(matrix);

bool result = CheckLengthRowCol(matrix);
if (result == false)
{
    System.Console.WriteLine("Замена значений невозможна, т.к. длинна строк и столбцов массива отличаются");
}
else
{
    System.Console.WriteLine("Замена возможна, будем думать как это сделать )))");
}