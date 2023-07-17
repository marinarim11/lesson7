Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];
Console.WriteLine("Введите позицию строки");
int m2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию столбца");
int n2 = Convert.ToInt32(Console.ReadLine());
void getMass(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.NextDouble();
            Console.Write(randomArray[i, j] + " ");

        }
    }
}
getMass(m, n);
if(m2<1 || n2 <1) {
    Console.WriteLine("нет в массиве");
} else if (m2<=m+1 && n2<= n + 1) {
    Console.WriteLine(randomArray[m2 - 1, n2 - 1]);
} else {
    Console.WriteLine("нет массива");
}
