namespace BE_U1_W1_D3.Models
{
    public class RicercaNomi
    {
        public string[] Candidati = { "Gianni", "Luca", "Tommaso", "Filippo", "Paola", "Sandra" };

        public string CandidatoCercato { get; set; }

        public RicercaNomi(string candidatoCercato)
        {
            if (Candidati.Contains(candidatoCercato))
            {
                Console.WriteLine($"Il nome {candidatoCercato} è presente nella lista.");
            }
            else
            {
                Console.WriteLine($"Il nome {candidatoCercato} NON è presente nella lista.");
            }
        }
    }
}