Console.Clear();

/* 
int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();//читаем строку
    bool numeric = readInput.All(char.IsDigit); // Проверяем на число или строку
        if (numeric == false)
            {
                System.Console.WriteLine("По условию задачи необходимо ввести число");
            }
        else
            {
                int result = int.Parse(ReadInput); //приводим к числу
                int readInputLenght = readInput.Length; //узнаем длинну строки
                    if (readInputLenght > 3 && readInputLenght < 3){
                       System.Console.WriteLine("По условию задачи число дол"); 
                    }
                return result; //возвращаем результат
            }

}
 */

/* int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput = System.Console.ReadLine();
    bool checkReadInput = ReadInput.All(char.IsDigit);
    if (checkReadInput == false)
    {
        System.Console.WriteLine("По условию задачи необходимо ввести число");
    }
    else
    {
        int result = int.Parse(ReadInput); //приводим к числу
        return result; //возвращаем результат
    }

}
 */




int Prompt(string message)
{
    System.Console.WriteLine(message); //Выводим приглашение ко вводу
    string ReadInput =System.Console.ReadLine();
    int result = int.Parse(ReadInput); //приводим к числу
    return result; //возвращаем результат
}



   while (num2 == 0)
             {
                 Console.WriteLine("Enter a non-zero divisor: ");
                 num2 = Convert.ToInt32(Console.ReadLine());
             }
             Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
             break;
     }