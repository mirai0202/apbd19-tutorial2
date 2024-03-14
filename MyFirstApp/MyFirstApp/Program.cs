// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    
    foreach (var number in numbers)
        sum += number;
    
    return sum / numbers.Length;
}

int[] numbers = {1, 2, 3, 4};
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    var max = numbers[0];
        
    foreach (var n in numbers)
    {
        if (n > max)
        {
            max = n;
        }    
    }

    return max;
}

Console.WriteLine(GetMax(numbers));
