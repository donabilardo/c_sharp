//  Сгенерировать двумерный массив со случайными числами,
//  вывести его на экран, оформить в виде функций





int[,] Random2Dim(int Rows, int Collumns, int M, int N) // метод для динамической генерации двумерного массива заполеннного случайными числами
{
    int[,] array = new int[Rows, Collumns]; //обьявляем массив Rows - строки, Collumns - колонки


    for (int row = 0; row < array.GetLength(0); row++) //генерация строки
    {
        for (int col = 0; col < array.GetLength(1); col++) //генерация колонки
        {
            array[row, col] = new Random().Next(M, N); //заполнение ячеек массива случайными числами
        }
    }
    return array; //возвращаем массив
}


void PrintArray(int[,] array)  // метод для печати массива в консоль
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

int M = 3; //Число М (размер массива)
int N = 4; //Число N (размер массива)

int[,] RandomArr = Random2Dim(M, N, 1, 9); //генерация массива 1 параметр строка, 2 колонки, 3 начало и 4 конец для диапазона случайных чисел
PrintArray(RandomArr); // печать в консоль