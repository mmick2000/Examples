void FillArray(int[] collection)
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

int IndexOf(int[] arr, int find)
{
int index1 = 0;
int length = arr.Length;
int position = -1;
// find = 8;
while(index1<length)
{
    if(arr[index1] == find)
    {
        position = index1;
        // Console.Write(position);
        break;
    }
    index1++;
}
return position;
}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int pos = IndexOf(arr, 5);
Console.WriteLine(pos);