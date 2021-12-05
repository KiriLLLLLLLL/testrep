bool TrueFalse(bool x, bool y)
{
    return !(x || y) == (!x && !y);
}

bool x = true;
bool y = true;
bool result = TrueFalse(x, y);
Console.WriteLine("Вариант 1 = " + result);

bool x1 = true;
bool y1 = false;
result = result && TrueFalse(x1, y1);
Console.WriteLine("Вариант 2 = " + result);

bool x2 = false;
bool y2 = true;
result = result && TrueFalse(x2, y2);
Console.WriteLine("Вариант 3 = " + result);

bool x3 = false;
bool y3 = false;
result = result && TrueFalse(x3, y3);
Console.WriteLine("Вариант 4 = " + result);

if (result) Console.WriteLine("Утверждение истинно!");