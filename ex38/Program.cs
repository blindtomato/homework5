double[] fillArrayDouble(int lenght)
{
    double[] array = new double[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

double DiffBetweenMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        else if(array[i] < min)
            min = array[i];
    }
    double result = max - min;
    return result;
}

Console.WriteLine("Введите количество элементов массива");
int length = Convert.ToInt32 (Console.ReadLine());
double[] newArray = fillArrayDouble(length);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива {DiffBetweenMaxMin(newArray)}");
