//  Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, 
//  сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

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

int[] CountDigit(int[,] array)
{
    int[] result = new int[10];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[array[i, j]]++;
        }
    }
    return result;
}


int row = Prompt("Введите количество строк");
Console.Clear();
int col = Prompt("Введите количество колонок");
Console.Clear();
int[,] matrix = CreateArray(row, col);
FillArrayRandomNum(matrix);
System.Console.WriteLine("Сгенерированный массив от 0 -до 9");
System.Console.WriteLine("");
PrintArray(matrix);
System.Console.WriteLine("");
int[] mass = CountDigit(matrix);
System.Console.WriteLine("Подсчет результатов:");
System.Console.WriteLine("");


for (int i = 0; i < mass.Length; i++)
{
    System.Console.WriteLine($"Число {i} встречается {mass[i]} раз");
}