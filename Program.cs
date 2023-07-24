void FillArray(int[] array, int minValue, int maxValue)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0;i < array.Length; i++)
    {
       array[i] = rnd.Next(minValue,maxValue);
    }
}
void FillArrayDouble(double[] array, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = rnd.NextDouble() * (maxValue-minValue) + minValue;
       array[i] = Math.Round(array[i], 2);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0;  i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintArrayDouble(double[] array)
{
    for (int i = 0;  i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Task34()
{
    //34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
    int size = 6;
    int[] numbers = new int[size];
    FillArray(numbers,99, 999);
    PrintArray(numbers);

    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 ==0) count++;
    }
    Console.WriteLine("Количество чётных чисел равно " + count);
    }

void Task36()
{
    //36: Задайте одномерный массив, заполненный случайными числами.
    // Найдите сумму элементов с нечётными индексами.

    int size = 6;
    int[] numbers = new int[size];

    FillArray(numbers, 0, 7);
    PrintArray(numbers);

    int sum = 0;
    for (int i = 1; i < numbers.Length; i+=2)
    {
       sum += numbers[i];

    }
    Console.WriteLine("Сумма  равна " + sum);
}

void Task38()
{
    //38: Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементами массива.

    int size = 6;
    double[] numbers = new double[size];

    FillArrayDouble(numbers, -100, 100);
    PrintArrayDouble(numbers);

    double max = numbers[0];
    double min = numbers[0];

    for (int i = 1; i < numbers.Length; i+=2)
    {
       if (numbers[i] > max) max = numbers[i];
       else if (numbers[i] < min) min = numbers[i];

    }
    Console.WriteLine(min);
    Console.WriteLine(max);
     Console.WriteLine("Разница значений равна " + $"{ Math.Round(max-min), 4 }");
}
Console.Clear();
Task38();

