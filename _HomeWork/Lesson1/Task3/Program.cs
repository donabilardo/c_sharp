//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> Четное

Console.Clear();
int Prompt (string message) {
    string ReadInt = System.Console.ReadLine(); //считываем значение
    int result = int.Parse(ReadInt); //преобразуем в число
    return result; //возвращает результат
}

System.Console.WriteLine("Программа проверяет является ли введенное число четным");
System.Console.WriteLine("");
int Num = Prompt("Введите число: "); 

System.Console.WriteLine("");

if (Num%2 == 0){
    System.Console.WriteLine("Четное");
}else{
    System.Console.WriteLine("Не четное");
}