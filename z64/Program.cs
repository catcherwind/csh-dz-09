Console.Clear();

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (m % 2 == 0) PrintValue(m,n);
else PrintValue(m+1,n);

void PrintValue(int m, int max)
{
    if (m > max) return;
    Console.Write($" {m}");
    PrintValue(m + 2, max);
}

