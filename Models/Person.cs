namespace Kurssystem.Models
{
    public class Person
    {
        public string Förnamn { get; set; } = "";
        public string Efternamn { get; set; } = "";
        public string Personnummer { get; set; } = "";
        public string Telefon { get; set; } = "";
        public string Adress { get; set; } = "";
        public string Postnummer { get; set; } = "";
        public string Ort { get; set; } = "";

        public virtual string Presentera()
        {
            return $"{Förnamn} {Efternamn} {Personnummer} {Telefon} {Adress} {Postnummer} {Ort}";
        }
    }
}
