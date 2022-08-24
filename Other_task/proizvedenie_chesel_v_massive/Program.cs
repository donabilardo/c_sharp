//  Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, 
//  второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
//  [1 2 3 4 5] -> 5 8 3
//  [6 7 3 6] -> 36 21

Console.Clear();

int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}


int[] GetRandomArray(int len, int start, int end) // получаем массив
{
    int[] array = new int[len]; //обьявляем массив указанной длинны
    int i = 0; //счетчик индекса массива
    while (i < array.Length) // цикл работает пока индекс массива меньше длинны массива
    {
        array[i] = new Random().Next(start, end); //заполняем массив случайными числами от start до end
        i++; //увеличиваем счетчик на еденицу
    }
    return array; //возвращаем массив
}

void PrintArray(int[] array) //Печать массива
{
    for (int i = 0; i < array.Length; i++) // цикл работает пока индекс массива меньше длинны массива
    {
        System.Console.WriteLine($"Индекс = {i} | Значение = {array[i]}"); // выводим за каждую итерацию по 1 элементу массива
    }
}


int[] MultiPairArray (int[] array){
    int[] result = new int[(array.Length /2)+ (array.Length %2)];
    
}


int[] RandomArray = GetRandomArray(100,1,100);
PrintArray(RandomArray);