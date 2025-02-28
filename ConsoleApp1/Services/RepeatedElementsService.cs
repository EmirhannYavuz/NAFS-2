namespace ConsoleApp1.Services;

public class RepeatedElementsService
{
    public static void Run()
    {
        List<int> numbers = new List<int>();
        List<int> repeatedNumbers = new List<int>();
        
        Console.Write("Kaç adet sayı gireceksiniz (Minimum 2 adet): ");
        int count = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            if (count >= 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("En az 2 adet sayı girmelisiniz. Lütfen tekrardan kaç adet sayı gireceğinizi belirtiniz: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(number);
        }
        
        foreach (var number in numbers)
        {
            if (numbers.FindAll(x => x == number).Count > 1 && !repeatedNumbers.Contains(number))
            {
                repeatedNumbers.Add(number);
            }
        }
        
        if (repeatedNumbers.Count > 0 && repeatedNumbers.Count == 1)
        {
            Console.WriteLine("Tekrar eden sayı: " + repeatedNumbers[0]);
        }
        else if (repeatedNumbers.Count > 1)
        {
            Console.WriteLine("Tekrar eden sayılar: " + string.Join(", ", repeatedNumbers));
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayıların arasında tekrar eden hiçbir sayı yok.");
        }
    }
}