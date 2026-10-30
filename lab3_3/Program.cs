Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());

Console.Write("Введите количество членов ряда n: ");
int n = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 1)
        sum += Math.Sin(i * x) / i;
    else
        sum -= Math.Sin(i * x) / i;
}

Console.WriteLine("Сумма ряда = " + sum);