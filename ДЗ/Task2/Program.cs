// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }

    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();

    }
    System.Console.WriteLine();
}

int row = Prompt("Ведите еол-во строк => ");
int colum = Prompt("Ведите еол-во колонок => ");
int[,] mass = GenerateArray(row, colum, 0, 10);
PrintArray(mass);

int[] CalculateSum(int[,] arr)
{
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result += arr[i, j];
        }
        sum[i] = result;
    }
    return sum;
}

int SearchMinSum(int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            index = i;
        }
    }
    return index;
}

int [] sum = CalculateSum(mass);
int index = SearchMinSum(sum);
Console.WriteLine($"наименьшая сумма элементов в троке {index +1}");