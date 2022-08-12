﻿
//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 ->  max = 7, min = 5
//a = -9 b = -3 -> max = -3, min = -9



Console.Clear();
System.Console.Write("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a1 = 5; b1 = 7");
System.Console.WriteLine("");
System.Console.WriteLine("Решение задачи: ");
int a1 = 5; // Первое число
int b1 = 7; // Второе число

if (a1 > b1)
{
    System.Console.WriteLine("max = a1");
    System.Console.WriteLine("min = b1");
}
else
{
    System.Console.WriteLine("max = b1");
    System.Console.WriteLine("min = a1");
}


System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.Write("Задача 1.2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. a2 = -3; b2 = -9");
System.Console.WriteLine("");
System.Console.WriteLine("Решение задачи: ");
int a2 = -3; // Первое число
int b2 = -9; // Второе число

if (a2 > b2)
{
    System.Console.WriteLine("max = a2");
    System.Console.WriteLine("min = b1");
}
else
{
    System.Console.WriteLine("max = b1");
    System.Console.WriteLine("min = a1");
}

System.Console.WriteLine("");
System.Console.WriteLine("");


System.Console.Write("Вариант с возможностью ввода произвольных чисел");

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
};
System.Console.WriteLine("");
int numberA = Prompt("Введите первое число: ");

System.Console.WriteLine("Первое число : " + numberA);

System.Console.WriteLine("");
int numberB = Prompt("Введите второе число: ");

System.Console.WriteLine("Первое число : " + numberB);

System.Console.WriteLine("");
if (numberA > numberB) {
    System.Console.WriteLine("Первое число (" + numberA + ") больше второго числа (" + numberB + ")");
} else {
    System.Console.WriteLine("Второе число (" + numberB + ") больше первого числа (" + numberA + ")");
}

