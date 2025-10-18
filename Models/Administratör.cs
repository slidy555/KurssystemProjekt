namespace Kurssystem.Models

{

    public class Administratör : Utbildningsledare
    
    {

        public override string Presentera()
        {
            return $"Administratör: {Förnamn} {Efternamn}\n" +
            $"Telefon: {Telefon}, Postnummer: {Postnummer}, Ort: {Ort}\n" +
            $"Kunskapsområde: {Kunskapsområde}\n" +
            $"Anställd sedan: {Anställningsdatum.ToShortDateString()}";

        }

    }

}

