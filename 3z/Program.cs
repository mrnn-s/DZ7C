// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillMassiv(int[,] massiv)
{
    Random num = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = num.Next(-9, 10);
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

double[] SumStroka(int[,] array)
{

    double[] summ2 = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        summ2[i] = sum;
    }
    return summ2;
}

void printSum(double[] array)
{
    foreach (double el in array)
    {
        Console.Write(el + " ");
    }
}

int PoiskLessSumm(double[] array)
{
    int indexStroki = 1;
    for (int i = 0; i < array.Length; i++)
    {
        double min = array[0];
        if (array[i] < min)
        {
            min = array[i];
            indexStroki = i;
        }
    }
    return indexStroki;
}

Console.Write("Введите число (строк) m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число (столбцов) n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];

FillMassiv(array);
PrintMass(array);

Console.WriteLine();

double[] sum = SumStroka(array);
printSum(sum);

Console.WriteLine();

int nomerStroki = PoiskLessSumm(sum) + 1;
Console.WriteLine($"Строка с наименьшей суммой {nomerStroki}");
