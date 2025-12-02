// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter arr size: ");
int size = 0;
try
{
    size = int.Parse(Console.ReadLine());
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Random random = new Random();
int[] arr = new int[size];
for (int i = 0; i < size; i++)
    arr[i] = random.Next(-10, 10);

Console.WriteLine("Array is: " + string.Join(", ", arr));
int sumNegativNum = 0;
int minIndex = 0;
int maxIndex = 0;
int min = arr[0];
int max = arr[0];
int evenMulty = 1;
int firstNegativeIndex = arr.IndexOf(arr.Where(i => i < 0).First());
int lastNegativeIndex = arr.IndexOf(arr.Where(i => i < 0).Last());
for (int i = 0; i < size; ++i)
{
    if (arr[i] < 0)
        sumNegativNum += arr[i];

    if (arr[i] < min)
    {
        min = arr[i];
        minIndex = i;
    }

    if (arr[i] > max)
    {
        max = arr[i];
        maxIndex = i;
    }

    if (i % 2 == 0)
        evenMulty *= arr[i];
}

Console.WriteLine("Summ all negative element is: " + sumNegativNum);
int multiMinMax = 1;

Console.WriteLine("Min index is: " + minIndex);
Console.WriteLine("Max  index is: " + maxIndex);

if (minIndex > maxIndex)
    (minIndex, maxIndex) = (maxIndex, minIndex);



for (int i = minIndex; i <= maxIndex; ++i)
    multiMinMax *= arr[i];

Console.WriteLine("Multiply elements that are between the minimum and maximum elements is: " + multiMinMax);
Console.WriteLine("Multiply even elements is: " + evenMulty);

Console.WriteLine("First min index is: " + firstNegativeIndex);
Console.WriteLine("Last min index is: " + lastNegativeIndex);
int[] buffArr = arr.Skip(firstNegativeIndex).Take(lastNegativeIndex - firstNegativeIndex + 1).ToArray();

int summMinMaxNegative = 0;
foreach(int i in buffArr)
    summMinMaxNegative += i;

Console.WriteLine("The sum of the elements between the first and last negative elements is: " + summMinMaxNegative);