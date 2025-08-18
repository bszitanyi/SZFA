namespace sztf2.Interfeszek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEladható[] termekek = new IEladható[4];
            termekek[0] = new Autó("ABC-123", "Mazda", 1000);
            termekek[1] = new Autó("ABC-321", "Suzuki", 1000);
            termekek[2] = new MobilTelefon("Apple Iphone X", true);
            termekek[3] = new MobilTelefon("Samsung Galaxy SY", false);

            foreach (var item in termekek)
            {
                Console.WriteLine(item.Ar);
            }

            Autó[] autok = new Autó[4];
            autok[0] = new Autó("ABC-123", "Mazda", 1800);
            autok[1] = new Autó("PPP-420", "Suzuki", 1000);
            autok[2] = new Autó("ASD-069", "Golf", 1900);
            autok[3] = new Autó("GRF-568", "Insignia", 1600);

            Array.Sort(autok);
        }
    }
}
