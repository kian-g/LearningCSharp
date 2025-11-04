class Program
{
    static void Main(string[] args) {
        Console.Write("How many rows: ");
        string rowsStr = Console.ReadLine() ?? "0";
        
        Console.Write("How many cols: ");
        string colsStr = Console.ReadLine() ?? "0";
        
        Console.Write("What symbol to use: ");
        string symbol = Console.ReadLine() ?? "x";

        int rows = Convert.ToInt32(rowsStr);
        int cols = Convert.ToInt32(colsStr);

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"{symbol} ");
            }

            Console.WriteLine();
        }
    }
}
