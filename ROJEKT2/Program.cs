Console.WriteLine("Zadaj prve cislo: ");
int cislo1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhe cislo:");
int cislo2 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operaciu (+, -, *, /, %):");
string operacia = Console.ReadLine();

int vysedlok = operacia switch
{
    "+" => (cislo1 + cislo2),
    "*" => (cislo1 * cislo2),
    "/" => (cislo1 / cislo2),
    "%" => (cislo1 % cislo2),
};
Console.WriteLine($"Vysledok je: {vysedlok}");
Console.WriteLine("Stlac ENTER pre spustenie kalkulacky");
Console.ReadLine();
System.Diagnostics.Process.Start("kalkulacka.exe");
System.Environment.Exit(0);




// nacitam prve cslo
//nacitam operaciu
//nacitam druhe cislo
//vypisem vypisem operaciu
//vypisem vysledok



