void Kolvo(int n)
{
    int i = 0;
    if (n == 0)
    {
        Console.WriteLine("1");
    }
    else
    {
        while (n > 0)
        {
            i += 1;
            n = n / 10;
        }
        Console.WriteLine(i);
    }
}

Console.WriteLine("Введите а");
Kolvo(int.Parse(Console.ReadLine()));