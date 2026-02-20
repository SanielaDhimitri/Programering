using ClassLibrary4;
using ClassLibrary4.Rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejl
{
    public class SejlApp
    {
        private BådRep bådRepo;
        private VedligeholdRep vedRepo;
        private MedlemRep medlemRepo;
        private BegivenhedRep eventRepo;
        private BookingRep bookingRepo;
        private string beskrivelse;

        public void Run()
        {
            bådRepo = new BådRep();
            vedRepo = new VedligeholdRep();
            medlemRepo = new MedlemRep();
            eventRepo = new BegivenhedRep();

            bookingRepo = new BookingRep(
                bådRepo, vedRepo, medlemRepo, eventRepo
            );

            bool running = true;


            while (running)
            {
                Console.Clear();
                PrintMenu();

                string valg = Console.ReadLine();

                if (!int.TryParse(valg, out int nummer) || nummer < 0 || nummer > 23)
                {
                    Console.WriteLine("Ugyldigt valg!");
                    Console.ReadKey();
                    continue;
                }

                HandleChoice(nummer, ref running);

                if (running)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nTryk en tast for at vende tilbage til menuen...");
                    Console.ResetColor();
                    Console.ReadKey();


                }
            }
        }
        private void PrintMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("======================================");
            Console.WriteLine("        HILLERØD SEJLKLUB MENU        ");
            Console.WriteLine("======================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("1.  Vis alle både");
            Console.WriteLine("2.  Book en båd");
            Console.WriteLine("3.  Vis alle bookinger");
            Console.WriteLine("4.  Afslut en booking");
            Console.WriteLine("5.  Tilføj vedligeholdelse");
            Console.WriteLine("6.  Vis vedligeholdelse");
            Console.WriteLine("7.  Tilføj begivenhed");
            Console.WriteLine("8.  Vis begivenheder");
            Console.WriteLine("9.  Tilføj medlem");
            Console.WriteLine("10. Vis medlemmer");
            Console.WriteLine("11. Vis både fra 2012");
            Console.WriteLine("12. Vis medlemmerType:Junior.");
            Console.WriteLine("13. Vis årlig indtægt");
            Console.WriteLine("14. Vis hvem der er på tur lige nu");
            Console.WriteLine("15. Indtast båd ID der skal slettes");
            Console.WriteLine("16. Søg efter medlem via navn");
            Console.WriteLine("17. Søg efter medlem via Email");
            Console.WriteLine("18. Fjern Medlem");
            Console.WriteLine("19. Vis seneste vedligeholdelse for båd");
            Console.WriteLine("20. Find begivenhed via ID");
            Console.WriteLine("21. Book begivenhed");
            Console.WriteLine("22. Kontroller om en båd er optaget");
            Console.WriteLine("23. Vis antal tilmeldte til en begivenhed");
            Console.WriteLine("0. Afslut program");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Vælg fra 1-23: ");
            Console.ResetColor();

        }

        private void HandleChoice(int nummer, ref bool running)
        {
            switch (nummer)//logik
            {

                case 1:  // = hvis nummer er 1
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=== ALLE BÅDE ===");
                        Console.ResetColor();

                        foreach (var båd in bådRepo.GetAll())
                        { Console.WriteLine(båd); }


                        break;//stopper switch efter case 1
                    }
                case 2:
                    {
                        try
                        {
                            // ===== Båd ID =====
                            int bookingBådId;
                            while (true)
                            {
                                Console.Write("Båd ID: ");
                                if (int.TryParse(Console.ReadLine(), out bookingBådId) && bådRepo.Exist(bookingBådId))
                                    break;

                                Console.WriteLine("Båd findes ikke eller forkert input!");
                            }

                            // ===== Medlem ID =====
                            int medlemIdBooking;
                            while (true)
                            {
                                Console.Write("Medlem ID: ");
                                if (int.TryParse(Console.ReadLine(), out medlemIdBooking) && medlemRepo.Exists(medlemIdBooking))
                                    break;

                                Console.WriteLine("Medlem findes ikke eller forkert input!");
                            }

                            // ===== START DATO + TID =====
                            DateTime startTid;
                            while (true)
                            {
                                Console.Write("Start dato og tid (dd-MM-yyyy HH:mm): ");
                                string input = Console.ReadLine();

                                if (DateTime.TryParseExact(
                                        input,
                                        "dd-MM-yyyy HH:mm",
                                        System.Globalization.CultureInfo.InvariantCulture,
                                        System.Globalization.DateTimeStyles.None,
                                        out startTid) &&
                                    startTid >= DateTime.Now.AddMinutes(-1))
                                {
                                    break;
                                }

                                Console.WriteLine("Forkert format eller start-tid er i fortiden.");
                            }

                            // ===== SLUT DATO + TID =====
                            DateTime slutTid;
                            while (true)
                            {
                                Console.Write("Slut dato og tid (dd-MM-yyyy HH:mm): ");
                                string input = Console.ReadLine();

                                if (DateTime.TryParseExact(
                                        input,
                                        "dd-MM-yyyy HH:mm",
                                        System.Globalization.CultureInfo.InvariantCulture,
                                        System.Globalization.DateTimeStyles.None,
                                        out slutTid) &&
                                    slutTid > startTid)
                                {
                                    break;
                                }

                                Console.WriteLine("Slut-tid skal være efter start-tid.");
                            }

                            // ===== Destination =====
                            Console.Write("Destination: ");
                            string dest = Console.ReadLine();

                            // ===== Book =====
                            Booking b = bookingRepo.BookBåd(
                                bookingBådId,   // KORREKT
                                medlemIdBooking,
                                startTid,
                                slutTid,
                                dest
                            );

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Booking gennemført!");
                            Console.WriteLine($"Booking ID: {b.BookingId}");
                            Console.ResetColor();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fejl: " + ex.Message);
                            Console.ResetColor();
                        }

                        break;
                    }





                case 3:
                    {
                        Console.WriteLine("=== ALLE BOOKINGER ===");
                        try
                        {
                            foreach (var bk in bookingRepo.GetAll())
                            {
                                Console.WriteLine(bk);
                                Console.WriteLine("----------------------------------");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }
                        break;
                    }
                case 4:
                    {
                        Console.Write("Indtast booking ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int bookingId))//ConsoleReadLine læser input og prøver at konvertere det til et heltal ved hjælp af int.TryParse--out int bookingId=gem tallet i bookingId.”
                        {
                            Console.WriteLine("Booking ID skal være et tal!");
                            break;
                        }

                        try
                        {
                            bookingRepo.AfslutBooking(bookingId);//kalder metoden AfslutBooking i bookingRepo-objektet og sender bookingId som parameter
                            Console.WriteLine("Booking afsluttet.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }
                        break;


                    }
                case 5:
                    {
                        Console.Write("Båd ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int bådIdV))//ConsoleReadLine læser input og prøver at konvertere det til et heltal ved hjælp af int.TryParse--out int bådIdV=gem tallet i bådIdV.”

                        {
                            Console.WriteLine("Båd ID skal være et tal!");
                            break;
                        }

                        Båd bådV = bådRepo.FindById(bådIdV);//kalder metoden FindById i bådRepo-objektet og sender bådIdV som parameter
                        if (bådV == null)
                        {
                            Console.WriteLine("Båd findes ikke!");
                            break;
                        }

                        Console.Write("Kommentar: ");
                        string kommentar = Console.ReadLine();

                        //ja og nej 
                        bool erOk;

                        while (true)
                        {
                            Console.Write("Er båden OK? (ja/nej): ");
                            string svar = Console.ReadLine();//læser input

                            if (svar == "ja")
                            {
                                erOk = true;
                                break;
                            }
                            else if (svar == "nej")
                            {
                                erOk = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ugyldigt input! Skriv kun 'ja' eller 'nej'.");
                            }
                        }


                        Vedligeholdelse v = new Vedligeholdelse( DateTime.Now, beskrivelse, erOk);
                        vedRepo.Add(v);//kalder metoden Add i vedRepo-objektet og sender v som parameter
                        Console.WriteLine("Vedligeholdelse tilføjet!");
                        break;
                    }

                case 6:
                    {
                        Console.WriteLine("=== VEDLIGEHOLDELSE ===");
                        try
                        {
                            foreach (var s in vedRepo.GetAll())
                            {
                                Console.WriteLine(s);
                                Console.WriteLine("----------------------------------");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }
                        break;
                    }

                case 7:
                    {
                        try
                        {
                            Console.Write("Navn på begivenhed: ");
                            string navn = Console.ReadLine();

                            // ===== Begivenheds ID (kun tal) =====
                            int eventId;
                            while (true)
                            {
                                Console.Write("Begivenheds ID: ");
                                if (int.TryParse(Console.ReadLine(), out eventId))
                                    break;

                                Console.WriteLine("Begivenheds ID skal være et tal!");
                            }

                            Console.Write("Sted: ");
                            string sted = Console.ReadLine();

                            Console.Write("Dato og tid (fx 12-12-2025 18:30): ");
                            DateTime datoMedTid = DateTime.Parse(Console.ReadLine());//DateTime.Parse=text til nr

                            Begivenhed nyEvent = new Begivenhed(navn, eventId, sted, datoMedTid);
                            eventRepo.Add(nyEvent);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Begivenhed tilføjet!");
                            Console.ResetColor();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fejl: " + ex.Message);
                            Console.ResetColor();
                        }

                        break;
                    }

                case 8:
                    {
                        Console.WriteLine("=== ALLE BEGIVENHEDER ===");

                        try
                        {
                            foreach (var e in eventRepo.GetAll())
                            {
                                Console.WriteLine(e);
                                Console.WriteLine("----------------------------------");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }
                        break;
                    }

                case 9:
                    {
                        try
                        {
                            // ===== Medlem ID =====
                            int medlemId9;
                            while (true)
                            {
                                Console.Write("Medlem ID: ");
                                if (int.TryParse(Console.ReadLine(), out medlemId9))
                                    break;

                                Console.WriteLine("Kun tal!");
                            }

                            string medlemNavn9;
                            while (true)
                            {
                                Console.Write("Navn: ");
                                medlemNavn9 = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(medlemNavn9))
                                    break;

                                Console.WriteLine("Navn må ikke være tomt!");
                            }
                            string medlemAdresse9;
                            while (true)
                            {
                                Console.Write("Adresse: ");
                                medlemAdresse9 = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(medlemAdresse9))
                                    break;

                                Console.WriteLine("Adresse må ikke være tom!");
                            }


                            // ===== Email =====
                            string medlemEmail9;
                            while (true)
                            {
                                Console.Write("Email: ");
                                medlemEmail9 = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(medlemEmail9) && medlemEmail9.Contains("@"))
                                    break;

                                Console.WriteLine("Email skal indeholde @");
                            }

                            // ===== Telefon =====
                            string medlemTelefon9;
                            while (true)
                            {
                                Console.Write("Telefon: ");
                                medlemTelefon9 = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(medlemTelefon9) && medlemTelefon9.All(char.IsDigit))
                                    break;

                                Console.WriteLine("Kun tal!");
                            }


                            // ===== Medlemstype =====
                            Console.WriteLine("Vælg medlemstype:");
                            Console.WriteLine("1. Junior (750 kr)");
                            Console.WriteLine("2. Senior (1100 kr)");
                            Console.WriteLine("3. Familie (1500 kr)");
                            Console.WriteLine("4. Bådplads (400 kr)");

                            int valg9;
                            while (true)
                            {
                                Console.Write("Vælg (1-4): ");
                                if (int.TryParse(Console.ReadLine(), out valg9) && valg9 >= 1 && valg9 <= 4)
                                    break;

                                Console.WriteLine("Forkert valg!");
                            }

                            string medlemsType9 = "";
                            int betaltBeløb9 = 0;

                            switch (valg9)
                            {
                                case 1: medlemsType9 = "Junior"; betaltBeløb9 = 750; break;
                                case 2: medlemsType9 = "Senior"; betaltBeløb9 = 1100; break;
                                case 3: medlemsType9 = "Familie"; betaltBeløb9 = 1500; break;
                                case 4: medlemsType9 = "Bådplads"; betaltBeløb9 = 400; break;
                            }

                            DateTime betaltDato9 = DateTime.Today;

                            // ===== Opret medlem =====
                            Medlem nytMedlem9 = new Medlem(
                                medlemId9,
                                medlemNavn9,
                                medlemAdresse9,
                                medlemEmail9,
                                medlemTelefon9,
                                medlemsType9,
                                betaltBeløb9,
                                betaltDato9
                            );

                            medlemRepo.Add(nytMedlem9);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Medlem oprettet!");
                            Console.ResetColor();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fejl: " + ex.Message);
                            Console.ResetColor();
                        }

                        break;
                    }

                case 10:
                    {
                        Console.WriteLine("=== ALLE MEDLEMMER ===");

                        try
                        {
                            foreach (var m in medlemRepo.GetAll())
                            {
                                Console.WriteLine(m);
                                Console.WriteLine("----------------------------------");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }

                        break;
                    }


                case 11:
                    {
                        Console.WriteLine("=== BÅDE FRA 2012 ===");

                        List<Båd> både2012 = bådRepo.FilterByByggeÅr(2012);

                        foreach (Båd båd in både2012)
                        {
                            Console.WriteLine(båd);
                        }

                        break;
                    }

                case 12:
                    {
                        Console.WriteLine("=== MEDLEMMER AF TYPEN JUNIOR ===");

                        foreach (Medlem m in medlemRepo.FilterByMedlemType("Junior"))
                        {
                            Console.WriteLine(m);
                            Console.WriteLine("------------------");
                        }
                        break;
                    }

                case 13:
                    {
                        int år = DateTime.Now.Year;

                        Console.WriteLine("=== ÅRLIG INDTÆGT ===");
                        Console.WriteLine(
                            $"Total for {år}: {medlemRepo.GetTotalÅrligIndtægt(år)} kr"
                        );
                        break;
                    }



                case 14:

                    {
                        List<Booking> påTur = bookingRepo.HvemErPåTurNu();

                        if (påTur.Count == 0)
                        {
                            Console.WriteLine("Ingen er på tur lige nu.");
                        }
                        else
                        {
                            foreach (Booking b in påTur)
                            {
                                Console.WriteLine(
                                    $"{b.Medlem.Navn} sejler med {b.Båd.BådNavn} til {b.Destinacion}"
                                );
                            }
                        }
                        break;
                    }
                case 15:
                    {
                        Console.Write("Indtast båd ID der skal slettes: ");
                        if (!int.TryParse(Console.ReadLine(), out int bådIdToDelete))
                        {
                            Console.WriteLine("ID skal være et tal!");
                            break;
                        }

                        try
                        {
                            bådRepo.Remove(bådIdToDelete);
                            Console.WriteLine("Båd slettet.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }

                        break;
                    }




                case 16:
                    {
                        Console.Write("Indtast navn: ");
                        string navn = Console.ReadLine();

                        List<Medlem> fundet = medlemRepo.SearchByNavn(navn);

                        if (fundet.Count == 0)
                        {
                            Console.WriteLine("Ingen medlemmer fundet.");
                        }
                        else
                        {
                            foreach (Medlem m in fundet)
                            {
                                Console.WriteLine(m);
                                Console.WriteLine("----------------");
                            }
                        }
                        break;
                    }

                case 17:
                    {
                        Console.Write("Indtast email: ");
                        string email = Console.ReadLine();

                        List<Medlem> fundet = medlemRepo.SearchByEmail(email);

                        if (fundet.Count == 0)
                        {
                            Console.WriteLine("Ingen medlemmer fundet.");
                        }
                        else
                        {
                            foreach (Medlem m in fundet)
                            {
                                Console.WriteLine(m);
                                Console.WriteLine("----------------");
                            }
                        }
                        break;
                    }
                case 18:
                    {
                        Console.Write("Indtast medlem ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int medlemId))
                        {
                            Console.WriteLine("ID skal være et tal!");
                            break;
                        }

                        try
                        {
                            medlemRepo.Remove(medlemId);
                            Console.WriteLine("Medlem slettet.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }

                        break;
                    }

                case 19:
                    {
                        Console.Write("Indtast Båd ID: ");
                        int serviceBådId = int.Parse(Console.ReadLine());

                        Vedligeholdelse latest =
                            vedRepo.GetLatestServiceForBoat(serviceBådId);

                        if (latest == null)
                            Console.WriteLine("Ingen vedligeholdelse fundet.");
                        else
                            Console.WriteLine(latest);

                        break;
                    }

                case 20:
                    {
                        Console.Write("Indtast Begivenhed ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int begivenhedId))
                        {
                            Console.WriteLine("ID skal være et tal!");
                            break;
                        }

                        Begivenhed fundet = eventRepo.FindById(begivenhedId);

                        if (fundet == null)
                        {
                            Console.WriteLine("Begivenhed ikke fundet.");
                        }
                        else
                        {
                            Console.WriteLine("=== BEGIVENHED FUNDET ===");
                            Console.WriteLine(fundet);
                        }

                        break;
                    }
                case 21:
                    {
                        try
                        {
                            Console.Write("Begivenhed ID: ");
                            int begivenhedId = int.Parse(Console.ReadLine());

                            Console.Write("Båd ID: ");
                            int bådId = int.Parse(Console.ReadLine());

                            Console.Write("Medlem ID: ");
                            int medlemId = int.Parse(Console.ReadLine());

                            Booking booking =
                                bookingRepo.BookBegivenhed(begivenhedId, bådId, medlemId);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Du er nu tilmeldt begivenheden!");
                            Console.WriteLine(booking);
                            Console.ResetColor();
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Fejl: " + ex.Message);
                            Console.ResetColor();
                        }

                        break;
                    }


                case 22:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=== KONTROLLER OM EN BÅD ER OPTAGET ===");
                        Console.ResetColor();

                        Console.Write("Indtast Båd ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int bådId))
                        {
                            Console.WriteLine("Båd ID skal være et tal!");
                            break;
                        }

                        bool optaget = bookingRepo.ErBådBooketNu(bådId);

                        Console.WriteLine();
                        if (optaget)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Båden er på tur lige nu.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" Båden er ledig.");
                        }
                        Console.ResetColor();

                        break;
                    }
                case 23:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=== ANTAL TILMELDTE TIL BEGIVENHED ===");
                        Console.ResetColor();

                        Console.Write("Indtast Begivenhed ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int begivenhedId))
                        {
                            Console.WriteLine("ID skal være et tal!");
                            break;
                        }

                        try
                        {
                            Begivenhed begivenhed = eventRepo.FindById(begivenhedId);

                            int antal = bookingRepo.CountBookingsForBegivenhed(begivenhedId);

                            Console.WriteLine();
                            Console.WriteLine($"Begivenhed: {begivenhed.Navn}");
                            Console.WriteLine($"Antal tilmeldte: {antal}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Fejl: " + ex.Message);
                        }

                        break;
                    }


                case 0:
                    {
                        running = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Program afsluttes...");

                        break;
                    }
            }
        }

    }
}
//Menu = vetëm në while
//Logic = vetëm në switch
//Clear = vetëm në fillim
    

