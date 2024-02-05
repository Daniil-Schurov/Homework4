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
        col[i] = new Random().Next(100,1000);   
    }
    return col;
}

int analyse(int []col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if(col[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
    
}

int[] mas = RandomArray(new int[10]);
PrintArray(mas);
Console.WriteLine(analyse(mas));

