// Найти сумму элементов от M до N, N и M заданы

int SummRecurtion(int n, int m)
{
    if (m ==n) return m;
    if (m > n)
    {

        return SummRecurtion(n + 1, m) + n;

    }
    else
    {
        return SummRecurtion(n, m + 1) + m;

    }

}

int a = SummRecurtion(5, 5);
Console.WriteLine(a);