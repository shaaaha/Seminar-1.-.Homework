//Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//5 -> [1, 2, 5, 7, 19]
//3 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите длину массива: ");
int lenArray = int.Parse(Console.ReadLine());
int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}