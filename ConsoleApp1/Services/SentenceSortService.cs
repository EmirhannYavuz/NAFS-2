namespace ConsoleApp1.Services;

public class SentenceSortService
{
    public static void Run()
    {
        Console.WriteLine("Kelimelerini alfabetik olarak sıralamak istediğiniz cümleyi giriniz: ");
        string sentence = Console.ReadLine();
        
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        Array.Sort(words);
        
        Console.WriteLine("Girdiğiniz cümledeki kelimelerin alfabetik sıralaması:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}