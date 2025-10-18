
namespace Kurssystem.Models
{
    public class Lärare : Person
    {
        public string Kunskapsområde { get; set; } = "";
        public DateTime Anställningsdatum { get; set; } 
        public List<Kurs> AnsvarigaKurser { get; set; } = new List<Kurs>();

        public override string Presentera()
        {
            return $"Lärare: {Förnamn} {Efternamn}\n" +
            $"Kunskapsområde: {Kunskapsområde}, Telefon: {Telefon}\n" +
            $"Address: {Adress}, Postnummer: {Postnummer}, Ort: {Ort}\n" +
            $"Anställd sedan: {Anställningsdatum.ToShortDateString()}";
        }
    }
}
