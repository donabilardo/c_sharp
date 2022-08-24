//  Задайте одномерный массив из 123 случайных чисел.
//  Найдите количество элементов массива, 
//  значения которых лежат в отрезке [10,99].
//  Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//  [5, 18, 123, 6, 2] -> 1
//  [1, 2, 3, 6, 2] -> 0
//  [10, 11, 12, 13, 14] -> 5


int[] GetArray(int len, int start, int end)
{
    int[] array = new int[len];

    for (int i =0; i < array.Length; i++){
        array[i] = new Random().Next(start,end);
    }
    return array;
}


int FintTOArray(int[] Narray)
{ // метод для поиска количества элементов в заданном числовом отрезке

    int[] array = new int[Narray.Length]; // массив

    int count = 0; // счётчик элементов

    for (int i = 0; i < Narray.Length; i++)
    {
        if (i >= 10 && i <= 99)
        {
            count = count +1;
        }
    }
    return count;
} 



int[] PrintArray (int[]array){
    for (int i =0; i < array.Length; i++){
        System.Console.WriteLine($"Индекс {i} | Значение {array[i]}");
    }
    return array;
}


int[] NewArr = GetArray(123, 1, 999);

//PrintArray(NewArr);  // вывод в консоль массива

System.Console.WriteLine($"Количество элементов между 10 и 99 будет : {FintTOArray(NewArr)}");





//  Задайте одномерный массив из 123 случайных чисел.
