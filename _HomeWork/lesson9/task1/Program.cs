/* Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все 
чётные натуральные числа в промежутке 
от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */


Console.Clear();

#region  Запрос данных у пользователя, наполнение массива, печать массива

int Prompt(string message)//метод получения данных от пользователя
{
    System.Console.WriteLine(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

#endregion


int[] FindNum(int m, int n)
{
    int[] result;

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} \t");
    }
}


int m = Prompt("Число M");
int n = Prompt("Число N");

if (m < n)
{
    System.Console.WriteLine("Число N не может быть меньше M");
}
else
{
    PrintArray(FindNum(m,n));
    System.Console.WriteLine("");
}

System.Console.WriteLine("Для выхода. нажмите любую клавишу...");
Console.ReadKey();