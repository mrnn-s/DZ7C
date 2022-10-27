// Написать программу, которая в двумерном массиве заменяет строки на столбцы
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

void FillMassiv(int[,] massiv)
{
    Random num = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = num.Next(-10, 11);
        }
    }
}

void PrintMass(int[,] array)
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

int[,] ChangeStroktoStolb(int[,] massiv)
{
    int[,] newmassiv = new int[massiv.GetLength(0), massiv.GetLength(1)];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            newmassiv[i, j] = massiv[j, i];
        }
    }
    return newmassiv;
}
        
Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
int[,] changedArray = new int[m, n];
FillMassiv(array);
PrintMass(array);
Console.WriteLine();
if (m == n)
{
    changedArray = ChangeStroktoStolb(array);
    PrintMass(changedArray);
}
else Console.WriteLine("Матрица не квадратная");