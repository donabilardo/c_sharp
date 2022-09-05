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


void FindNum(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0) System.Console.Write($"{m} ");
    FindNum(m + 1, n);
}




int m = Prompt("Число M");
int n = Prompt("Число N");


    FindNum(m, n);
    System.Console.WriteLine("");


System.Console.WriteLine("Для выхода. нажмите любую клавишу...");
Console.ReadKey();