﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Clear();

try
{

Console.Write("Введите целое число ");
int x = Convert.ToInt32(Console.ReadLine());

if (x%2==0) Console.WriteLine ("Вы ввели четное число");
else if (x%2!=0) Console.WriteLine ("Вы ввели нечетное число");

}

catch
{
    Console.WriteLine("Убедитесь, что вы ввели целое число");
}