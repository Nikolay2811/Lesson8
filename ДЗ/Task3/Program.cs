// See https://aka.ms/new-console-template for more information
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

int row = Prompt("Ведите кол-во строк в первой матрице => ");
int colum = Prompt("Ведите кол-во колонок в первой матрице => ");
int[,] mass = GenerateArray(row, colum, 0, 10);


int row1 = Prompt("Ведите кол-во строк во второй матрице => ");
int colum1 = Prompt("Ведите кол-во колонок во второй матрице => ");
int[,] mass1 = GenerateArray(row1, colum1, 0, 10);

PrintArray(mass);
Console.WriteLine();
PrintArray(mass1);

int[,] CreateMatrix(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            arr3[i, j] = CalculateMatrix(arr1, arr2, i, j);
        }
    }
    return arr3;
}

int CalculateMatrix(int[,] arr1, int[,] arr2, int row1, int colum2)
{
    int ressult = 0;
    for (int i = 0; i < arr1.GetLength(1); i++)
    {
        ressult += arr1[row1, i] * arr2[i, colum2];
    }
    return ressult;
}

if (mass.GetLength(1) != mass1.GetLength(0))
{
    Console.WriteLine("Кол-во столбцов в первой матрице должно быть равно кол во строк во второй мартице");
    Environment.Exit(0);
}

int [,] mass2 = CreateMatrix(mass, mass1);
Console.WriteLine("Произведение матриц равно");
PrintArray(mass2);