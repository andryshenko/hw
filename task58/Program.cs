// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
Console.Clear();
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 4);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("Размер матрицы: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int x = 0; x < size; x++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, x] * matrixB[x, j]);
        }
    }
}
Console.WriteLine("Матрица - А:");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В:");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц (А * В):");
PrintArray(matrixC);