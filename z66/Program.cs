Console.Clear();

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int sum = 0;
SumValue(m,n);
Console.WriteLine(sum);

void SumValue(int m, int max)
{
    if (m > max) return;
    sum += m;
    SumValue(m + 1, max);
}

