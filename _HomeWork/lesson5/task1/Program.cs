//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
//
//  [345, 897, 568, 234] -> 2



Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}

int[] GetArray(int GetArrayLength)  // метод получения массива
{
    int[] RandomArray = new int[GetArrayLength];
    for (int i = 0; i < GetArrayLength; i++)
    {
        RandomArray[i] = new Random().Next(100, 999); //диапазон чисел, по условию число должно быть 3-х значным
    }
    return RandomArray;
}


void PrintArray (int[] array){ //вывод значений массива
    for (int i = 0; i < array.Length; i++){
        System.Console.WriteLine($"Индекс ({i}) - Значение = {array[i]}");
    }
    System.Console.WriteLine("______________________________");
    
}


int CheckArray (int[] array){ // проверка значений массива на чётность
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0) {
            result = result + 1;
        }
    }
    return result;
}



int LenArr = Prompt("Длина массива: "); //запрашиваем длинну массива
Console.Clear();
int[] newArr = GetArray(LenArr); // метод генерации массива
PrintArray(newArr); // метод печати массива
System.Console.WriteLine($"Количество чётных элементов: {CheckArray(newArr)}"); // вывод результат для  решения задачи
System.Console.WriteLine(String.Empty);