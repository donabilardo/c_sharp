//  Факториал


Console.Clear();

int Prompt (string message){
    System.Console.WriteLine(message);
    string  readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}


int Factorial (int number){
    if (number == 1 || number == 0) return 1;
    else return number * Factorial(number - 1);
}


int fak = Prompt("Введите число :");

System.Console.WriteLine($"Факториаил из {fak} будет равен: {Factorial(fak)}");