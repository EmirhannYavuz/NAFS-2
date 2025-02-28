namespace ConsoleApp1.Services;

public class NumberProcessorService
{
    public static void Run()
    {
        List<int> numbers = new List<int>();
        
        Console.Write("Kaç adet sayı gireceksiniz: ");
        int count = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            if (count > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("En az 1 adet sayı girmelisiniz. Lütfen tekrardan kaç adet sayı gireceğinizi belirtiniz: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        }

        double average = numbers.Average();
        Console.WriteLine("Girdiğiniz sayıların ortalaması: " + average);
        
        numbers.Sort();
        Console.WriteLine("Girdiğiniz sayıların küçükten büyüğe sıralanmış hali: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}