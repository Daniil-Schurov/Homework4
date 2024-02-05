string GetNum ()
{
    Console.WriteLine("Введите целое число");
    string input = Console.ReadLine();
    return input;
}

bool analyse(string input)
{    
    if (input == "q")
    {
        return true;
    }
    int count = 0;
    int num = Convert.ToInt32(input);
    while (num != 0)
    {
        count = count + num % 10;
        num = num / 10;
    }
    if (count % 2 == 0)
    {
        return true;
    }
    else 
    {
        return false;
    }
}   


while (analyse(GetNum()) == false)
{
    analyse(GetNum());
} 
Console.WriteLine("Спасибо что пользовались нашим ПО");