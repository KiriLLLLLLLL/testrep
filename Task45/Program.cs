int b1 = 32;
int b2 = 6;
int k1 = 3;
int k2 = 7;

if (k1 == k2)
{
    Console.WriteLine("Так ничего не получится!!!");
}
else
{
    double x = (double)(b2 - b1) / (k1 - k2);
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    Console.WriteLine("x = " + x);
    Console.WriteLine("y1 = " + y1);
    Console.WriteLine("y2 = " + y2);

    if (y1 == y2) Console.WriteLine("Пересечение!");

}
