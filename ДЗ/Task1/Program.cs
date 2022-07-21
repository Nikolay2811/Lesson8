// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
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

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
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
int[,] mass = GenerateArray(row, colum, -10, 10);
PrintArray(mass);
void OrderArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp;
            for (int count = 0; count < array.GetLength(0) - 1; count++)
            {
                if (array[i, count] < array[i, count + 1])
                {
                    temp = array[i, count];
                    array[i, count] = array[i, count + 1];
                    array[i, count + 1] = temp;
                }
            }
        }

    }
}
OrderArray(mass);
PrintArray(mass);