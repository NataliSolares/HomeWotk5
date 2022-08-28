Console.WriteLine("Здать длинну прямоугольника");
long n = long.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Здать ширину прямоугольника");
long m = long.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Здать сторону квадрата");
long a = long.Parse(Console.ReadLine() ?? "0");

// long sum = ((m + a - 1)/a) * ((n + a - 1) / a);

if (n % a == 0)
{
    n = n / a;
}
else
{
    n = ((n / a) + 1);
}
if (m % a == 0)
{
    m = m / a;
}
else
{
    m = ((m / a) + 1);
}

 Console.WriteLine($"Количеств плиток: {n*m}");