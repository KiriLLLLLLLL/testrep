int a = new Random().Next(90,12346);
Console.WriteLine(a);

int b = a / 100;

if (b == 0) Console.WriteLine("ЕЕ НЕТ!!!!");
else Console.WriteLine(b % 10);