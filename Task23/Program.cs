
int x1 = 23, x2 = 65,
    y1 = 93, y2 = -54,
    z1 = 564, z2 = -98;

int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;

double distance2d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
double distance3d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2));

Console.WriteLine("Расстояние в 2d: " + distance2d);
Console.WriteLine("Расстояние в 3d: " + distance3d);