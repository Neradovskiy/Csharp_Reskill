
using task4;

Console.WriteLine("Please enter profit for the one year:");
const int monthCount = 12;
double[] profitForYear = new double[monthCount];
Month month = new Month();
try
{
    for (int i = 0; i < monthCount; i++)
    {
        month = (Month)i;
        Console.WriteLine("Enter profit for " + (Month)i + ": ");
        profitForYear[i] = double.Parse(Console.ReadLine());
    }
    Console.WriteLine(string.Join(", ", profitForYear));
    int startRangeProfit;
    int endRangeProfit;
    do
    {
        Console.WriteLine("Please enter start range for profit(1-12): ");
        startRangeProfit = int.Parse(Console.ReadLine());
    }
    while (startRangeProfit < 0 && startRangeProfit > 12);
    do
    {
        Console.WriteLine("enter end range for profit(1-12): ");
        endRangeProfit = int.Parse(Console.ReadLine());
    }
    while (endRangeProfit < 0 && endRangeProfit > 12);
    if (startRangeProfit > endRangeProfit)
        (startRangeProfit, endRangeProfit) = (endRangeProfit, startRangeProfit);
    double min = profitForYear[startRangeProfit];
    double max = profitForYear[startRangeProfit];
    for (int i = startRangeProfit - 1; i < endRangeProfit; i++)
    {
        if (min >  profitForYear[i])
        min = profitForYear[i];
        if (max < profitForYear[i])
        max = profitForYear[i];
    }
    Console.WriteLine("Min profit is: " + min);
    Console.WriteLine("Max profit is: " + max);

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

