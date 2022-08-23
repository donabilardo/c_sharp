//  Создать массив со случайными числами от -9 до 9
//  Массив должен состоять из 12 элементов
//  Найти сумму отрицательных и положительных чисел


Console.Clear();

int[] GetArray() // получаем массив
{
    int[] array = new int[12];

    for (int i = 0; i != 12; i++)
    {
        array[i] = new Random().Next(-9, 9);
        System.Console.WriteLine($"Индекс {i} | Значение {array[i]}");

    }
    return array;
}

int Summ1(int[] array) //сумма положительных чисел
{
    int SumDigit = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            SumDigit = SumDigit + array[i];
        }
    }
    return SumDigit;
}

int Summ2(int[] array) //сумма отрицательных чисел
{
    int SumDigit = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            SumDigit = SumDigit + array[i];
        }
    }
    return SumDigit;
}



int[] NewArr = GetArray();

System.Console.WriteLine(String.Empty);


System.Console.WriteLine($"Сумма положительных чисел: {Summ1(NewArr)}");
System.Console.WriteLine($"Сумма отрицательных чисел: {Summ2(NewArr)}");