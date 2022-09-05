/* Задача 2: Задайте значения M и N. 
Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке 
 от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */


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


int FindNum(int m, int n)
{
if (n < m)
    {
        return 0;
    }
    return FindNum(m + 1, n) + m;
}





int m = Prompt("Число M");
int n = Prompt("Число N");


if (m > n)
{
    Console.WriteLine($"Число M не должно быть больше числа N");
}
else
{
    Console.WriteLine($"Результат: {FindNum(m, n)}");
}



System.Console.WriteLine("");
System.Console.WriteLine("Для выхода. нажмите любую клавишу...");
Console.ReadKey();





