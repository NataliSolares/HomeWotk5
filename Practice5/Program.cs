int k = 3, n = 17, w = 4;
int sum = 0;
for (int i = 1; i <= w; i++)
{
    sum += k * i;
}
if (sum > n)
{
    Console.WriteLine(sum - n);
}
else
{
    Console.WriteLine(0);
}