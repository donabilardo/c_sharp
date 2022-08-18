//  Задача 4: Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

int week;
int readDayNumber = Prompt("Номер дня:"); //Считываем данные от пользователя

if (readDayNumber < 1 || readDayNumber > 7)
{ // Проверка на дни недели
    System.Console.WriteLine("Введите день недели от 1 до 7"); // сообщение об ошибке если число не верное
    return; //Выход из приложения, если число не верное
}

if (readDayNumber == 6 || readDayNumber == 7)
{
    System.Console.WriteLine("Выходной день");
    return;
} else {
    System.Console.WriteLine("рабочий день");
}
