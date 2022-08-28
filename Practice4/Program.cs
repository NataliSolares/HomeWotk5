Console.WriteLine("Введите число: ");
string n = Console.ReadLine();
int count = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] == '4' || n[i] == '7')
        count++;
}
if (count == 4 || count == 7)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}