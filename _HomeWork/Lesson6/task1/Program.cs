//  Пользователь вводит с клавиатуры M чисел. 
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 3

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadValue = System.Console.ReadLine();
    int result = int.Parse(ReadValue);
    return result;
}

int M = Prompt("Введите количество цифр. для подсчёта"); // количество чисел которые нужноо ввести пользователю

System.Console.WriteLine("Введите поочередно 10 цифр");

int CountDigit()
{
    int i = 1; // сколько осталось ввести цифр
    int count = 0; // сколько введенных цифр больше 0
    while (i <= M)
    {
        int InputDigit = Prompt($"Введите {i} число"); // получаем построчно числа
        i++;
        if (InputDigit > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.Clear();
System.Console.WriteLine($"Пользователь ввел {CountDigit()} чисел больше 0"); //вывод количества введеных чисел, которые больше 0