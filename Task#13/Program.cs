//Задача 13: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа 
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int count = number;
int result = 0;

if (number < 100)
    {
        Console.WriteLine ("Третьей цифры в введенном Вами числе - нет");
    }
else
    {
    while (number >= 1000)
    {
        number = number / 10;
    }
    result = number % 10;
    Console.WriteLine(result);
}