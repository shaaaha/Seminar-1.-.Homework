//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа 
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int N1 = int.Parse(Console.ReadLine());
int amount = N1.ToString().Length;
int N = (N1 / 10) % 10;
if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine($"Вторая цифра числа {N1} - {N}");
}

