// Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void FindArithmeticMeanInColumns(int[,] matrix)
{
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int columns = 0; columns < columnsLen; columns++)
    {
        double sum = 0;
        for (int rows = 0; rows < rowsLen; rows++)
        {
            sum = sum + matrix[rows, columns];
        }
        // Console.WriteLine(sum);
        Console.WriteLine(sum / columnsLen);
    }
}

Console.Write("Количество строк массива ");
int countRows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int countColumns = int.Parse(Console.ReadLine());

int[,] matrix = new int[countRows, countColumns];
// PrintArray(matrix);
FillArray(matrix);
// Console.WriteLine();
PrintArray(matrix);
FindArithmeticMeanInColumns(matrix);