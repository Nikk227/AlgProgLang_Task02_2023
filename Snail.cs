public class SnailSolution
{
    
    
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Random random = new Random();

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(101);
                }
            }

            Console.WriteLine("Matrix:");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(matrix[i, j] + "\t");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }

            int trace = 0;
            
            for (int i = 0; i < Math.Min(rows, cols); i++)
            {
                trace += matrix[i, i];
            }

            Console.WriteLine("Matrix trace: " + trace);

            
            Console.WriteLine("Elements from matrix going like snail shells from border to center:");
            int rowStart = 0, rowEnd = rows - 1;
            int colStart = 0, colEnd = cols - 1;

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                
                for (int i = colStart; i <= colEnd; i++)
                {
                    Console.Write(matrix[rowStart, i] + " ");
                }
                rowStart++;

               
                for (int i = rowStart; i <= rowEnd; i++)
                {
                    Console.Write(matrix[i, colEnd] + " ");
                }
                colEnd--;

               
                if (rowStart <= rowEnd)
                {
                    for (int i = colEnd; i >= colStart; i--)
                    {
                        Console.Write(matrix[rowEnd, i] + " ");
                    }
                    rowEnd--;
                }

                
                if (colStart <= colEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        Console.Write(matrix[i, colStart] + " ");
                    }
                    colStart++;
                }
            }

            Console.ReadLine();
        }
}


    
   
