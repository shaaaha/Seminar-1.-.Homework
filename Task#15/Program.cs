//Задача 13: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет,
//является ли этот день выходным.


Console.Clear();
Console.Write("Введите : ");
int N = int.Parse(Console.ReadLine());

if ((N > 7) || (N <1))
    {
        Console.WriteLine ("Введенное Вами число не соответствует дню недели");
    }
else if ((N < 5))
    {
        Console.WriteLine($"{N} - будний день");
    }
else
    {
        Console.WriteLine($"{N} - выходной день");
    }