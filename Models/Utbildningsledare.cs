namespace Kurssystem.Models;

public class Utbildningsledare : Lärare
{
    public new DateTime Anställningsdatum { get; set; }

    public override string Presentera()
    {
        return $"Utbildningsledare: {Förnamn} {Efternamn}\n" +
        $"Kunskapsområde: {Kunskapsområde}, Telefon: {Telefon}\n" +
        $"Adress: {Adress}, Postnummer: {Postnummer}, Ort: {Ort}\n" +
        $"Anställd sedan: {Anställningsdatum.ToShortDateString()}";

    }
}

