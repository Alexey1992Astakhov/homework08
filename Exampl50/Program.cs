// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(4,8);
    int columns = random.Next(4,8);
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);
}
Zadacha47();

void FillArray(double[,] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}
void PrintArray(double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + "\t");
      }
      Console.WriteLine();
  }
}