//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16


Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


int Stepen(int a, int b)
{
    int result = 1; // тут храним результат
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int num1 = Prompt("Введите число: "); // Ввод числа А
Console.Clear();
int num2 = Prompt("В какую стпень возвести:"); // Ввод числа В (в какую степень возводить число А)
Console.Clear();

//int res = Stepen(num1, num2);
System.Console.WriteLine($"Число {num1} в степени {num2}, равно {Stepen(num1, num2)}");




