//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(4,4);
    int columns = random.Next(4,4);
    int [,] array = new int [rows, columns];
    FillArray(array);
    PrintArray(array);
    SumDiag(array);
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
void SumDiag(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            int srAr = 0;
            for (int j = 0; j < columns; j++)
            {
                {
                    srAr += array[j, i];
                }  
            }
            Console.WriteLine($"Средее арифметическое элементов столбца = {(float)srAr/4}");  
        }
    }
       
Zadacha52();
