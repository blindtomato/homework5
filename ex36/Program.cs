int[] fillArray(int lenght)
{
    int[] array = new int[lenght];
    for(int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(-10,11);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int SumOddIndex(int [] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

Console.WriteLine("Введите количество элементов массива");
int length = Convert.ToInt32 (Console.ReadLine());
int[] newArray = fillArray(length);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях {SumOddIndex(newArray)}");