using System;


Console.WriteLine("New programm! Hello! Let's start!");
Console.WriteLine("Введите три числа");
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int sum = first + second + third;
int mult = first * second * third;

Console.WriteLine($"Сумма этих чисел равна {sum}");
Console.Write($"Произведение этих чисел равно {mult}");
