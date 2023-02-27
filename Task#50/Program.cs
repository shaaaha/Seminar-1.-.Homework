/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> по такому индексу нет элемента.
*/

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
double[,] numbers = new double [rows, columns];
FillArray(numbers);
PrintArray(numbers);

if(rows<numbers.GetLength(0) && columns<numbers.GetLength(1))
Console.WriteLine(numbers[rows,columns]);
else Console.WriteLine($"{rows}{columns} - такого значения в массиве нет");

void FillArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,9);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}