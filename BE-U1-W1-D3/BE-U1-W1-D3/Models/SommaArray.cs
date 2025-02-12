

namespace BE_U1_W1_D3.Models
{
    internal class SommaArray
    {
        public void CalcolaSommaEMedia()
        {
            Console.Write("Inserisci la dimensione dell'array: ");
            int dimensione = int.Parse(Console.ReadLine());
            int[] numeri = new int[dimensione];

            Random randomNum = new Random();
            for (int i = 0; i < dimensione; i++)
            {
                numeri[i] = randomNum.Next(1, 101);
                Console.WriteLine($"Numero generato: {numeri[i]}");
            }

            int somma = 0;
            foreach (int numero in numeri)
            {
                somma += numero;
            }

            double media = (double)somma / dimensione;

            Console.WriteLine($"La somma degli elementi è: {somma}");
            Console.WriteLine($"La media degli elementi è: {media}");
        }
    }
}
