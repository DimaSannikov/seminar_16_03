// Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами.

void PrintArray(double[,] matrix)
{
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int rows = 0; rows < rowsLen; rows++)
    {
        for (int columns = 0; columns < columnsLen; columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int rows = 0; rows < rowsLen; rows++)
    {
        for (int columns = 0; columns < columnsLen; columns++)
        {
            matrix[rows, columns] = Math.Round(new Random().NextDouble() * 10, 3);
        }
    }
}

Console.Write("Количество строк массива ");
int countRows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int countColumns = int.Parse(Console.ReadLine());

double[,] matrix = new double[countRows, countColumns];
// PrintArray(matrix);
FillArray(matrix);
// Console.WriteLine();
PrintArray(matrix);