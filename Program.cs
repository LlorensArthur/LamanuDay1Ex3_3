int result = 0;
string ajout = "";
while (ajout != "non")
{
    Console.WriteLine("Ecrivez un nombre à additionner");
    result += int.Parse(Console.ReadLine());
    Console.WriteLine("Voulez-vous rajouter un nombre?");
    ajout = Console.ReadLine();
}
Console.WriteLine($"Le résultat final est {result}.");