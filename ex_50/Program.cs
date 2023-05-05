/*Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или 
же указание, что такого элемента нет.*/

Console.WriteLine("enter lines");
int lines = int.Parse(Console.ReadLine());
Console.WriteLine("enter columns");
int columns = int.Parse(Console.ReadLine());

int [,] array = new int [4, 4];

FillArray(array);

if (columns > array.GetLength(0) || lines > array.GetLength(1))
{
    Console.WriteLine("element doesn't exists");
}
else
{
    Console.WriteLine($"element of line {lines} and column {columns} is {array[columns-1,lines-1]}");
}

PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
                Console.WriteLine(""); 
    }
}
