int a = 1;
int n = 10;

while (a <= n)
{
    double square = Math.Pow(a, 2);
    Console.WriteLine($"{a} * {a} = " + square);
    a++;
}
