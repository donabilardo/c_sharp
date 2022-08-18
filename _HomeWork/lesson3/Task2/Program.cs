//  Напишите программу, которая принимает на вход 
//  координаты двух точек 
//  и находит расстояние между ними в 3D пространстве.



Console.Clear();

const int X = 0;
const int Y = 1;
const int Z = 2;


int[] inputCoord(string message)
{
    int[] numCoord = new int[3];
    for (int i = 0; i < numCoord.Length; i++)
    {
        System.Console.WriteLine($"{message} {i}-я: ");
        string value = System.Console.ReadLine();
        numCoord[i] = int.Parse(value);
    }
    return numCoord;
}


double Power2FromPoint(double c1, double c2){
    double distanceCoords = c1 - c2;
    return distanceCoords * distanceCoords;
}

double LineLong (int[] point1, int[] point2){
    double LongLine = Math.Sqrt(Power2FromPoint(point1[X], point2[X]) + Power2FromPoint(point1[Y], point2[Y]) + Power2FromPoint(point1[Z], point2[Z] ));
    return LongLine;
}




int[] point1 = inputCoord("Координаты первой точки: ");
int[] point2 = inputCoord("Координаты второй точки: ");
System.Console.WriteLine($"Расстояние между точками {LineLong(point1, point2)}");