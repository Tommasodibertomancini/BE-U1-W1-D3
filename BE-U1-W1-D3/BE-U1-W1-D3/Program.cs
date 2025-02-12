using BE_U1_W1_D3.Models;


// Creo un nuovo Conto Corrente con intestatario "Marco Bianchi" e ne utilizzo i metodi
ContoCorrente conto1 = new("Marco Bianchi");
Console.WriteLine("Esercizio 1) Conto Corrente");
conto1.ApriConto(4000);
conto1.Versamento(500);
conto1.Prelievo(200);

Console.WriteLine("--------------------------");

// Cerco un candidato dalla lista di candidati nell'array
Console.WriteLine("Esercizio 2) Ricerca Nome");

RicercaNomi ricerca = new("Tommaso");
RicercaNomi ricerca2 = new("Gianmarco");

Console.WriteLine("--------------------------");

// Creo un Array che riceve come parametro la dimensione dell'array e lo riempie con numeri casuali, facendone la somma e la media aritmetica
Console.WriteLine("Esercizio 3) Array Numeri Casuali. Somma e media dei numeri");

SommaArray sommaMedia = new();
sommaMedia.CalcolaSommaEMedia();