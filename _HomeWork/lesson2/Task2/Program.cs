// Задача 2: Напишите программу, 
// которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

Console.Clear();

int remove2digit(int value)
{
    int number1 = value % 10; //последнее число
    int number2 = value / 10 % 10; //второе число
    int number3 = value / 100 % 10; //первое число
    int result = number3 * 10 + number1;
    return result;
}

int value = new Random().Next(100, 1000); //генерируем псевдослучайное число
System.Console.WriteLine($"Сгенерированное число : {value}"); //выводим это число пользователю
System.Console.WriteLine("------------------");




System.Console.WriteLine(remove2digit(value));