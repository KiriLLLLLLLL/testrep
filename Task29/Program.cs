int num = 2323;
int res = 0;

while (num > 0)
{
    res = res + (num % 10);
    num = num / 10;
}
Console.WriteLine(res);