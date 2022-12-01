void Kolvo(int n)
{
    int[] a = new int[n];
    for (int i = 0; i < n;i++)
    {
        a[i] = new Random().Next(0, 2);
    }
    Console.WriteLine("[{0}]", string.Join(", ", a));
}

Console.WriteLine("Введите а");
Kolvo(int.Parse(Console.ReadLine()));