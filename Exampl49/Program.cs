//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Zadacha50()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);
    SolutionArray(array);
}

void FillArray(int [,] array, int startNumber = 0, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
    {
        array [i, j] = random.Next(startNumber, finishNumber);
    }
    }
}
void PrintArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array [i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void SolutionArray(int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
Console.WriteLine("Введите координаты:  ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > rows && b > columns)
Console.WriteLine("Такого числа нет");
else
{
int result = array[a, b];
  Console.Write($"Значение элемента: {result}");
}
}

Zadacha50();
