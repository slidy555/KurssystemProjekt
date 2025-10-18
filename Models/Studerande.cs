namespace Kurssystem.Models
{
    public class Studerande : Person
    {
        public override string Presentera()
        {
            return $"Student: {Förnamn} {Efternamn} - Personnummer: {Personnummer} {Telefon} {Adress} {Postnummer} {Ort}";
        }
    }
}
