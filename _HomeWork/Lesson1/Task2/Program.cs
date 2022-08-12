//      Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//      2, 3, 7 -> 7
//      44 5 78 -> 78
//      22 3 9 -> 22

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadStroka = System.Console.ReadLine();
    int resultat = int.Parse(ReadStroka);
    return resultat;
};


System.Console.WriteLine("Необходимо ввести 3 числа, программа должны выбрать максимальное");
int number1 = Prompt("Введите первое число");
int number2 = Prompt("Введите второе число");
int number3 = Prompt("Введите третье число");

int MaxNumber = number1;
if (number2 > MaxNumber)
{
    MaxNumber = number2;
}
if (number3 > MaxNumber)
{
    MaxNumber = number3;
}


System.Console.WriteLine("_______________________");
System.Console.WriteLine($"Максимальное число : {MaxNumber}");