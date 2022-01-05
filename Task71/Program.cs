// Найти сумму цифр числа

int Check(int num)
{
    if (num < 0) return SumElement (-num);
    return SumElement (num);
}


int SumElement (int num)
{
    if (num == 0) return 0;

    return num % 10 + SumElement (num / 10);
}

int a = Check (1011);
Console.WriteLine(a);