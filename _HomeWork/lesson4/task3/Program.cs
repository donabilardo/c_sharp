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


int LenArr = Prompt("Длина массива: ");
Console.Clear();
int SatrtArr = Prompt("Начальное значение, для диапазона случайного числа: ");
Console.Clear();
int EndArr = Prompt("Конечное значение, для диапазона случайного числа:");
Console.Clear();





  int[] newArr = new int[LenArr];
    for (int i = 0; i < LenArr; i++)
    {
        newArr[i] = new Random().Next(SatrtArr, EndArr);
        System.Console.WriteLine($"Индекс массива ({i}) значение = {newArr[i]}");
    }




