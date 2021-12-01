Console.WriteLine("Введите 5ти значное число: ");
int a = Convert.ToInt32(Console.ReadLine());


if(a >= 9999 && a <= 100000)
{
    int b = a / 10000;
    Console.WriteLine(b);
    a = a % 10000;
    int c = a / 1000;
    Console.WriteLine(c);
    a = a % 1000;
    a = a % 100;
    int e = a / 10;
    Console.WriteLine(e);
    a = a % 10;

                if (b == a && c == e)
                {
                    Console.WriteLine("Это число палиндром");
                }
                    else
                    Console.WriteLine("Это число не палиндром");
}
else Console.WriteLine("Вы ввели что-то не то!!!");
