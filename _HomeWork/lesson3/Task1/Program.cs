//Задача 1
//  Напишите программу, которая принимает на вход пятизначное число 
//  и проверяет, является ли оно палиндромом.
//  https://ru.wikipedia.org/wiki/%D0%9F%D0%B0%D0%BB%D0%B8%D0%BD%D0%B4%D1%80%D0%BE%D0%BC

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


//Переворачивает строку
int reverseNumber(int number)
{
    int res = 0;
    while (number > 0)
    {
        int temp = number % 10;
        number = number / 10;
        res = res * 10 + temp;
    }
    return res;
}




bool checkPalindrome (int value1, int value2){
    if (value1 == value2){
        return true;
    } return false;
}



int num1 = Prompt("Введите число");
int num2 = reverseNumber(num1);
bool isPalindrome = checkPalindrome(num1,num2);
if (isPalindrome){
    System.Console.WriteLine($"{num1} является палиндромом");
} else {
    System.Console.WriteLine($"{num1} НЕ является палиндромом");
}


//PS Недопонял