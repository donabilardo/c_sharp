//  Задача 3. Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Clear();


int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

int[,] Random2Dim(int Rows, int Collumns, int startNums, int endNums) // метод для динамической генерации двумерного массива заполеннного случайными числами
{
    int[,] array = new int[Rows, Collumns]; //обьявляем массив Rows - строки, Collumns - колонки


    for (int row = 0; row < array.GetLength(0); row++) //генерация строки
    {
        for (int col = 0; col < array.GetLength(1); col++) //генерация колонки
        {
            array[row, col] = new Random().Next(startNums, endNums); //заполнение ячеек массива случайными числами
        }
    }
    return array; //возвращаем массив
}

void PrintArray(int[,] array)  // метод для печати массива в консоль
{
    for (int row = 0; row < array.GetLength(0); row++) // пока строка меньше длинны массива
    {
        for (int col = 0; col < array.GetLength(1); col++) // пока колонка меньше длинны массива
        {
            System.Console.Write($"{array[row, col]} "); //вывод данных в 1 строку

        }
        System.Console.WriteLine(""); //пустая строка для переноса
    }
}

void ShowColumnAverage(int[,] array) 
{
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        System.Console.WriteLine($"Среднее арифм. элементов в {i+1} столбце = {Math.Round(result/array.GetLength(0), 1)}");
        result = 0;
    }
}


int rows = Prompt("Количество строк"); //Получаем количество строк
int coll = Prompt("Количество столбцов"); //Получаем количество столбцов

int[,] RandomArray = Random2Dim(rows,coll,1,9); //генерируем массив
PrintArray(RandomArray); // Выводим массив
System.Console.WriteLine("");

ShowColumnAverage(RandomArray);