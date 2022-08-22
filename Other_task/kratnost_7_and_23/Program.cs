//  Напишите программу, которая принимает на вход число
//  и проверяет, кратно ли оно одновременно 7 и 23.
//14->нет
//46->нет
//161->да


Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readValue = System.Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int num1 = Prompt("Введите число: ");

Console.Clear();

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    System.Console.WriteLine($"Число ({num1}), кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"Число ({num1}), НЕ кратно 7 и 23");

}
