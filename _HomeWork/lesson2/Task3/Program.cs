//Задача 3: Напишите программу, 
//которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

int Get3Digit(int value)
{
    while (value > 1000)
    {
        value = value / 10;
    }
    int result = value % 10;
    return result;
}

int readValue = Prompt("Введите число: ");

if (readValue >= 99)
{
    int result = Get3Digit(readValue);
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Третье число отсутствует");
}