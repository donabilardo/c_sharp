//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.
//  [3 7.3 22.2 2 78] -> 76

Console.Clear();

int Prompt(string message)
{  //Приём данных от пользователя из консоли
    System.Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] GetArray(int len, int start, int end)
{ //генерация массива из заданых значений: длиннаб начало массива, конец массива
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] array)
{ //Вывод массива в консоль
    System.Console.WriteLine("_________START__________");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Индекс массива ({i}) | значение в ячейке ({array[i]})");
    }
    System.Console.WriteLine("__________END___________");
}

int MinArray(int[] array) //Поиск минимального значения
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int MaxArray(int[] array) //Поиск максимального значения
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int ResultMinMax (int min, int max){ //разница между максимальным и минимальным значением
    int result = max - min;
    return result;
}


int len = Prompt("Введите длинну массива: "); //Задаем длинну массива
Console.Clear();
int start = Prompt("Введите начало массива: "); //задаем начало массива
Console.Clear();
int end = Prompt("Введите конец массива: "); //Задаем конец массива
Console.Clear();
int[] RandomArray = GetArray(len, start, end);  //получем массив исходя из полученных данных (сверху)

int AnswerPrint = Prompt("распечатать массив? (Да - 1 | Нет - 2");
if (AnswerPrint == 1)
{
    PrintArray(RandomArray);
}
else
{
    System.Console.WriteLine($"Сгенерирован массив, длинной {RandomArray.Length} ");
    System.Console.WriteLine(String.Empty);
}


System.Console.WriteLine(String.Empty);
System.Console.WriteLine($"Разница между максимальным ({MaxArray(RandomArray)}) и минимальным ({MinArray(RandomArray)}) значением в массиве ({ResultMinMax(MinArray(RandomArray),MaxArray(RandomArray))})");