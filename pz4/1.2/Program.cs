void Proiz(int n)
{
    int proz = 1;
    if (n == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        for (int i = 1; i <= n; i++)
        {
            proz = proz * i;
        }
        Console.WriteLine(proz);
    }
}

Console.WriteLine("Введите а");
Proiz(int.Parse(Console.ReadLine()));