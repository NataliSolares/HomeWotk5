Console.Clear();

int y = int.Parse(Console.ReadLine() ?? "0");
int a, b, c, d;
for (int z = y + 1; ; z++)
{
    a = z / 1000;
    b = z / 100 % 10;
    c = z / 10 % 10;
    d = z % 10;
    if (a != b && b != c && c != d && a != c && a != d && b != d)
    {
        Console.Write(z);
        break;
    }
}