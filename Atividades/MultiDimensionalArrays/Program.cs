int[,] biNumbers = new int[5,2];

int[,,] trinumbers = new int[5,4,3];

int[,] loadedBiNumbers = new int[,]
{
   { 9,   5,  6},
   {10, -11, 15},
   {101, 45,  8}
};

for(int i = 0; i < loadedBiNumbers.GetLength(0); i++)
{
   for(int j = 0; j < loadedBiNumbers.GetLength(1); j++)
   {
      Console.Write(
          $"[{loadedBiNumbers[i,j]}]"
       );
   }
   Console.WriteLine("");
}