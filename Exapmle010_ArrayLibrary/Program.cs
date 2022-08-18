Console.Clear();

void newArray(int[] collection)
{
    int lenghtNewArray = collection.Length; //длинна массива
    int indexNewArray = 0; //начальный элемент массива

    while (indexNewArray < lenghtNewArray) // цикл продолжается пока индекс массива меньше чем длинна массива
    {

        collection[indexNewArray] = new Random().Next(1, 10); //случайное число для индекса
        indexNewArray++; // инкремент
    }
}

void prinTnewArray(int[] printCollection)
{
    int lenghtPrintCollection = printCollection.Length; //вычислить длинну массива
    int indexPrintCollection = 0; //начальный индекс
    while (indexPrintCollection < lenghtPrintCollection) //пока индекс массива меньше длинны массива
    {
        System.Console.WriteLine(printCollection[indexPrintCollection]); //вывод в консоль индекса массива
        indexPrintCollection++; //прибавляем 1 после каждой итерации
    }

}

int findIndexArray(int[] findCollection)
{
    int indexFindCollection = 0;
    int lenghtFindIndexCollection = findCollection.Length;
    while (indexFindCollection < lenghtFindIndexCollection)
    {
        System.Console.WriteLine("+");
    }

}

int[] array = new int[10];

newArray(array);
prinTnewArray(array);
System.Console.WriteLine("------------------------");


