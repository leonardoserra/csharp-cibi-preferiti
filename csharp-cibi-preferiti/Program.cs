// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ecco la lista dei miei cibi preferiti: ");

// creo array di stringhe coi cibi preferiti
string[] favouriteFood = { "Pizza", "Lasagne", "Orata", "Filetto al pepe verde", "Caprese", "Carbonara", "Pollo Arrosto", "Ramen", "Kebab" };

//Stampo la lunghezza dell'array
Console.WriteLine("\nAttualmente nella lista ci sono " + favouriteFood.Length + " pietanze.");

//ciclo l'array per stampare la lista
for (int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine("Posizione n." + (i + 1) +  " " + favouriteFood[i]);
}

//stampo la primo e l'ultima pietanza
Console.WriteLine("\nIl mio cibo preferito é " + favouriteFood[0]+ "! Buonissima!");
Console.WriteLine("\nL'ultima pietanza della lista é " + favouriteFood[favouriteFood.Length - 1] + "! Buono lo stesso :)");


//bonus : stampo la pietanza mediana
Console.WriteLine("\nBONUS: Alla posizione centrale abbiamo: " + favouriteFood[(favouriteFood.Length/2) - 1] + ". Una bontá!");


Console.WriteLine("\nMade by Leonardo Serra classe 07");
