//Задача 62

int m = 4;
int n = 4;
int value = 1;
int minRow = 0;
int maxRow = 3;
int minCol = 0;
int maxCol = 3;


PrintArray(GetArray(m, n, value, minRow, minCol, maxRow, maxCol));

int[,] GetArray(int m, int n, int value, int minRow, int minCol, int maxRow, int maxCol)
{
    int[,] array = new int[m, n];

    while (value <= 16)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minRow, i] = value;
            value++;
        }

        for (int i = minRow + 1; i <= maxRow; i++)
        {
            array[i, maxCol] = value;
            value++;
        }

        for (int i = maxCol - 1; i >= minCol; i--)
        {
            array[maxRow, i] = value;
            value++;
        }

        for (int i = maxRow - 1; i >= minRow + 1; i--)
        {
            array[i, minCol] = value;
            value++;
        }

        minRow++;
        minCol++;
        maxRow--;
        maxCol--;
    }

    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}