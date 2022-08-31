//  Сгенерировать двумерный массив со случайными числами,
//  вывести его на экран, оформить в виде функций


Console.Clear();

double Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    double result = double.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


/* int row = Prompt("Введите количество строк");
Console.Clear();
int row = Prompt("Введите количество столбцов");
Console.Clear();
int startNums = Prompt("Начало диапазона для генерации случайных чисел");
Console.Clear();
//int endNums = Prompt("Конец диапазона для генерации случайных чисел");
Console.Clear(); */




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
    for (int row = 0; row < array.GetLength(0); row++) // пока меньше длинны массива
    {
        for (int col = 0; col < array.GetLength(1); col++) // пока меньше длинны массива
        {
            System.Console.Write($"{array[row, col]} "); //вывод данных в 1 строку
            
        }
        System.Console.WriteLine(""); //пустая строка для переноса
    }
}



int[,] RandomArr = Random2Dim(4, 4, 1, 901); //генерация массива 1 параметр строка, 2 колонки, 3 начало и 4 конец для диапазона случайных чисел
PrintArray(RandomArr); // печать в консоль