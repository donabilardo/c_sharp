Console.Clear();

// Если позиция курсора не вмещается в консоль, то вываливается в ошибку
//int xb = 1, yb = 30; //Первое значение в ширину, второе значение строки
//int xc = 80, yc = 30;
//Console.SetCursorPosition(xa, ya);


int xa = 40; //от левого 
int ya = 1; //сверху

int xb = 1; //от левого 
int yb = 30; //сверху

int xc = 80; //от левого 
int yc = 30; //сверху

int x = xa, y = xb;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);

    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;
}


