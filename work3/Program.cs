// Захаров Иван 22-ИСП-2/2
//Даны  вещественные  положительные  числа a,b,c,d.
//Выяснить,  можно  ли прямоугольник со сторонами a,b уместить внутрипрямоугольника со сторо-нами c,d так,
//чтобы каждая из сторон одного прямоугольника была парал-лельна или перпендикулярна каждой стороне второго прямоугольника.

Console.WriteLine("Hello, World!");
try
{
    Console.WriteLine("Введите a");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите b");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите c");
    double c = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите d");
    double d = double.Parse(Console.ReadLine());
    double ab = a * b;
    double cd = c * d;
    if ((ab < cd) && (c > a) && (d > b)) Console.WriteLine("Можно");
    else Console.WriteLine("Нельзя");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}