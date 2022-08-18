//  Напишите программу, которая принимает на вход число (N)
//   и выдаёт таблицу кубов чисел от 1 до N.


Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


void TableCube(int Number)
{
    for (int i = 1; i <= Number; i++)
    {
        System.Console.Write($"{i * i * i} ,");
    }
}

int readNumber = Prompt("Введите число :");
System.Console.WriteLine($"Таблица кубов от 1 до {readNumber}");
TableCube(readNumber);