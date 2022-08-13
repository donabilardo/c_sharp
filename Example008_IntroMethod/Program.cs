Console.Clear();
int a1 = 15;
int b1 = 9;
int c1 = 7;
int a2 = 44;
int b2 = 24;
int c2 = 31;
int a3 = 112;
int b3 = 21;
int c3 = 30;

int findMaxNumber(int num1, int num2, int num3)
{
    int findMaxNumber = num1;
    if (num2 > findMaxNumber) findMaxNumber = num2;
    if (num3 > findMaxNumber) findMaxNumber = num3;
    return findMaxNumber;
}

/* int Max1;
int Max2;
int Max3;

Max1 = findMaxNumber(a1, b1, c1);
Max2 = findMaxNumber(a2, b2, c2);
Max3 = findMaxNumber(a3, b3, c3);

int finaleMax = findMaxNumber(Max1, Max2, Max3);

System.Console.WriteLine(finaleMax); */

int maxNumberOut = findMaxNumber(findMaxNumber(a1, b1, c1), findMaxNumber(a2, b2, c2), findMaxNumber(a3, b3, c3));
System.Console.WriteLine($"Максимальное число: {maxNumberOut}");