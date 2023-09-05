// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ecco la lista dei miei cibi preferiti: ");
// creo array di stringhe coi cibi preferiti
string[] favouriteFood = { "Pizza", "Lasagne", "Orata", "Filetto al pepe verde", "Caprese", "Carbonara", "Ramen", "Kebab" };
Console.WriteLine("Attualmente nella lista ci sono " + favouriteFood.Length + " pietanze.");

for (int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine("Posizione n." + (i + 1) +  " " + favouriteFood[i]);
}

Console.WriteLine("Il mio cibo preferito é " + favouriteFood[0]+ "! Buono!");
Console.WriteLine("L'ultima pietanza della lista é " + favouriteFood[favouriteFood.Length - 1] + "! Buono lo stesso :)");
