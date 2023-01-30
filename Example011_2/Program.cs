void FillArray (int [] coll1)
{
int index = 0;
while (index < coll1.Length)
{
coll1[index] = new Random().Next(1, 10);
index++;
}

}


void PrintArray (int [] coll2)
{
   int index2 = 0;
while(index2<coll2.Length)
{
    Console.Write(coll2[index2]);
    index2++;
    if (index2<coll2.Length) 
    Console.Write(", ");
}

}

int[] arr = new int[10];

FillArray(arr);
PrintArray(arr);