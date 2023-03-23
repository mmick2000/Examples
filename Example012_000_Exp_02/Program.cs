// берём массив и сортируем его от максимального к минимальному

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxpos = i;
        for (int j = i; j + 1 < array.Length; j++)
        {
            if (array[j] > array[maxpos]) maxpos = j;
        }
        int temp = array[i];
        array[i] = array[maxpos];
        array[maxpos] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


void SelectionSort2(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minpoz1 = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minpoz1]) minpoz1 = j;
        }
        int temp2 = array[i];
        array[i] = array[minpoz1];
        array[minpoz1] = temp2;
    }
}