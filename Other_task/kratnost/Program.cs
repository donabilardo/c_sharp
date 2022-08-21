//  Напишите программу, которая будет принимать на вход два числа
//  и выводить, является ли второе число кратным первому. 
//  Если число 2 не кратно числу 1, то программа выводит остаток от деление.
//  34, 5->не кратно, остаток 4
//  16, 4->кратно

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string readValue = System.Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}



int num1 = Prompt("Первое число: ");
int num2 = Prompt("Второе число: ");
int Num1andNum2 = num1 % num2;

if (Num1andNum2 == 0)
{
    System.Console.WriteLine($"Первое число ({num1}), кратно второму числу ({num2})");
}
else
{
    System.Console.WriteLine($"Первое число ({num1}), НЕ кратно второму числу ({num2})");

}


