// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Console.WriteLine("Введите длину массива: ");
// int siie = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[siie];

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//     }
// }

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
GetRandArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < size; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

void GetRandArray(double[] array)
{
    for(int i = 0; i < size; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

Console.WriteLine($"В массиве: [ {string.Join("; ", array)} ] -> разница между макс {max} и мин {min} = {max - min}");