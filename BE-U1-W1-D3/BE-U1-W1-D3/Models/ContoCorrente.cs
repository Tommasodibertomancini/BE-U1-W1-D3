namespace BE_U1_W1_D3.Models
{
    public class ContoCorrente
    {
        public string Intestatario { get; set; }
        public decimal Saldo { get; set; }
        public bool Aperto;

        public ContoCorrente(string intestatario)
        {
            Intestatario = intestatario;
            Aperto = false;
            Saldo = 0;
        }

        public void ApriConto(decimal depositoIniziale)
        {
            if (Aperto)
            {
                Console.WriteLine("Il conto è già aperto");
                return;
            }

            if (depositoIniziale < 1000)
            {
                Console.WriteLine("Il deposito iniziale deve essere di almeno 1000 euro!");
                return;
            }

            Saldo = depositoIniziale;
            Aperto = true;
            Console.WriteLine($"Conto aperto con successo! \nSaldo iniziale: {Saldo} Euro");
        }

        public void Versamento(decimal importo)
        {
            if (!Aperto)
            {
                Console.WriteLine("Il conto non è aperto");
                return;
            }
            if (importo <= 0)
            {
                Console.WriteLine("L'importo deve essere maggiore di 0");
                return;
            }
            Saldo += importo;
            Console.WriteLine($"Versamento di {importo} Euro effettuato con successo! \nSaldo attuale: {Saldo} Euro");
        }

        public void Prelievo(decimal importo)
        {
            if (!Aperto)
            {
                Console.WriteLine("Il conto non è aperto");
                return;
            }
            if (importo <= 0)
            {
                Console.WriteLine("L'importo deve essere maggiore di 0");
                return;
            }
            if (Saldo < importo)
            {
                Console.WriteLine("Saldo insufficiente");
                return;
            }
            Saldo -= importo;
            Console.WriteLine($"Prelievo di {importo} Euro effettuato con successo! \nSaldo attuale: {Saldo} Euro");

        }

    }
}