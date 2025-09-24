
Console.WriteLine("ako sa volas?");
string ? meno = Console.ReadLine();
Console.WriteLine($"Ahoj {meno} Kolko mas rokov?");
int vek = int.Parse(Console.ReadLine());
Console.WriteLine($"AHA mas teda {vek} rokov");
Console.WriteLine("ake je tvoje oblubene jedlo ?");
string jedlo = Console.ReadLine();
Console.WriteLine($" hmm {jedlo} znie skvele");
Console.WriteLine("stlac klavesu :");
var key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine($"stlacili ste klavesu: {key.KeyChar}");








