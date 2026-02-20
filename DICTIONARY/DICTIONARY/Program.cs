
using DICTIONARY;
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        // Krijojmë dictionary
        Dictionary<int, Kunde> kundeDictionary = new Dictionary<int, Kunde>();

        // Krijojmë disa klientë
        Kunde kunde1 = new Kunde(2, "Anna");
        Kunde kunde2 = new Kunde(3, "Peter");

        // Shtojmë klientë në dictionary
        kundeDictionary.Add(1, new Kunde(1, "Ib"));
        kundeDictionary.Add(kunde1.Id, kunde1);
        kundeDictionary.Add(kunde2.Id, kunde2);

        Console.WriteLine("Dictionary:");



        if (kundeDictionary.ContainsKey(4))
            Console.WriteLine(kundeDictionary[4]);  // nuk do printojë gjë, sepse nuk ekziston

        // Kontrollojmë nëse ekziston key 3
        if (kundeDictionary.ContainsKey(3))
            Console.WriteLine("Gjendet klienti me key 3: " + kundeDictionary[3]);

        Console.WriteLine("\n--- Të gjithë klientët ---");
        // Kalojmë nëpër të gjithë elementët
        foreach (var keyValuePair in kundeDictionary)
        {
            Console.WriteLine("Key: " + keyValuePair.Key + " -> Value: " + keyValuePair.Value);
        }
    }
}
//Dictionary:
//Gjendet klienti me key 3: Id: 3, Name: Peter

//-- - Të gjithë klientët ---
//Key: 1->Value: Id: 1, Name: Ib
//Key: 2->Value: Id: 2, Name: Anna
//Key: 3->Value: Id: 3, Name: Peter