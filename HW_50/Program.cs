// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindElementInArray(int[,] matrix, int element)
{
    string output = $"В массиве нет элемента {element}";
    int rowsLen = matrix.GetLength(0);
    int columnsLen = matrix.GetLength(1);
    for (int rows = 0; rows < rowsLen; rows++)
    {
        for (int columns = 0; columns < columnsLen; columns++)
        {
            if (matrix[rows, columns] == element)
            {
                output = $"В массиве есть элемент {element}";
            }
        }
    }
    Console.WriteLine(output);
}

Console.Write("Введите искомое число ");
int number = int.Parse(Console.ReadLine());

Console.Write("Количество строк массива ");
int countRows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов массива ");
int countColumns = int.Parse(Console.ReadLine());

int[,] matrix = new int[countRows, countColumns];
// PrintArray(matrix);
FillArray(matrix);
// Console.WriteLine();
PrintArray(matrix);
FindElementInArray(matrix, number);