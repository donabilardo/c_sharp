//double a = new Random().Next(1, 10);
Console.WriteLine("Введите первое число: ");
double numberA = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double numberB = Int32.Parse(Console.ReadLine());
double result = numberA / numberB;
Console.Write("Результат деления: ");
Console.WriteLine(result);