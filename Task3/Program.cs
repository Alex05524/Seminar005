internal partial class Program
{
    private static void Main(string[] args)
    {
        double[] arrayNum = new double[5];
        for (int i = 0; i < arrayNum.Length; i++)
        {
            arrayNum[i] = new Random().Next(1, 5);
            Console.Write(arrayNum[i] + " ");
        }
        double maxNum = arrayNum[0];
        double minNum = arrayNum[0];

        for (int i = 1; i < arrayNum.Length; i++)
        {
            if (maxNum < arrayNum[i])
            {
                maxNum = arrayNum[i];
            }
            if (minNum > arrayNum[i])
            {
                minNum = arrayNum[i];
            }
        }
        double decision = maxNum - minNum;
        Console.WriteLine($"Максимальный ({maxNum}) минимальный({minNum}) элементы: {decision}");
    }
}