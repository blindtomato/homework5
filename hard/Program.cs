//Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

int[] fillArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void printArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] GetArrayInfo(int[] array)
{
    double[] result = new double[5];
    result[0] = array[0]; //максимальный элемент
    result[1] = 0; //индекс максимального элемента
    result[2] = array[0]; //минимальный элемент
    result[3] = 0; //индекс минимального элемента
    result[4] = array[0]; //среднее арифметическое
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > result[0])
        {
            result[0] = array[i];
            result[1] = i;
        }
        else if(array[i] < result[2])
             {
                result[2] = array[i];
                result[3] = i;
             }
        result[4] += array[i]; 
    }
    result[4] /= array.Length;
    return result; 
}

double FindMedianValue(int[] array)
{
    double result = 0;
    for (int i = 1; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    if (array.Length % 2 == 0)
        result = (array[array.Length / 2 - 1] + array[array.Length / 2]) / 2.0;
    else 
        result = array[array.Length / 2];
    return result;
}

Console.WriteLine("Введите количество элементов массива");
int length = Convert.ToInt32 (Console.ReadLine());
int[] newArray = fillArray(length);
printArray(newArray);
double[] newArrayInfo = GetArrayInfo(newArray);
Console.WriteLine($"Максимальный элемент массива {newArrayInfo[0]}");
Console.WriteLine($"Индекс максимального элемента массива {newArrayInfo[1]}");
Console.WriteLine($"Манимальный элемент массива {newArrayInfo[2]}");
Console.WriteLine($"Индекс минимального элемента массива {newArrayInfo[3]}");
Console.WriteLine($"Среднее арифметическое элементов массива {newArrayInfo[4]}");
Console.WriteLine($"Медианное значение массива {FindMedianValue(newArray)}");
