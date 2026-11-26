int sizeX = 5;
int sizeY = 2;
int[,] arr = new int[sizeY, sizeX];

Console.WriteLine("Enter num: ");

int num = int.Parse(Console.ReadLine());

for (int y = 0; y < sizeY; ++y)
{
    for (int x = 0; x < sizeX; ++x)
    {
        if (x == y && y == 0)
            arr[y, x] = num;
        else
            arr[y, x] = ++num;
    }
}


for (int y = 0; y < sizeY; ++y)
{
    for (int x = 0; x < sizeX; ++x)
        Console.Write(" [" + arr[y,x] + "] ");
    Console.WriteLine();
}
