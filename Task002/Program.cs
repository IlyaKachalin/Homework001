// Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел

Console.Clear();

void Compare(int x1, int x2, int x3)
{
    if (x1 > x2 && x1>x3) Console.WriteLine($"Значение первого числа максимальное и равно {x1}");
    else if (x2 > x1 && x2>x3) Console.WriteLine($"Значение второго числа максимальное и равно {x2}");
    else if (x3 > x1 && x3>x2) Console.WriteLine($"Значение третьего числа максимальное и равно {x3}");
    else if (x1 == x2 && x2>x3) Console.WriteLine($"Значения первых двух чисел максимальны и равны {x1}");
    else if (x3 == x1 && x3>x2) Console.WriteLine($"Значения третьего и первого чисел максимальны и равны {x3}");
    else if (x3 == x2 && x3>x1) Console.WriteLine($"Значения третьего и второго чисел максимальны и равны {x2}");
    else Console.WriteLine("Числа равны друг другу");
}

try
{
Console.Write("Введите первое число. x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число. x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число. x3 = ");
int x3 = Convert.ToInt32(Console.ReadLine());
Compare(x1, x2, x3);
}

catch
{
    Console.WriteLine("Вводить нужно было целые числа");
}