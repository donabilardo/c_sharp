Console.Clear();



// войд метод который не возвращщает никаких данных
void Method1()
{
    System.Console.WriteLine("Author...");
}

//Method1();


//войд метод кторый принимает значение
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

//Method2(msg: "Ntrcn", count: 5);
//Method2("Ntrcn", 4);



//Метод который возвращает значение
int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//System.Console.WriteLine(year);


//Метод который принимает и возвращает значение
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "NTRCN");
//System.Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
            System.Console.WriteLine(String.Empty);
}