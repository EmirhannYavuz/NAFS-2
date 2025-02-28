namespace ConsoleApp1.Services;

public class WordLengthCheckerService
{
    public static void Run()
    {
        List<string> words = new List<string>();

        Console.WriteLine("Kaç adet kelime gireceksiniz (Minimum 2 adet): ");
        int count = Convert.ToInt32(Console.ReadLine());
        
        while (true)
        {
            if (count >= 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("En az 2 adet kelime girmelisiniz. Lütfen tekrardan kaç adet kelime gireceğinizi belirtiniz: ");
                count = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Lütfen {i + 1}. kelimeyi giriniz: ");
            string word = Console.ReadLine();
            words.Add(word);
        }
        
        string longestWord = "";
        string shortestWord = words[0];
        
        foreach (var word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }

            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
        }
        
        Console.WriteLine("En uzun kelime: " + longestWord);
        Console.WriteLine("En kısa kelime: " + shortestWord);
    }
}