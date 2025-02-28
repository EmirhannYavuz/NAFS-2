namespace ConsoleApp1.Services;

public class DynamicStringArrayService
{
    public static void Run()
    {
        Console.WriteLine("Kaç elemanlı bir dizi oluşturmak istersiniz?");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        string[] stringArray = new string[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write($"Dizinin {i + 1}. elemanını giriniz: ");
            stringArray[i] = Console.ReadLine();
        }

        Console.WriteLine("Dizinin elemanları:");
        foreach (var item in stringArray)
        {
            Console.WriteLine(item);
        }

        Console.Write("Diziye eleman eklemek ister misiniz? (Evet/Hayır): ");
        string choice = Console.ReadLine().Trim().ToLower();

        if (choice == "evet")
        {
            Console.Write("Kaç eleman eklemek istersiniz? ");
            int newElementCount = Convert.ToInt32(Console.ReadLine());
            
            string[] newStringArray = new string[stringArray.Length + newElementCount];

            for (int i = 0; i < stringArray.Length; i++)
            {
                newStringArray[i] = stringArray[i];
            }
            
            for (int i = 0; i < newElementCount; i++)
            {
                Console.Write($"{i + 1}. yeni elemanı giriniz: ");
                newStringArray[stringArray.Length + i] = Console.ReadLine();
            }
            
            stringArray = newStringArray;

            Console.WriteLine("Güncellenmiş dizinin elemanları:");
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }
        else if (choice == "hayır")
        {
            Console.WriteLine("Diziye eleman eklenmedi.");
        }
        else
        {
            Console.WriteLine("Geçersiz seçim yaptınız.");
        }
    }
}
