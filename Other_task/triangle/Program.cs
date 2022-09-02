// Задача 1: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

bool Triangle(int num1, int num2, int num3)
{
    if (num1 + num2 > num3 && num2 + num3 > num1 && num3 + num1 > num2)
    {
        return false;
    }
    else
    {
        return true;
    }
}

void Checktriangle(bool result)
{
    if (result == true)
    {
        System.Console.WriteLine("Треугольник существует");
    }
    else
    {
        System.Console.WriteLine("Треугольника НЕ существует");
    }
}




int a = Prompt("1 сторона треугольника");
int b = Prompt("2 сторона треугольника");
int c = Prompt("3 сторона треугольника");



Checktriangle(Triangle(a, b, c));