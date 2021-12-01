
Console.WriteLine("Введите координаты х и у, ноль вводить нельзя: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (x != 0 & y != 0)
{
    if (x > 0 & y > 0) Console.WriteLine("Точка во 2й четверти");
    if (x < 0 & y > 0) Console.WriteLine("Точка в 1й четверти");
    if (x > 0 & y < 0) Console.WriteLine("Точка в 4й четверти");
    if (x < 0 & y < 0) Console.WriteLine("Точка в 3й четверти");
}
else Console.WriteLine("Ноль вводить нельзя!!!");