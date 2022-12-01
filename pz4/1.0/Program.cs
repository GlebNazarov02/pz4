void Summa(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    Console.WriteLine(suma);
}

Console.WriteLine("Введите а");
Summa(int.Parse(Console.ReadLine()));