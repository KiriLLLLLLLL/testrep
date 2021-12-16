int a = 1;
int b = 1;
int count = new Random().Next(5, 15);
int sum = 0;
Console.Write($"{a} ");
Console.Write($"{b} ");

for (int i = 0; i < count; i++)
{
    sum = a + b;
    Console.Write("{0} ", sum);
    a = b;
    b = sum;
}



