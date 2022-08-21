internal class Program
{
    private static void Main(string[] args)
    {
        int[] num = new int[4];

        void FillArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }

        void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        int QuantityPositiveNumbers(int[] array)
        {
            int PosNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    PosNum++;
                }
            }
            return PosNum;
        }

        FillArray(num, 100, 1000);
        WriteArray(num);
        Console.WriteLine();

        int quantity = QuantityPositiveNumbers(num);
        Console.WriteLine($"Количество чисел: {quantity}");
    }
}