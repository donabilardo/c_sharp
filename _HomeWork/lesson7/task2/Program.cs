//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:

//  1 4 7 2
//  5 9 2 3
//  8 4 2 4

//  17 -> такого числа в массиве нет



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
    for (int row = 0; row < array.GetLength(0); row++) // пока строка меньше длинны массива
    {
        for (int col = 0; col < array.GetLength(1); col++) // пока колонка меньше длинны массива
        {
            System.Console.Write($"{array[row, col]} "); //вывод данных в 1 строку

        }
        System.Console.WriteLine(""); //пустая строка для переноса
    }
}

double Prompt(string message)// метод для получения числа которое надо найти в массиве
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    double result = double.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

int SearchNumInArray(double[,] array, double number)
{
    int count = 0;
    for (int row = 0; row < array.GetLength(0); row++) // пока строка меньше длинны массива
    {
        for (int col = 0; col < array.GetLength(1); col++) // пока колонка меньше длинны массива
        {
            if (array[row, col] == number)
            {
                count++;
            }
        }
    }
return count;
}


double[,] RandomArr = Random2Dim(5, 5, 1, 9);
System.Console.WriteLine("Массив со случаными вещественными числами: ");
PrintArray(RandomArr);//печать массива в консоль
//параметры слева направо: число строкб число колонок, начальный и конечный диапазон для генерации случаных чисел для заполнения массива
System.Console.WriteLine(String.Empty); // пустая строка для красоты
double NumSearch = Prompt("Введите число для поиска"); // Вызываем функцию для запроса искомого числа
System.Console.WriteLine(String.Empty); // пустая строка для красоты
int count = SearchNumInArray(RandomArr, NumSearch); //получаем количество найденных элементов в массиве
System.Console.WriteLine($"Искомое число ({NumSearch}) встречается в массиве {count} раз"); //выводим результат
