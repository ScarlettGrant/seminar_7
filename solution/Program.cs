// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(25);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}   ");   
        }
        System.Console.WriteLine();    
    }
}

int[] NewArray(int[,] matr)
{
    int[] arr = new int[matr.GetLength(0) * matr.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                arr[index] = matr[i, j];
                index++;    
            }
        }
    return arr;
}

void SortingArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[min]) min = j;
        }
        (arr[i], arr[min]) = (arr[min], arr[i]);
    }
}


void FillArray2 (int[,] matr, int[] arr)
{
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = arr[index];
            index++;
        }
    }
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int[] new_arr = NewArray(array);

SortingArray(new_arr);
FillArray2(array, new_arr);
PrintArray(array);