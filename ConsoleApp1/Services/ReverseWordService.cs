namespace ConsoleApp1.Services;

public class ReverseWordService
{
    public static void Run()
    {
        List<string> words = new List<string>();
        
        Console.Write("Kaç adet kelime gireceksiniz: ");
        int wordCount = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            if (wordCount > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("En az 1 kelime girmelisiniz. Lütfen tekrardan kaç adet kelime gireceğinizi belirtiniz: ");
                wordCount = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        for (int i = 0; i < wordCount; i++)
        {
            Console.Write($"Lütfen {i + 1}. kelimeyi giriniz: ");
            string word = Console.ReadLine();
            words.Add(word);
        }
        
        foreach (var word in words)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }
}