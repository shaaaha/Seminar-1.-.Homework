//Задача 19: Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string Num = Console.ReadLine();
int N = Num.Length;
if (N == 5)
    {
        if (Num[0] == Num[4] && Num[1] == Num[3])
        {
            Console.WriteLine($"Число {Num} - является палиндромом");
        } 
        else
        {
            Console.WriteLine($"Число {Num} - не является палиндромом");
        }
    }
else
    {
        Console.WriteLine($"Вы ввели не пятизначное число");
    }
