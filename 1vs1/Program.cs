string HjälteNamn ="Hjälte";
string SkurkNamn ="Skurk";

int HjältesHP =101;
int SkurkensHP =101;

Random generator = new Random();

while (HjältesHP > 0 && SkurkensHP > 0)
{
Console.WriteLine("Next round, FIGHT!)";
Console.WriteLine($"{HjälteNamn}: {HjältesHP}  {SkurkNamn}: {SkurkensHP}/n");

int HjältenSkada = generator.Next(50);
SkurkensHP -= HjältenSkada;
SkurkensHP = Math.Max(0, SkurkensHP);
Console.WriteLine($"{HjälteNamn} gör {HjältenSkada} skada på {SkurkNamn}");


}


int slumptal = generator.Next(101);

Console.WriteLine(slumptal);



Console.WriteLine("Destructive FINISH");

Console.ReadLine();