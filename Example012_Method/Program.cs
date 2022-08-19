//  Дан текст. В тексте нужно все пробелы заменить черточками,
//  маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//  маленькими “с”.

Console.Clear();

string text = "— Я думаю, — сказал князь, улыбаясь, — что, " +
"ежели бы вас послали вместо нашего милого " +
"Винценгероде, вы бы взяли приступом согласие " +
"прусского короля. Вы так красноречивы. Выдадите мне чаю?";


string convertText(string text, char oldValue, char newValue)
{

    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {

        if (text[i] == oldValue)
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }

    }

    return result;
}


//string newText = convertText(text, 'к', 'К');
//System.Console.WriteLine(newText);

int[] arr = { 1, 2, 7, 5, 6, 8, 3, 4, 8 };

void printArray(int[] array)
{
    int length = array.Length;

    for (int i=0; i < length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

printArray(arr);