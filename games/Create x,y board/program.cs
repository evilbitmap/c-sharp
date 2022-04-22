namespace Program
{
    class test
    {
        static char[,] board_data;
        static int width;
        static int height;

        static void Main(string[] args)
        {
            Console.WriteLine("width:");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("height:");
            height = Convert.ToInt32(Console.ReadLine());

            board_data = new char[height, width];

            DrawBoard(height, width);
            int inputWidth = Convert.ToInt32(Console.ReadLine());
            int inputHeight = Convert.ToInt32(Console.ReadLine());

            board_data[inputHeight-1, inputWidth-1] = 'X';

            Console.Clear();
            Console.WriteLine("height: " + inputHeight);
            Console.WriteLine("width: " + inputWidth);

            DrawBoard(height, width);

        }
        static void DrawBoard(int height, int width)
        {

            string lines = "";

            for(int i = 0; i < width; i++)
            {
                lines += "+---";
            }

            int rowCount = board_data.GetLength(0);
            int colCount = board_data.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                Console.Write(lines + "+" + Environment.NewLine);
                for (int j = 0; j < colCount; j++)
                {
                    if (board_data[i, j] == 0)
                    {
                        Console.Write(string.Format("|  {0} ", board_data[i, j]));
                    }
                    else
                        Console.Write(string.Format("| {0} ", board_data[i, j]));
                }
                Console.Write("|");
                Console.Write(Environment.NewLine);
            }
            Console.Write(lines + "+" + Environment.NewLine);
        }
    }
}
