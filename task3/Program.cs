void FillArray(int[,]matr)
{
  Random rand = new Random();
  for(int i = 0;i < matr.GetLength(0);i++)
  {
    for(int j = 0;j < matr.GetLength(1);j++)
    {
      matr[i,j] = rand.Next(1,11);
    }
  }
}

void PrintArray(int [,] matrix)
{
  for(int i = 0;i < matrix.GetLength(0);i++)
  {
    for(int j = 0;j < matrix.GetLength(1);j++)
    {
      Console.Write(matrix[i,j] + "  ");
    }
    System.Console.WriteLine();
  }
}

void Scalling(int[,]arr)
{
  for(int i = 0;i < arr.GetLength(0);i++)
  {
    for(int j = 0;j < arr.GetLength(1);j++)
    {
      if(i%2==0 && j%2==0){
        arr[i,j] *= arr[i,j];
      }
    }
  }
}

int[,]array = new int [4,4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Scalling(array);
PrintArray(array);