// See https://aka.ms/new-console-template for more information
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

//stampo la primo e l'ultima pietanza
Console.WriteLine($"{Environment.NewLine}Vincitore e Sconfitto: ");
Console.WriteLine($"{Environment.NewLine}\tIl mio cibo preferito é { favouriteFood[0]}! Buonissima!");
Console.WriteLine($"\tL'ultima pietanza della lista é {favouriteFood[favouriteFood.Length - 1]}! Buono lo stesso :)");


//bonus : stampo la pietanza mediana, controllo se lista pari o dispari con output differente
if(favouriteFood.Length % 2 == 0){

    Console.WriteLine($"{Environment.NewLine}BONUS: Alla posizione centrale abbiamo 2 pietanze dal momento che la lista contiene un numero pari di elementi: ");
    Console.WriteLine($"\tPos.{((favouriteFood.Length / 2))}:{favouriteFood[(favouriteFood.Length / 2) - 1]}. Una bontá!");
    Console.WriteLine($"\tPos.{((favouriteFood.Length / 2) + 1)}:{favouriteFood[(favouriteFood.Length / 2)]}. Yum!");
}
else
{
    Console.WriteLine($"{Environment.NewLine}BONUS: Alla posizione centrale abbiamo 1 pietanza dal momento che la lista contiene un numero dispari di elementi: ");
    Console.WriteLine($"\tPos.{((favouriteFood.Length / 2) + 1)}:{favouriteFood[(favouriteFood.Length/2)]}. Una bontá!");
}


Console.WriteLine($"{Environment.NewLine}Made by Leonardo Serra classe 07");
