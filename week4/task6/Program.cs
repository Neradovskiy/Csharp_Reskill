// See https://aka.ms/new-console-template for more information
int size = 10;
int[] arr = new int[size];
Random random = new Random();

for (int i = 0; i < size; i++)
    arr[i] = random.Next(0, 100);

Console.WriteLine(string.Join(", ", arr));

int[] firstArr = new int[size / 2];
int[] secondArr = new int[size / 2];
Array.Copy(arr, 0, firstArr, 0, firstArr.Length);
Array.Copy(arr, size / 2, secondArr, 0, secondArr.Length);

Console.WriteLine("First arr is: " + string.Join(", ", firstArr));
Console.WriteLine("Second arr is: " + string.Join(", ", secondArr));