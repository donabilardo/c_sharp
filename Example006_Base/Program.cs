int a = 1;
int b = 10;
int c = 6;
int d = 4;
int f = 18;

int min = a;

if (a < b) { min = b; }
if (min < c) { min = c; }
if (min < d) { min = d; }
if (min < f) { min = f; }
Console.WriteLine(min);
