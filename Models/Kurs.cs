namespace Kurssystem.Models

{
    public class Kurs

    {

        public string Kursnummer { get; set; } = "";
        public string Titel { get; set; } = "";
        public int LängdVeckor { get; set; }
        public bool DistansKurs { get; set; }
        public DateTime StartDatum{ get; set; }
        public DateTime SlutDatum{ get; set; }

        public List<Studerande> Studenter { get; set; } = new List<Studerande>();

        public string Presentera()
        {

            String typ = DistansKurs ? "Distanskurs" : "Klassrusmskurs";
            return $"{Kursnummer} - {Titel}, Längd: {LängdVeckor} veckor, Typ :{typ}," +
            $" Start: {StartDatum.ToShortDateString()}, Slut: {SlutDatum.ToShortDateString()}";
             

        }

    }
}