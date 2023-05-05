/*Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.*/

Console.WriteLine("enter lines");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("enter columns");
int columns = int.Parse(Console.ReadLine());

double[,] array = new double[lines, columns];

FillArray(array);
PrintArray(array);

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
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
