int number = 4566;
string numberInString = number.ToString(); //przekształcenie w zmienną typu string
char[] letters = numberInString.ToArray(); //każda cyfra ze zmiennej numberInString wrzucona do osobnej, kolejnej komorki tablicy letters
var licznik = 0;


for (int i = 0; i < 10; i++)
{
    string iInString = i.ToString();
    foreach (char cyfra in letters)
    {
        if (cyfra.ToString() == iInString)
        {
            licznik++;
        }
    }
    Console.WriteLine(iInString + "=> " + licznik);
    licznik = 0;
}