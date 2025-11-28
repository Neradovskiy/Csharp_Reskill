const int arrSize = 10;
int[] arr = new int[arrSize];
Random rnd = new Random();
for (int i = 0; i < arrSize; i++)
    arr[i] = rnd.Next(0, 10);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Max value is: " + arr.Max());
Console.WriteLine("Min value is: " + arr.Min());
