//  Задача 2: Напишите программу, 
//  которая принимает на вход число
//  и выдаёт сумму цифр в числе.
//  452 -> 11
//  82 -> 10
//  9012 -> 12




Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


int SummAllDigit(int num)
{
    int result = 0;
    while (num > 0)
    {
        int temp = num % 10;
        num = num / 10;
        result = result + temp;
    }
    return result;
}


int summNum = Prompt("Введите число:");
Console.Clear();

System.Console.WriteLine($"Сумма всех чисел в цифре {summNum} = {SummAllDigit(summNum)}");