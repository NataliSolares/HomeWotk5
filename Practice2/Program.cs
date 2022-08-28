Console.WriteLine("Введите количествво шагов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int k = 0;
int[] x = { 1, 2, 3, 4, 5 };
for (int i = 4; i > 0; i--)
{
    k = k + (n / x[i]);
    k = n % x[i] + 1;
    break;
}
Console.WriteLine(k);