//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
//  [3, 7, 23, 12] -> 19
//  [-4, -6, 89, 6] -> 0

Console.Clear();

int Prompt(string message)
{   //Ввод данных от пользователя
    System.Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}


int[] GetArray(int LengthArr, int startArr, int endArr)
{  //генерация массива указанной длинны с рандомными числами
    int[] array = new int[LengthArr];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startArr, endArr);
    }
    return array;
}


void PrintArray(int[] array)
{  //Вывод массива в консоль
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Индекс ({i}) | значение ({array[i]})");
    }
    System.Console.WriteLine("_________________");
    System.Console.WriteLine(String.Empty);
}


int SummArray(int[] array)
{ // Подсчёт суммы чисел которые находятся на нечетных индексах массива (я так понял задание)
    int result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i != 2)
        {
            result = result + array[i];
            i++;
        }
    }
    return result;
}


int LenArr = Prompt("Введите длинну массива");
Console.Clear();
int startArr = Prompt("Начало диапазона массива");
Console.Clear();
int endArr = Prompt("Конец диапазона массива");
Console.Clear();


int[] RandomArr = GetArray(LenArr, startArr, endArr);
PrintArray(RandomArr);
System.Console.WriteLine($"Сумма чисел в нечётных ячейках массива: {SummArray(RandomArr)}");
System.Console.WriteLine(String.Empty);
System.Console.WriteLine("PS: Как то так ) Надеюсь хоть на 1 урок удасться к Вам попасть (((");
System.Console.WriteLine(String.Empty);