// See https://aka.ms/new-console-template for more information

/*
Esercizio di oggi sugli Array: Miei cibi preferiti
    Nome repo: csharp-cibi-preferiti
    Nome progetto csharp: csharp-cibi-preferiti
    Create un progetto App Console CibiPreferiti con Visual Studio.
    Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
    L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
    Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
    - La lunghezza della classifica
    - La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
    - Il vostro cibo top (prima posizione della classifica)
    - Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
    Le modalità di consegna sono le solite: repo GitHub, commit e push
    BONUS
    Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
    Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.
 */


Console.WriteLine("Ecco la lista dei miei cibi preferiti: ");

// creo array di stringhe coi cibi preferiti
string[] favouriteFood = { "Pizza", "Lasagne", "Filetto al pepe verde", "Orata", "Caprese", "Carbonara", "Pollo Arrosto", "Ramen", "Kebab" };

//Stampo la lunghezza dell'array
Console.WriteLine($"{Environment.NewLine}Attualmente nella lista ci sono { favouriteFood.Length} pietanze:{Environment.NewLine}");

//ciclo l'array per stampare la lista 
for (int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine($"\tPosizione n.{(i + 1)} {favouriteFood[i]}");
}
//stampo la prima e l'ultima pietanza
Console.WriteLine($"{Environment.NewLine}Vincitore e Sconfitto: ");
Console.WriteLine($"{Environment.NewLine}\tIl mio cibo preferito é { favouriteFood[0]}! Buonissima!");
Console.WriteLine($"\tL'ultima pietanza della lista é {favouriteFood[favouriteFood.Length - 1]}! Buono lo stesso :)");


//bonus : stampo la pietanza mediana, controllo se lista pari o dispari con output differente

if(favouriteFood.Length % 2 == 0)//se pari
{

    Console.WriteLine($"{Environment.NewLine}BONUS: Alla posizione centrale abbiamo 2 pietanze dal momento che la lista contiene un numero pari di elementi: ");
    Console.WriteLine($"\tPos.{((favouriteFood.Length / 2))}:{favouriteFood[(favouriteFood.Length / 2) - 1]}. Una bontá!");
    Console.WriteLine($"\tPos.{((favouriteFood.Length / 2) + 1)}:{favouriteFood[(favouriteFood.Length / 2)]}. Yum!");
}
else //se dispari
{
    Console.WriteLine($"{Environment.NewLine}BONUS: Alla posizione centrale abbiamo 1 pietanza dal momento che la lista contiene un numero dispari di elementi: ");
    Console.WriteLine($"\tPos.{((favouriteFood.Length / 2) + 1)}:{favouriteFood[(favouriteFood.Length/2)]}. Una bontá!");
}

//firma
Console.WriteLine($"{Environment.NewLine}Made by Leonardo Serra classe 07");
