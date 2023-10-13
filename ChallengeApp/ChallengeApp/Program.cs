string imie = "Ewa";
char plec = 'm';
int wiek = 44;

// Pierwsza opcja:
if (plec == 'k' && wiek < 30)
{
    Console.WriteLine("1.Kobieta poniżej 30 lat");
}
if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("1. Ewa, lat 33");
}
if (plec == 'm' && wiek < 18)
{
    Console.WriteLine("1. Niepełnoletni Mężczyzna");
}


// Druga opcja:
if (plec == 'k')
{
    if (wiek < 30)
    {
        Console.WriteLine("2. Kobieta poniżej 30 lat");
    }
    if (wiek == 33)
    {
        Console.WriteLine("2. Ewa, lat 33");
    }
}
else if (wiek < 18)
{
    Console.WriteLine("2. Niepełnoletni Mężczyzna");
}