Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m, n];
void getMass(int m,int n) {
    int i, j;
    Random rand = new Random();
    for (i = 0; i<m; i++) {
        Console.WriteLine();
        for (j=0; j<n; j++) {
            randomArray[i, j] = rand.NextDouble();
            Console.Write(randomArray[i, j]+" ");

        }
    }
}
getMass(m, n);