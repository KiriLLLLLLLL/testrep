int a = new Random().Next(10, 99);

int b = a / 10;
int c = a % 10;
Console.WriteLine(a);
if (b > c) Console.WriteLine(b);
if (c > b) Console.WriteLine(c);
if (b == c) Console.WriteLine("Они равны");
