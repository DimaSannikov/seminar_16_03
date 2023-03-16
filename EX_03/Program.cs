// Задайте двумерный массив. Найдите элементы, у которых оба индекса
// чётные, и замените эти элементы на их квадраты.

void PrintArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
        }
    }
}

void FindSquareEvenElements(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            if (rows % 2 == 0 && columns % 2 == 0)
            {
                double square = matrix[rows, columns];
                matrix[rows, columns] = Math.Pow(square, 2);
            }
        }
    }
}

Console.Write("Количество строк массива ");
int countRows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int countColumns = int.Parse(Console.ReadLine());

double[,] matrix = new double[countRows, countColumns];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindSquareEvenElements(matrix);
PrintArray(matrix);