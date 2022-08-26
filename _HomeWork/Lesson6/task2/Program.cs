//  Напишите программу, которая найдёт точку пересечения двух прямых
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//
//      значения b1, k1, b2 и k2 задаются пользователем.


Console.Clear();

double Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    double result = double.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}



double b1 = Prompt("Значение для b1");
double b2 = Prompt("Значение для b2");
double k1 = Prompt("Значение для k1");
double k2 = Prompt("Значение для b2");

double x = (b2 - b1) / (k1 - k2);
System.Console.WriteLine($"Точка пересечения: {x}; {k1*x+b1}");