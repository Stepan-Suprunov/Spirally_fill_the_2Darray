// Спирально заполнить массив 4х4


void FillAraay(int[,] collection)
{
    int content = 0;
    for (int i = 0; i == 0; i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = content;
            content++;
        }
    }

    for (int j = collection.GetLength(1)-1; j == collection.GetLength(1)-1; j++)
    {
        for (int i = 1; i < collection.GetLength(0); i++)
        {
            collection[i,j] = content;
            content++;
        }
    }

    for (int i = collection.GetLength(0)-1; i == collection.GetLength(0)-1; i--)
    {
        for (int j = collection.GetLength(1)-2; j >= 0; j--)
        {
            collection[i,j] = content;
            content++;
        }
    }

    for (int j = 0; j == 0; j++)
    {
        for (int i = collection.GetLength(0)-2; i >= 1; i--)
        {
            collection[i,j] = content;
            content++;
        }
    }

    for (int i = 1; i == 1; i++)
    {
        for (int j = 1; j < collection.GetLength(1)-1; j++)
        {
            collection[i,j] = content;
            content++;
        }
    }

    for (int j = collection.GetLength(1)-2; j == collection.GetLength(1)-2; j++)
    {
        for (int i = 2; i < collection.GetLength(0)-1; i++)
        {
            collection[i,j] = content;
            content++;
        }
    }

    for (int i = collection.GetLength(0)-2; i == collection.GetLength(0)-2; i--)
    {
        for (int j = collection.GetLength(1)-3; j > 0; j--)
        {
            collection[i,j] = content;
            content++;
        }
    }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + "   ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] array = new int[4,4];

FillAraay(array);
PrintArray(array);