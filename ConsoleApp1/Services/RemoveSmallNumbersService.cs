namespace ConsoleApp1.Services;

public class RemoveSmallNumbersService
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

        int order = 0;

        while (order < numbers.Count)
        {
            if (numbers[order] < 10)
            {
                numbers.RemoveAt(order);
            }
            else
            {
                order++;
            }
        }
        
        if (numbers.Count == 0)
        {
            Console.WriteLine("Girdiğiniz sayılar arasında 10 ve üzeri olan hiçbir sayı yok.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayılar arasından 10 ve üzeri olanlar: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}