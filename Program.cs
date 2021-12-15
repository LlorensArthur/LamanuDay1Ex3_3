int result = 0;
string ajout = "";
while (ajout != "non")
{
    Console.WriteLine("Ecrivez un nombre à additionner et appuyez sur entrée.");
    result += int.Parse(Console.ReadLine());
    Console.WriteLine("Appuyez sur entrée pour continuer à rajouter un nombre.\nEcrivez non et appuyez sur entrée pour arrêter.");
    ajout = Console.ReadLine();
}
Console.WriteLine($"Le résultat final est {result}.");