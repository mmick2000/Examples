
int[] arr = { 1, 12, 16, 4, 15, 16, 17, 18 };

int n = arr.Length;
int find = 16;
int index = 0;

while (index < n)
{
    if (arr[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}