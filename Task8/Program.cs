Console.WriteLine("Введите отрицательное целое число:");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число:");

int b = Convert.ToInt32(Console.ReadLine());

while (a < b)
{
    Console.Write(a);
    a++;
}