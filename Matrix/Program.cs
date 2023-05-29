Console.WriteLine("\n---Matrix---\n");
int size = 5;
int[,] matrix2D = new int[size, size];
for(int i = 0; i < size; i++)
{
    Console.Write($"a.{i}: \t");
    for(int j = 0; j < size; j++)
    {
        matrix2D[i, j] = i + j;
        Console.Write(matrix2D[i, j]+"\t");
    }
    Console.WriteLine();
}