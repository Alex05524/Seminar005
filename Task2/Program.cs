internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write($"Введите элементы массива: ");
        int numElem = Convert.ToInt32(Console.ReadLine());
        int RandomNumbers(int numElem, int min, int max)
        {
            int[] randomNumb = new int[numElem];
            int summElem = 0;
            Console.Write("Результат: ");
            for (int i = 0; i < randomNumb.Length; i++)
            {
                randomNumb[i] = new Random().Next(min, max);
                Console.Write(randomNumb[i] + " ");
                if (i % 2 != 1)
                {
                    summElem = summElem + randomNumb[i];
                }
            }
            return summElem;
        }

        int randomNumb = RandomNumbers(numElem, 1, 10);
        Console.WriteLine($"Сумма: {randomNumb}");
    }
}