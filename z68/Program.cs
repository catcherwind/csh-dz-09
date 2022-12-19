Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"НОД:{SearchNod(n,m)}");

int SearchNod(int n, int m)
{
    if(m == 0)
        return n;
    if(n > m)
        return SearchNod(m, n % m);
    else
        return SearchNod(n, m % n);
}
