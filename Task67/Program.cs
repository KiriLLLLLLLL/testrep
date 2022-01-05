// Показать натуральные числа от 1 до N, N задано

int num = 1;
int num1 = 10;

static void NaturalNumbers(int num, int num1)
{
    Console.Write(" " + num);
    if (num < num1) NaturalNumbers(num + 1, num1);
}

NaturalNumbers(num, num1);