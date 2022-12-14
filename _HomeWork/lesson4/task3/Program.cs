//  Задача 3: Напишите программу, которая задаёт массив
//  из 8 элементов, выводит их на экран. 
//  И ищет второй максимум 
//  (элемент меньше максимального, но больше всех остальных)
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


int[] GetRandomArray(int LenArr, int SatrtArr, int EndArr) // метод для получения случайных значений массива
{
    int[] newArr = new int[LenArr]; // обьявляем массив

    for (int i = 0; i < LenArr; i++)
    {
        newArr[i] = new Random().Next(SatrtArr, EndArr); // заполняем случайными цифрами из диапазона SatrArr до EndArr
    }
    System.Console.WriteLine(String.Empty);
    return newArr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Индекс массива ({i}) значение = {array[i]}"); //вывод значения массива
    }
    System.Console.WriteLine("_____________________________________");
    System.Console.WriteLine(String.Empty);
}

int SearchMaxNumber(int[] array)
{ // метод для поиска второго по величине максимального числа из массива

    int max1 = array[0]; //первое максимальное число
    int max2 = array[0]; // второе максимальное число

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max1 = array[i];
        }
    }

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max2 && array[j] < max1)
        {
            max2 = array[j];
        }
    }
    return max2;

}





int LenArr = Prompt("Длина массива: ");
Console.Clear();
int SatrtArr = Prompt("Начальное значение, для диапазона случайного числа: ");
Console.Clear();
int EndArr = Prompt("Конечное значение, для диапазона случайного числа:");
Console.Clear();

int[] newArr = GetRandomArray(LenArr, SatrtArr, EndArr); //заполнение массива случаными числами 

PrintArray(newArr); // вывод массива

System.Console.WriteLine($"Второе максимальное число: {SearchMaxNumber(newArr)}"); // Поиск и вывод второго максимального числа из массива
