//Написать программу показывающие первые N чисел,
//для которых каждое следующее равно сумме двух предыдущих.
//Первые два элемента последовательности задаются пользователем



int RandomFib (int num1, int num2, int n)
{
    if (n == 1) return num1;
    if (n == 2) return num2;
    return RandomFib(num1, num2, n - 1) + RandomFib(num1, num2, n - 2);
}
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(RandomFib (4, 5, i));
}
