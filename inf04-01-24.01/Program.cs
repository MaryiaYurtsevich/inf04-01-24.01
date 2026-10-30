
//IDITE NAHUJ WSIE KROME ARTIOMA
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