using Kurssystem.Models;

namespace Kurssystem
{

    class Program
    {
        static void Main()
        {

            Kurs Kurs1 = new Kurs
            {
                Kursnummer = "Programmering 1",
                Titel = "Programmering C#, Grund",
                LängdVeckor = 10,
                DistansKurs = true,
                StartDatum = new DateTime(2025, 08, 18),
                SlutDatum = new DateTime(2025, 10, 17),

            };

            Kurs Kurs2 = new Kurs
            {
                Kursnummer = "Programmering 2",
                Titel = "Programmering C# Fortsättning",
                LängdVeckor = 11,
                DistansKurs = true,
                StartDatum = new DateTime(2025, 11, 24),
                SlutDatum = new DateTime(2026, 02, 13),

            };


            var Studenter = new List<Studerande>
            {

                new Studerande

                {
                 Förnamn = "Edmond",
                 Efternamn = "Neziri",
                 Personnummer = "060512",
                 Telefon = "076-444-89-88",
                 Adress = "Södervärnvägen 4A",
                 Postnummer = "233 34",
                 Ort = "Malmö",
                },

                new Studerande
                {
                  Förnamn = "Moa",
                  Efternamn = "Sjöström",
                  Personnummer = "050522",
                  Telefon = "075-663-54-44",
                  Adress = "Lingonvägen 5C",
                  Postnummer = "214 26",
                  Ort = "malmö",
                },

                new Studerande
                {
                    Förnamn = "Kevin",
                    Efternamn = "lindgren",
                    Personnummer = "060222",
                    Telefon = "070-445-32-32",
                    Adress = "Sjöströmgatan 3A",
                    Postnummer = "214 34",
                    Ort = "Malmö",
                },

                new Studerande
                {
                    Förnamn = "Jonathan",
                    Efternamn = "kvist",
                    Personnummer = "060524",
                    Telefon = "075-556-45-45",
                    Adress = "Eriksfältgatan 1B",
                    Postnummer = "213 23",
                    Ort = "Malmlö",
                },
                new Studerande
                {
                    Förnamn = "Jonathan",
                    Efternamn = "Kvist",
                    Personnummer = "060512",
                    Telefon = "075-556-38-41",
                    Adress = "Björkgatan 7B",
                    Postnummer = "213 10",
                    Ort = "Malmlö",
                },
                new Studerande
                {
                    Förnamn = "Filip",
                    Efternamn = "Andersson",
                    Personnummer = "040513",
                    Telefon = "072-341-19-27",
                    Adress = "Baravägen 7C",
                    Postnummer = "210 24",
                    Ort = "Oxie",
                },
                new Studerande
                {
                    Förnamn = "Lisa",
                    Efternamn = "Larsson",
                    Personnummer = "050416",
                    Telefon = "074-423-72-10",
                    Adress = "Hållsjögatan 6A",
                    Postnummer = "214 12",
                    Ort = "Trelleborg",
                },
                new Studerande
                {
                    Förnamn = "Wiliam",
                    Efternamn = "Svensson",
                    Personnummer = "060416",
                    Telefon = "074-423-74-13",
                    Adress = "Sjöjungsgatan 6",
                    Postnummer = "211 12",
                    Ort = "Malmö",
                },


            };

            Kurs1.Studenter.AddRange(Studenter);
            Kurs2.Studenter.AddRange(Studenter);


            Console.WriteLine("------------------------------------------------------------------------------------------------------");


            Lärare lärare = new Lärare
            
            {
                Förnamn = "Michael",
                Efternamn = "Gustavsson",
                Telefon = "070-342-34-67",
                Adress = "Kungsgatan 13",
                Postnummer = "209 14",
                Ort = "Umeå",
                Kunskapsområde = "Programmering",
                Anställningsdatum = new DateTime(2022, 1, 1)
                
            };


            lärare.AnsvarigaKurser.Add(Kurs1);


            Utbildningsledare ledare = new Utbildningsledare
            {
                Förnamn = "Marie",
                Efternamn = "Roy Amossen",
                Telefon = "073-432-34-24",
                Postnummer = "213 11",
                Adress = "Eriksonvägen 3B",
                Ort = "Malmö",
                Kunskapsområde = "Projektledare",
                Anställningsdatum = new DateTime(2022, 1, 1),
            };


            ledare.AnsvarigaKurser.Add(Kurs1);
            ledare.AnsvarigaKurser.Add(Kurs2);


            Administratör admin = new Administratör
            {
                Förnamn = "Ivana",
                Efternamn = "Westman",
                Telefon = "076 -554-66-88",
                Postnummer = "209 18",
                Adress = "Baltazargatan 1D",
                Ort = "Trelleborg",
                Kunskapsområde = "Skoladministration",
                Anställningsdatum = new DateTime(2016, 1, 1)

            };


            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Kurser");
            Console.ResetColor();

            Console.WriteLine(Kurs1.Presentera());
            Console.WriteLine(Kurs2.Presentera());
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nStudenter i Programmerings kurserna 1 och 2:");
            Console.ResetColor();

            foreach (var Studerande in Kurs1.Studenter)
            {
                Console.WriteLine(Studerande.Presentera());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;    
            Console.WriteLine("\nLärare:");
            Console.ResetColor();
            Console.WriteLine(lärare.Presentera());

            foreach (var Kurs in lärare.AnsvarigaKurser)
            {
                Console.WriteLine($"{Kurs.Titel}");
            }
                
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nUtbildningsledare:");
            Console.ResetColor();
            Console.WriteLine(ledare.Presentera());  

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAdministratör:");
            Console.ResetColor();
            Console.WriteLine(admin.Presentera());
            Console.WriteLine("\n");


            Console.WriteLine("\nLägg till en ny student?:");
            
            Console.Write("Förnman:");
            string SF = Console.ReadLine() ?? "";
            Console.Write("Efternamn:");
            string SE = Console.ReadLine() ?? "";
            Console.Write("Personnummer:");
            string SP = Console.ReadLine() ?? "";
            Console.Write("Telefon:");
            string ST = Console.ReadLine() ?? "";
            Console.Write("Adress:");
            string SA = Console.ReadLine() ?? "";
            Console.Write("Postnummer:");
            string SPN = Console.ReadLine() ?? "";
            Console.Write("Ort:");
            string SO = Console.ReadLine() ?? "";


            var nyStudent = new Studerande
            {
                Förnamn = SF,
                Efternamn = SE,
                Personnummer = SP,
                Telefon = ST,
                Adress = SA,
                Postnummer = SPN,
                Ort = SO,
            };


            Kurs1.Studenter.Add(nyStudent);
            Kurs2.Studenter.Add(nyStudent);


            Console.WriteLine("\nLägg till en ny lärare?:");

            Console.Write("Förnman:");
            string LF = Console.ReadLine() ?? "";
            Console.Write("Efternamn:");
            string LE = Console.ReadLine() ?? "";
            Console.Write("Telefon:");
            string LT = Console.ReadLine() ?? "";
            Console.Write("Postnummer:");
            string LPN = Console.ReadLine() ?? "";
            Console.Write("Adress:");
            string LA = Console.ReadLine() ?? "";
            Console.Write("Ort:");
            string LO = Console.ReadLine() ?? "";
            Console.Write("Kunskapsområde:");
            string LK = Console.ReadLine() ?? "";

            var nyLärare = new Lärare
            {
                Förnamn = LF,
                Efternamn = LE,
                Telefon = LT,
                Postnummer = LPN,
                Adress = LA,
                Ort = LO,
                Kunskapsområde = LK,
                Anställningsdatum = DateTime.Now
            };


            Console.WriteLine("\nLägg till en ny utbildningsledare?:");

            Console.Write("Förnman:");
            string UF = Console.ReadLine() ?? "";
            Console.Write("Efternamn:");
            string UE = Console.ReadLine() ?? "";
            Console.Write("Telefon:");
            string UT = Console.ReadLine() ?? "";
            Console.Write("Postnummer:");
            string UPN = Console.ReadLine() ?? "";
            Console.Write("Adress:");
            string UA = Console.ReadLine() ?? "";
            Console.Write("Ort:");
            string UO = Console.ReadLine() ?? "";
            Console.Write("Kunskapsområde:");
            string UK = Console.ReadLine() ?? "";

            var nyUtbildningsledare = new Utbildningsledare
            {
                Förnamn = UF,
                Efternamn = UE,
                Telefon = UT,
                Postnummer = UPN,
                Adress = UA,
                Ort = UO,
                Kunskapsområde = UK,
                Anställningsdatum = DateTime.Now
            };


            Console.WriteLine("\nLägg till en ny administratör?:");
            
           Console.Write("Förnman:");
            string AF = Console.ReadLine() ?? "";
            Console.Write("Efternamn:");
            string AE = Console.ReadLine() ?? "";
            Console.Write("Telefon:");
            string AT = Console.ReadLine() ?? "";
            Console.Write("Postnummer:");
            string APN = Console.ReadLine() ?? "";
            Console.Write("Adress:");
            string AA = Console.ReadLine() ?? "";
            Console.Write("Ort:");
            string AO = Console.ReadLine() ?? "";
            Console.Write("Kunskapsområde:");
            string AK = Console.ReadLine() ?? "";

            var nyAdmininstratör = new Administratör
            {
                Förnamn = AF,
                Efternamn = AE,
                Telefon = AT,
                Postnummer = APN,
                Adress = AA,
                Ort = AO,
                Kunskapsområde = AK,
                Anställningsdatum = DateTime.Now
            };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nUppdaterad information");
            Console.ResetColor();
            Console.WriteLine("\n");
            Console.WriteLine($"Ny student: {nyStudent.Presentera()}");
            Console.WriteLine($"Ny lärare: {nyLärare.Presentera()}");
            Console.WriteLine($"Ny utbildningsledare: {nyUtbildningsledare.Presentera()}");
            Console.WriteLine($"Ny administratör: {nyAdmininstratör.Presentera()}");


            Console.WriteLine("------------------------------------------------------------------------------------------------------");
 

        }

    }
}
