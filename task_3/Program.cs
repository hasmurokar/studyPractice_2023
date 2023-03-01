Console.WriteLine("Матрица");
int[,] matrix = new int[7, 7];
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (i == j || i + j == 6 || i == 3 || j == 3)
        {
            matrix[i, j] = 1;
        }
        else
        {
            matrix[i, j] = 0;
        }
    }
}
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 7; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}