// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ecco la lista dei miei cibi preferiti: ");
string newLine = Environment.NewLine;
// creo array di stringhe coi cibi preferiti
string[] favouriteFood = { "Pizza", "Lasagne", "Filetto al pepe verde", "Orata", "Caprese", "Carbonara", "Pollo Arrosto", "Ramen", "Kebab" };

//Stampo la lunghezza dell'array
Console.WriteLine($"{newLine}Attualmente nella lista ci sono { favouriteFood.Length} pietanze.");

//ciclo l'array per stampare la lista
for (int i = 0; i < favouriteFood.Length; i++)
{
    Console.WriteLine($"Posizione n.{(i + 1)} {favouriteFood[i]}");
}

//stampo la primo e l'ultima pietanza
Console.WriteLine($"{newLine}Il mio cibo preferito é { favouriteFood[0]}! Buonissima!");
Console.WriteLine($"{newLine}L'ultima pietanza della lista é {favouriteFood[favouriteFood.Length - 1]}! Buono lo stesso :)");


//bonus : stampo la pietanza mediana, controllo se lista pari o dispari con output differente
if(favouriteFood.Length % 2 == 0){

    Console.WriteLine($"{newLine}BONUS: Alla posizione centrale abbiamo 2 pietanze dal momento che la lista contiene un numero pari di elementi: ");
    Console.WriteLine($"{newLine}Pos.{((favouriteFood.Length / 2))}:{favouriteFood[(favouriteFood.Length / 2) - 1]}. Una bontá!");
    Console.WriteLine($"Pos.{((favouriteFood.Length / 2) + 1)}:{favouriteFood[(favouriteFood.Length / 2)]}. Yum!");
}
else
{
    Console.WriteLine($"{newLine}BONUS: Alla posizione centrale abbiamo 1 pietanza dal momento che la lista contiene un numero dispari di elementi: ");
    Console.WriteLine($"Pos.{((favouriteFood.Length / 2) + 1)}:{favouriteFood[(favouriteFood.Length/2)]}. Una bontá!");
}


Console.WriteLine($"{newLine}Made by Leonardo Serra classe 07");
