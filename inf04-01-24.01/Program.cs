
//
Console.WriteLine("Podaj numer PESEL: ");
string? pesel = Console.ReadLine();

if (pesel.Length < 11 || pesel.Length > 11)
{
    Console.WriteLine("Wpisz poprawny numer PESEL (11 cyfr)");
        return;
}
else
{
    Console.WriteLine("PESEL jest wpisany poprawnie");
}

//CYFRA KONTROLNA

int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

int S = 0;

for (int i = 0; i < 10; i++)
{
    S += int.Parse(pesel[i].ToString()) * wagi[i];
}

int M = S % 10;
int R = (10 - M) % 10;

int ostatniaCyfra = int.Parse(pesel[10].ToString());

Console.WriteLine("Cyfra kontrolna: " + R);
if (R == ostatniaCyfra)
{
    Console.WriteLine("Suma kontrolna jest poprawna");
}
else
{
    Console.WriteLine("Suma kontrolna jest niepoprawna");
}

int plec = int.Parse(pesel[9].ToString());
static char SprawdzPlec(int plec)
{
    if (plec % 2 == 0)
    {
        return 'K';
    }
    else
    {
        return 'M';
    }
}
//idu spac korocze