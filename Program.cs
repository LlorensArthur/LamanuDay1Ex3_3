int result = 0;
int toAdd;
string endString = "";
// Boucle de saisie utilisateur
while (endString != "non")
{
    Console.WriteLine("Ecrivez un nombre à additionner et appuyez sur entrée.");
    while (!int.TryParse(Console.ReadLine(), out toAdd))
    {
        Console.WriteLine("Veuillez entrer uniquement un nombre.");
    }
    result += toAdd;
    Console.WriteLine("Appuyez sur entrée pour continuer à rajouter un nombre.\nEcrivez non et appuyez sur entrée pour arrêter.");
    endString = Console.ReadLine();
}
// Affichage du résultat final
Console.WriteLine($"Le résultat final est {result}.");