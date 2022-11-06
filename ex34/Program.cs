int[] fillArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int CountEven(int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;    
    }
    return count;
}

Console.WriteLine("Введите количество элементов массива");
int length = Convert.ToInt32 (Console.ReadLine());
int[] newArray = fillArray(length);
Console.WriteLine($"Количество четных элементов в массиве {CountEven(newArray)}");
