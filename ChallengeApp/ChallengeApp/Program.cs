int number = 4566;
string numberInString = number.ToString(); //przekształcenie w zmienną typu string
char[] letters = numberInString.ToArray(); //każda cyfra ze zmiennej numberInString wrzucona do osobnej, kolejnej komorki tablicy letters
var counter = 0;


for (int i = 0; i < 10; i++)
{
    foreach (char digit in letters)
    {
        if (digit.ToString() == i.ToString())
        {
            counter++;
        }
    }
    Console.WriteLine(i + "=> " + counter);
    counter = 0;
}
