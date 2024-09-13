Console.WriteLine("Zadej velikost čtverce:");
int ctverec = Convert.ToInt32(Console.ReadLine());

if (ctverec == 1)
{
    Console.WriteLine("*");
}

else
{
    string mezera = new string(' ', ctverec - 2);
    string hvezda = "*";
    string strana = new string('*', ctverec);

    Console.WriteLine(strana);
    for (int j = 0; j < ctverec - 2; j++)
    {
        Console.WriteLine(hvezda + mezera + hvezda);
    }
    Console.WriteLine(strana);
}