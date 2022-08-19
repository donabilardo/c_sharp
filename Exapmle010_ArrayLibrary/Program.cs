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

int indexOf(int[] findCollection, int find)
{
    int lengthFindCollection = findCollection.Length;
    int indexFindeCollection = 0;
    int positionFindCollection = -1;
    while (indexFindeCollection < lengthFindCollection)
    {
        if (findCollection[indexFindeCollection] == find)
        {
            positionFindCollection = indexFindeCollection;
            break;
        }
        indexFindeCollection++;
    }
    return positionFindCollection;
}

int[] array = new int[10];

newArray(array);
prinTnewArray(array);
System.Console.WriteLine("------------------------");

int pos = indexOf(array, 4);
System.Console.WriteLine(pos);