/*  Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
        2 4 | 3 4
        3 2 | 3 3
    Результирующая матрица будет:
        18 20
        15 18
 */

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


#region Решение задачи

int[,] Multiplication(int[,] matrix1, int[,] matrix2)
{

    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

void FillandCheckMatrix()
{
    System.Console.WriteLine("Первая матрица");
    int[,] matrix1 = CreateArray(Prompt("Введите число строк:"), Prompt("введите число колонок:"));
    Console.Clear();

    System.Console.WriteLine("Вторая матрица");
    int[,] matrix2 = CreateArray(Prompt("Введите число строк:"), Prompt("введите число колонок:"));
    Console.Clear();

    if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
    {
        System.Console.WriteLine("Длинна массива должна быть одно длинны");
    }
    else
    {
        FillArrayRandomNum(matrix1);
        FillArrayRandomNum(matrix2);

        System.Console.WriteLine("Первая матрица");
        PrintArray(matrix1);
        System.Console.WriteLine(String.Empty);
        System.Console.WriteLine("Вторая матрица");
        PrintArray(matrix2);
        System.Console.WriteLine(String.Empty);

        System.Console.WriteLine("Результат");
        PrintArray(Multiplication(matrix1, matrix2));
    }

}


#endregion





FillandCheckMatrix();










/* FillArrayRandomNum(matrix);
System.Console.WriteLine("Сгенерирован массив:");
PrintArray(matrix);
System.Console.WriteLine(String.Empty); */





System.Console.WriteLine("Для выхода. нажмите любую клавишу...");
Console.ReadKey();