﻿//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int counter = 1;
while (counter < N)
{
    Console.WriteLine(counter*counter*counter);
    counter++;
}
Console.WriteLine(counter*counter*counter);
