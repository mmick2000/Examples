void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        // System.Console.Write(collection[index] + " ");
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i = 0;
    while (i < count)
    {
        System.Console.Write(col[i] + " ");
        i++;
    }
    System.Console.WriteLine();
}

int IndexOff(int[] collect, int find)
{
    int index = 0;
    int count = collect.Length;
    int position = -1;
    while (index < count)
    {
        if (collect[index] == find)
        {
            position = index;
            break;
        }
        // return position;}
        // else if (collect[index] != find && index == count - 1)
        // position = -1;
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine(IndexOff(array, 6));