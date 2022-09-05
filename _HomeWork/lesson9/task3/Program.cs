/* Напишите программу вычисления функции Аккермана
 с помощью рекурсии.
  Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

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

int AckermannFunc(int m, int n)
{

    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}



int m = Prompt("Число M");
int n = Prompt("Число N");

Console.WriteLine($"{AckermannFunc(m, n)}");

