// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void FillMassiv(int[,] massiv)
{
    Random number  = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = number.Next (-10, 11);
        }
    }
}

void PrintMassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MassivSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                if (array[i, j] >= array[i, l])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, l];
                    array[i, l] = temp;
                }
            }
        }
    }

}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillMassiv(array);
PrintMassiv(array);
Console.WriteLine();
MassivSort(array);
PrintMassiv(array);