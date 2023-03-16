// Задайте двумерный массив. Найдите сумму элементов, находящихся на
// главной диагонали (с индексами (0,0); (1;1) и т.д.

void PrintArray(int[,] matrix)
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

void FillArray(int[,] matrix)
{
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int rows = 0; rows < rowsLen; rows++)
    {
        for (int columns = 0; columns < columnsLen; columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
        }
    }
}

int FindMainDiagonalElements(int[,] matrix)
{
    int sum = 0;
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int rows = 0; rows < rowsLen; rows++)
    {
        for (int columns = 0; columns < columnsLen; columns++)
        {
            if (rows == columns)
            {
                sum = sum + matrix[rows, columns];
            }
        }
    }
    return sum;
}

Console.Write("Количество строк массива ");
int countRows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int countColumns = int.Parse(Console.ReadLine());

int[,] matrix = new int[countRows, countColumns];
// PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
int sum = FindMainDiagonalElements(matrix);
Console.WriteLine(sum);