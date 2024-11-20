// See https://aka.ms/new-console-template for more information
Console.WriteLine("Random Hobby Generator");
/*
    "OPPGAVE: Random Hobby Generator
    Ved å bruke det du har lært til nå, lag en konsoll applikasjon sin 
    tildeler en person en random hobby.

    Skriv navn inn i konsollen, la en funksjon trekke en tilfeldig hobby
    - og vis dette sammen med navnet i konsollviduet.

    La det være 3 - 5  forskjellige hobbyer som kan trekkes."
 */

Console.WriteLine("Welcome!");
Console.WriteLine("Who would like a new hobby?");
string name = Console.ReadLine();
string randomHobby = GetRandomHobby();

Console.WriteLine($"Hello {name}! Your new hobby is {randomHobby}.");
Console.WriteLine("Have fun!");

string GetRandomHobby()
{
    Random random = new Random();
    int randomNr = random.Next(0, 8);

    switch (randomNr)
    {
        case 1:
            return "horseback riding, but on unicorns";
        case 2:
            return "mining for gold and colorful gems";
        case 3:
            return "luring men to a watery death";
        case 4:
            return "baking cookies for your grandma. The one with the really big and really sharp teeth.";
        case 5:
            return "making grown men cry";
        case 6:
            return "dragon watching. Like bird watching, but with dragons";
        case 7:
            return "dancing with the forest folk";
        default:
            return "you don't get a new hobby"; // skal ikke skje, men for sikkerhetsskyld? Gir error uten default.
    }
}
