//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

int value = Prompt("Введите трехзначное число: "); //получаем значение из консоли

if (value >= 100 && value < 1000)
{
    value = value / 10 % 10;
    System.Console.WriteLine(value);
}
else
{
    System.Console.WriteLine("По условию задачи, чило должно быть 3-х значным");
}


