using System;
using static System.Console;

Clear();
WriteLine("Введите число:");
int number = Convert.ToInt32(ReadLine());
//int sqr = number * number;
double sqr = Math.Pow(number, 2);
Write("Квадрат этого числа равен: ");
WriteLine(sqr);