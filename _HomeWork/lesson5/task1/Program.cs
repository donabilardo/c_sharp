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

int[] GetArray(int GetArrayLength)
{
    int[] RandomArray = new int[GetArrayLength];
    for (int i = 0; i < GetArrayLength; i++)
    {
        RandomArray[i] = new Random().Next(100, 999);
    }
    return RandomArray;
}


void PrintArray (int[] array){
    for (int i = 0; i < array.Length; i++){
        System.Console.WriteLine($"Индекс ({i}) - Значение = {array[i]}");
    }
    System.Console.WriteLine("______________________________");
    
}


int CheckArray (int[] array){
    int result = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0) {
            result = result + 1;
        }
    }
    return result;
}



int LenArr = Prompt("Длина массива: ");
Console.Clear();
int[] newArr = GetArray(LenArr);
PrintArray(newArr);
System.Console.WriteLine($"Количество чётных элементов: {CheckArray(newArr)}");