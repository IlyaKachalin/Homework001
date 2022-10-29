// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое число меньшее

Console.Clear();

void Compare(int x1, int x2)
{
    if (x1 > x2) Console.WriteLine("Первое число больше второго числа");
    else if (x2 > x1) Console.WriteLine("Второе число больше первого числа");
    else Console.WriteLine("Числа равны друг другу");
}

try
{
Console.Write("Введите первое число. x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число. x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Compare(x1, x2);
}

catch
{
    Console.WriteLine("Вводить нужно было целые числа");
}