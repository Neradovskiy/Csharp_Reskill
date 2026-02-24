int size = 5;
int[] firstArr = new int[size];
int[] secondArr = new int[size];
for (int i = 0; i < size; i++)
{
    firstArr[i] = i;
    secondArr[i] = i;
}

int[] sumArr = new int[size];
for (int i = 0; i < size; ++i)
    sumArr[i] = firstArr[i] + secondArr[i];
Console.WriteLine(string.Join(" ", sumArr));