Console.WriteLine("Введите чило A:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чило B:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чило C:");
int c = Convert.ToInt32(Console.ReadLine());

int maxnum = a;

if (maxnum < b)
{
    maxnum = b;
}
if (maxnum < c)
{
    maxnum = c;
}
Console.WriteLine(maxnum);