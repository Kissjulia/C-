Console.WriteLine("Введите чило");
int num = Convert.ToInt32(Console.ReadLine());

if (99 < num)
{
    while (num > 999)
    {
        num /= 10;
    }
    num %= 10;
    Console.WriteLine(num);
}
else
    Console.WriteLine("Третьей цифры нет");