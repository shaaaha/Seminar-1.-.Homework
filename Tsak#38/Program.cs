//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
    {
        max = numbers[z];
    }
    else if (numbers[z] < min)
    {
       min =  numbers[z];
    }
}

Console.WriteLine($"Минимальный элемент массива = {min}");
Console.WriteLine($"Максимальный элемент массива = {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max-min}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,999);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}