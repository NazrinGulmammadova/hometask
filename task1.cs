int num = 256;
int i = 2;
while (num >= i)
{
    if (num == i)
    {
        Console.WriteLine("it is true");
    }
    else if (num < i)
    {
        Console.WriteLine("it is false");
    }
    i = i * 2;
}