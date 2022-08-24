//  Задача 1: Напишите программу замены элементов массива: 
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


int[] GetRandomArray(int len, int start, int end) // получаем массив
{
    int[] array = new int[len]; //обьявляем массив указанной длинны
    int i = 0; //счетчик индекса массива
    while (i < array.Length) // цикл работает пока индекс массива меньше длинны массива
    {
        array[i] = new Random().Next(start, end); //заполняем массив случайными числами от start до end
        i++; //увеличиваем счетчик на еденицу
    }
    return array; //возвращаем массив
}

void PrintArray(int[] array) //Печать массива
{
    for (int i = 0; i < array.Length; i++) // цикл работает пока индекс массива меньше длинны массива
    {
        System.Console.WriteLine($"Индекс = {i} | Значение = {array[i]}"); // выводим за каждую итерацию по 1 элементу массива
    }
}

int[] ReplaceDigitArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0 && array[i] != 0)
        {
            array[i] = array[i] * -1;
            System.Console.WriteLine($"{i} > {array[i]}");
        }
    }
    return array;
}


int len = Prompt($"Введите длинну массива: "); // запрашиваем длинну массива
Console.Clear();
int start = Prompt($"Введите начало массива: ");// запрашиваем начало массива
Console.Clear();
int end = Prompt($"Введите конец массива: ");// запрашиваем конец массива
Console.Clear();

int[] RandomArray = GetRandomArray(len, start, end); // вызываем метод для генерации массива

int print = Prompt($"Печатать массив? 1 - ДА: 2 - НЕТ");// запрашиваем надо ли распечатать массив в консоль
Console.Clear();

if (print == 1)
{
    PrintArray(RandomArray);
}
else
{
    System.Console.WriteLine($"Сгенерирован массив: длянна {len}");
    System.Console.WriteLine(String.Empty);
}

System.Console.WriteLine("");
System.Console.WriteLine("Изменененные элементы");
ReplaceDigitArray(RandomArray);


System.Console.WriteLine("");
System.Console.WriteLine("Полностью измененный массив");
PrintArray(RandomArray);