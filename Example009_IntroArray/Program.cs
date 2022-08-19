Console.Clear();

int findMaxNumber(int num1, int num2, int num3)  //Метод для поиска максимального числа
{
    int findMaxNumber = num1;
    if (num2 > findMaxNumber) findMaxNumber = num2;
    if (num3 > findMaxNumber) findMaxNumber = num3;
    return findMaxNumber;
}

int[] ArrayNumber = { 19, 29, 43, 64, 75, 26, 17, 81, 29 };
int N = ArrayNumber.Length; //длинна массива
int ArrayIndex = 0; //Начальный индекс массива
int findNumber = 17;


while (ArrayIndex < N)
{
    if (findNumber == ArrayNumber[ArrayIndex])
    {
        System.Console.WriteLine(ArrayIndex);
        break; //По условию задачи нужно найти первое совпавшее число, данный оператор прерывает выполнение
    }
    else
        ArrayIndex++;
}






/* while (N < ArrayIndex)
{
    if (ArrayNumber[ArrayIndex] == findNumber)
    {
        System.Console.WriteLine(ArrayNumber[ArrayIndex]);
    }
    ArrayIndex = ArrayIndex + 1;

}
 */