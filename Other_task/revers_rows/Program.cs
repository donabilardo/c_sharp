// Задайте двумерный массив.
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

Console.Clear();

void FillArrayRandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}

void PrintArray(int[,] array)
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

/* void ReversRows(int[,] array)
{
    for (int i = array.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($" {array[i, j]} ");
        }
        System.Console.WriteLine("");
    }
} */

int[,] ReverseArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
    return array;
}


int[,] matrix = new int[5, 5]; //инициализируем двумерный массив
FillArrayRandomNum(matrix); // заполняем случайными числами

System.Console.WriteLine("Изначально созданный массив");
PrintArray(matrix); // выводим изначально созданный массив в консоль
System.Console.WriteLine("Измененный массив");
/* ReversRows(matrix);// выводим  измененный массив в консоль
 */
ReverseArray(matrix);
PrintArray(matrix);