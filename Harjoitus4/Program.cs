using Harjoitus4;
internal class Program
{
    private static void Main(string[] args)
    {
        Albumi albumi = new Albumi("Thriller", "Michael Jackson", "mom", 3.89F);
        albumi.LisaaKappale("Wanna Be Startin' Somethin'", 6.03F);
        albumi.LisaaKappale("Baby Be Mine", 4.20F);
        albumi.LisaaKappale("The Girl Is Mine", 3.42F);
        albumi.LisaaKappale("Thriller", 5.57F);
        albumi.LisaaKappale("Beat It", 4.18F);
        albumi.LisaaKappale("Billie Jean", 4.54F);
        albumi.LisaaKappale("Human Nature", 4.06F);
        albumi.LisaaKappale("P.Y.T (Pretty Young Thug)", 3.59F);
        albumi.LisaaKappale("The Lady in My Life", 5F);
        albumi.TulostaTiedot();
    }
}