﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] coll)
{
int count = coll.Length;
int position = 0;
while(position < count)
{
Console.Write(coll[position]+ " ");
position++;
}

}


int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);