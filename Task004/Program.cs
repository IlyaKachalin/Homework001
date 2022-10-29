// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear();

string Array(int x)
{
    string array = "0";
    for (int i = 1; i <= x; i++)
    {
        if (i%2==0)
        {array = array + Convert.ToString(i);}
    }
    return array;
}

try
{

    Console.Write("Введите целое число ");
    int N = Convert.ToInt32(Console.ReadLine());

    string rez = Array(N);
    Console.WriteLine(rez);

}

catch
{
    Console.WriteLine("Убедитесь, что вы ввели целое число");
}