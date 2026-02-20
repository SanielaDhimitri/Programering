
using System.Text;

class Program
{
    static void Main()
    {
        List<Kunde> kundeListe = new List<Kunde>();

        Console.WriteLine($"Capacity: {kundeListe.Capacity}, Count: {kundeListe.Count}");

        kundeListe.Add(new Kunde(1, "Ib"));
        kundeListe.Add(new Kunde(2, "Bo"));
        kundeListe.Add(new Kunde(3, "Per"));
        Kunde kunde1 = new Kunde(4, "Henrik");
        Kunde kunde2 = new Kunde(5, "Jamshid");

        kundeListe.Add(kunde1);
        kundeListe.Add(kunde2);

        Console.WriteLine($"Capacity: {kundeListe.Capacity}, Count: {kundeListe.Count}");

        // 🔹 Kërko klientin me emër Bo
        Console.WriteLine("\nKunde me emër 'Bo':");
        foreach (Kunde kunde in kundeListe)
            if (kunde.Name == "Bo")
                Console.WriteLine(kunde);

        // 🔹 Shfaq të gjithë klientët
        Console.WriteLine("\nTë gjithë klientët:");
        foreach (Kunde kunde in kundeListe)
            Console.WriteLine(kunde);

        // 🔹 Fshi klientin me emër Per
        kundeListe.RemoveAll(k => k.Name == "Per");

        Console.WriteLine("\nPas fshirjes së 'Per':");
        foreach (Kunde kunde in kundeListe)
            Console.WriteLine(kunde);

        // 🔹 Dictionary
        Dictionary<int, Kunde> kundeDictionary = new Dictionary<int, Kunde>
        {
            { 1, new Kunde(1, "Ib") },
            { kunde1.Id, kunde1 },
            { kunde2.Id, kunde2 }
        };

        Console.WriteLine("\nDictionary:");
        if (kundeDictionary.TryGetValue(4, out var kunde4))
            Console.WriteLine(kunde4);
        else
            Console.WriteLine("Key 4 nuk ekziston");

        if (kundeDictionary.TryGetValue(2, out var kunde2Found))
            Console.WriteLine(kunde2Found);
        else
            Console.WriteLine("Key 2 nuk ekziston");

        Console.WriteLine("\nTë gjithë klientët në dictionary:");
        foreach (var pair in kundeDictionary)
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
    }
}