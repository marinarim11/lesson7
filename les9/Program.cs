Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int [,] randomArray = new int [m, n];
void getMass(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1,9);
            Console.Write(randomArray[i, j] + " ");

        }
    }
}
getMass(m, n);
void getAvg(int m , int n) {
    Console.WriteLine("среднее арифметическое:");
    int i, j;
    for (j = 0; j < n; j++) {
        double sum = 0;
        for (i = 0; i < m; i++) {
            sum += randomArray[i, j];

        }
        Console.WriteLine(sum / i);
    }
}
getAvg(m, n);