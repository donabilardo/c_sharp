//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.



Console.Clear();




double[,] Random2Dim(int Rows, int Collumns, int startNums, int endNums) // метод для динамической генерации двумерного массива заполеннного случайными числами
{
    double[,] array = new double[Rows, Collumns]; //обьявляем массив Rows - строки, Collumns - колонки


    for (int row = 0; row < array.GetLength(0); row++) //генерация строки
    {
        for (int col = 0; col < array.GetLength(1); col++) //генерация колонки
        {
            array[row, col] = new Random().Next(startNums, endNums); //заполнение ячеек массива случайными числами
        }
    }
    return array; //возвращаем массив
}

void PrintArray(double[,] array)  // метод для печати массива в консоль
{
    for (int row = 0; row < array.GetLength(0); row++) // пока меньше длинны массива
    {
        for (int col = 0; col < array.GetLength(1); col++) // пока меньше длинны массива
        {
            System.Console.Write($"{array[row, col]} "); //вывод данных в 1 строку
            
        }
        System.Console.WriteLine(""); //пустая строка для переноса
    }
}


PrintArray(Random2Dim(3,4,-100,100)); //печать массива в консоль
//параметры слева направо: число строкб число колонок, начальный и конечный диапазон для генерации случаных чисел для заполнения массива
