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
Console.Clear();
 */



int[,] Random2Dim(int Rows, int Collumns, int startNums, int endNums) // метод для динамической генерации двумерного массива заполеннного случайными числами
{
    int[,] array = new int[Rows, Collumns]; //обьявляем массив
    int arrLength0 = 0; //счетчик для длинны массива
    int arrLength1 = 1; //счетчик для длинны массива

    for (int row = 0; row < array.GetLength(arrLength0); row++)
    {
        for (int col = 0; col < array.GetLength(arrLength1); col++){
            array[row,col] = new Random().Next(startNums,endNums);
        }
    }
return array;
}




