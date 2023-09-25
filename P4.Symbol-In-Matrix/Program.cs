
static char[,] ReadMatrixOnOneLine(int rows, int cols)
{
    char[,] matrix = new char[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        char[] rowValues = Console.ReadLine().ToCharArray();
        
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowValues[col];
        }
    }

    return matrix;
}

    int n = int.Parse(Console.ReadLine());
    char[,] matrix = ReadMatrixOnOneLine(n, n);
    char symbol = char.Parse(Console.ReadLine());
    bool IsFound = false;

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        char currentSymbol = matrix[row, col];

        if (symbol == currentSymbol)
        {
            Console.WriteLine($"({row}, {col})");
            IsFound = true;
            break;
        }
    }
    if (IsFound)
    {
        break;
    }
}

if (!IsFound)
{
    Console.WriteLine($"{symbol} does not occur in the matrix");
}




