int a = new Random().Next(10, 50);
int b = new Random().Next(10, 50);
int c = new Random().Next(10, 50);

Console.Write($"a = {a}, b = {b}, c = {c}");
Console.WriteLine();
if (a<b+c && b< a+c && c< b+a)
{
    Console.WriteLine("Треугольник");

}
else Console.WriteLine("Нет!!!");
