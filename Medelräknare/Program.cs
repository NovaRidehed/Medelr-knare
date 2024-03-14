namespace Medelräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antaltal = 0;
            double summa = 0;
            
            while (true)
            {
                Console.Write("Skriv ett heltal: ");
                string talstring = Console.ReadLine();
                int tal = int.Parse(talstring);
                antaltal++;
                summa = summa + tal;
                double medelvärde = summa / antaltal;
                Console.WriteLine("Medelvärde: " + medelvärde);
            }
            
        }
    }
}