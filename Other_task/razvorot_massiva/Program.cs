//  Напишите программу, которая перевернёт одномерный массив 
//  (последний элемент будет на первом месте, 
//  а первый - на последнем и т.д.)
//  [1 2 3 4 5] -> [5 4 3 2 1]
//  [6 7 3 6] -> [6 3 7 6]


Console.Clear();


int[] matrix = new int[] { 1, 3, 5, 4, 8, 2, 1, 5, 9 };

int[] ReverArray(int[] matrix)
{

    for (int i = 0; i < matrix.Length; i++)
    {
        int temp = matrix[i];
        matrix[i] = matrix[matrix.Length / 2 - 1 - i];
        matrix[matrix.Length - 1 - i] = temp;
    }
    return matrix;
}

void PrintArray(int[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        System.Console.WriteLine($"index {i} {matrix[i]}");
    }
}


PrintArray(matrix);
ReverArray(matrix);
System.Console.WriteLine("REVERT");
PrintArray(matrix);