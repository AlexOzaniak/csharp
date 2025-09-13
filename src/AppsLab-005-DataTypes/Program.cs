
Console.WriteLine("Hello, World!");
Console.WriteLine("Zadej cislo:");
int cislo = int.Parse(Console.ReadLine());

string text = "zdravicko";

bool pravda = true;

    
DateTime cas = DateTime.Now;
var pi = 3.14;
if(cislo <30)
{
    Console.WriteLine("zadane cislo je moc male prosim zadaj cislo ktore je vacsie ako 30");
  int number = int.Parse(Console.ReadLine());
    cislo = number;

}
Console.WriteLine ($"cislo je {cislo} text je {text} hodnota true or false je {pravda} {cas} hodnota pi je {pi} ");


