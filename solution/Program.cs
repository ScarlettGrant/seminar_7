//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * 100;
        }
    }
}

void PrintArray(double[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5:f2}   ");   
        }
        System.Console.WriteLine();    
    }
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];

FillArray(array);
PrintArray(array);