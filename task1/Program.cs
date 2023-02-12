Console.WriteLine("Введите число n: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число m: ");

int m = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[n, m];

Random rand = new Random();

for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
    array[i, j] = rand.Next(1, 10) + rand.NextDouble();
  }
}

for (int i = 0; i < n; i++)
{
  for (int j = 0; j < m; j++)
  {
    Console.Write(Math.Round(array[i,j], 2) + " | ");
  }
  Console.WriteLine();
}

Console.ReadKey();
