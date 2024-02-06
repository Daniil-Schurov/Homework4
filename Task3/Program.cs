void PrintArray(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
}

int[] RandomArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0,100);   
    }
    return col;
}

int[] Turnback(int[] col)
{
    int temp = 0;
    int size = col.Length;
    for (int i = 0; i < col.Length/2; i++)
    {
        temp = col[i];
        col[i] = col[size - 1];
        col[size - 1] = temp;
        size = size - 1;
    }
    return col;
} 

int[] mas = RandomArray(new int[11]);
PrintArray(mas);
int[] turnmas = Turnback(mas);
PrintArray(turnmas);
