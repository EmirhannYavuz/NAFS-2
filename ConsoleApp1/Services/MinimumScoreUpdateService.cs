namespace ConsoleApp1.Services;

public class MinimumScoreUpdateService
{
    public static void Run()
    {
        List<int> scores = new List<int>();
        
        Console.Write("Kaç adet not gireceksiniz: ");
        int count = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            if (count > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("En az 1 adet not girmelisiniz. Lütfen tekrardan kaç adet not gireceğinizi belirtiniz: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Lütfen {i + 1}. notu giriniz (0-100): ");
            int score = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (score >= 0 && score <= 100)
                {
                    scores.Add(score);
                    break;
                }
                else
                {
                    Console.WriteLine($"Geçersiz not girdiniz. Lütfen {i + 1}. notu tekrardan girin: ");
                    score = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        int order = 0;

        while (order < scores.Count)
        {
            if (scores[order] < 50)
            {
                scores[order] = 50;
            }
            else
            {
                order++;
            }
        }
        
        Console.WriteLine("Notların güncellenmiş hali: ");
        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }
    }
}