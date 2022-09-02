Console.WriteLine("Введите чило A:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите чило B:");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine($"{a} больше {b}");
}
else
{
    Console.WriteLine($"{b} больше {a}");
}
