double[] arr = new double[] { 3, 7, 22, 2, 78 };

double max = arr[0];
double min = arr[0];

foreach (double num in arr)
{
    if (num > max)
    {
        max = num;
    }

    if (num < min)
    {
        min = num;
    }
}

double diff = max - min;

Console.WriteLine(diff);
