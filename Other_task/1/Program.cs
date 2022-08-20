Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string ReadStroka = System.Console.ReadLine();
    int resultat = int.Parse(ReadStroka);
    return resultat;
};

/* int a = Prompt("Введите число: ");
int b = a % 100;

System.Console.WriteLine(b); */

int getRandomDigit(int start, int end) //Метод получения случайного 2-х значного числа и поиска максимальной цифры
{
    int randomDigit = new Random().Next(start, end); //генерируем случайное число из диапазано заданного из входящих значений метода
    int numStart = randomDigit / 10; //Поиск первого числа
    int numEnd = randomDigit % 10; // Поиск второго числа
                                   //System.Console.WriteLine(numStart);
                                   //System.Console.WriteLine(numEnd);
    int numMax;
    if (numStart == numEnd || numStart < 0 || numEnd < 0)
    {
        numMax = -1;
        System.Console.WriteLine("Числа равны или они меньше 0");
        return numMax;
    }

    if (numStart > numEnd)
    {
        numMax = numStart;
        System.Console.Write($"Случайное число: " + randomDigit);
        System.Console.WriteLine(String.Empty);
        System.Console.Write($"Максимальное число :" + numMax);
        return numMax;
    }
    else
    {
        numMax = numEnd;
        System.Console.Write($"Случайное число: " + randomDigit);
        System.Console.WriteLine(String.Empty);
        System.Console.Write($"Максимальное число :" + numMax);
    }

    return randomDigit;
    return numStart;
}



getRandomDigit(10, 99);