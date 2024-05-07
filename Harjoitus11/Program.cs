using Harjoitus11;
internal class Program
{
    static Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();
    private static void Main(string[] args)
    {
        Lisää("Matti", "Nykänen", "DATV2022", 1);
        Lisää("Maija", "Meikäläinen", "DATV2022", 2);
        Lisää("Heikki", "Heinonen", "DATV2022", 3);
        Poista("Maija");
    }
    private static void Lisää(string etunimi, string sukunimi, string ryhtmätunnus, int id)
    {
        opiskelijat.Add(etunimi, new Opiskelija(etunimi, sukunimi, ryhtmätunnus, id));
    }
    private static void Poista(string etunimi)
    {
        opiskelijat.Remove(etunimi);
    }
}