//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4

Console.Clear();
int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput =System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

int N = Prompt("Введите число"); //Получаем число N
int count = 2; //Начало для диапазона чисел

while (count <= N){  //цикл продолжается пока выполняется условие
    if ( count%2 == 0){   //проверка на то, что в результате деления остаток равен 0
        Console.Write($"{count}, "); // если в результате деления остаток равен 0, выводим число
    }
    count = count +2; //Инкремент от начала диапазона чисел
}