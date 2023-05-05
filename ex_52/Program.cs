/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

Console.WriteLine("enter lines");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("enter columns");
int columns = int.Parse(Console.ReadLine());

int [,] array = new int [lines, columns];

FillArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = (average + array[i, j]);
    }
    average = average / columns;
    Console.Write(average + "; ");
}
Console.WriteLine();

PrintArray(array);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
        Console.WriteLine("");
    }
}