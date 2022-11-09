
Start();
void Start()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
        Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
        Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
        Console.WriteLine("0: end");

        int numTask = SetNumber("Введите номер задачи");

        switch (numTask)
        {
            case 0: return;
            case 34:
                Console.Clear();
                Console.WriteLine("Введите size");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = GetRandomArray(size, 100, 999);
                Console.WriteLine(string.Join(" ", arr));
                Console.WriteLine($"Количество четных элементов в массиве = {PositiveNumbers(arr)}");
                break;
            case 36:
                Console.Clear();
                Console.WriteLine("Введите size");
                int size1 = Convert.ToInt32(Console.ReadLine());
                int[] arr1 = RandomArr(size1, -100, 100);
                Console.WriteLine(String.Join(" ", arr1));
                Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {GetSumNums(arr1)}");
                break;
            case 38:
                Console.Clear();
                Console.WriteLine();
                double[] array = GetRandomArrDouble(6, -100, 100);
                Console.WriteLine(string.Join(" ", array));
                Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {GetDifference(array)} ");
                break;
            default: Console.WriteLine("Error"); break;
        }
        Console.WriteLine("Задача выполнена, нажмите любую клавишу");
        Console.ReadKey();
    }
}
int SetNumber(string comment)
{
    Console.Write($" {comment}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int[] GetRandomArray(int size, int begin, int last)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(begin, last + 1);
    }
    return arr;
}
int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

int[] RandomArr(int size1, int begin, int last)
{
    int[] arr1 = new int[size1];
    Random random = new Random();
    for (int i = 0; i < size1; i++)
    {
        arr1[i] = random.Next(begin, last + 1);

    }
    return arr1;
}

int GetSumNums(int[] arr1)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr1[i];
        }

    }
    return sum;
}


//"Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива."

double[] GetRandomArrDouble(int size, double begin, double last)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(-100, 100 + 1);

    }
    return array;
}
double GetDifference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    foreach (var item in arr)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}
