void FillArray(int[] coll1)
{
    // int index = 0;
    // while (index < coll1.Length)
    for (int i = 0; i < coll1.Length; i++)
    {
        coll1[i] = new Random().Next(1, 10);
        // index++;
    }

}


void PrintArray(int[] coll2)
{
    //    int i = 0;
    // while(i<coll2.Length)
    for (int i = 0; i < coll2.Length; i++)
    {
        Console.Write(coll2[i]);
        // i++;
        if (i < coll2.Length - 1)
            Console.Write(", ");
    }

}

int[] arr = new int[10];
int[]array2 = new int[arr.Length];

FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
FillArray2(arr);
PrintArray(array2);

// int[] array2 = new int[array.Length];
void FillArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
array2[i] = array[array.Length - 1 - i];
    }
// return array2[array.Length];
}

