string HjälteNamn ="Hjälte";
string SkurkNamn ="Skurk";

int HjältesHP =101;
int SkurkensHP =101;

Random generator = new Random();

while (HjältesHP > 0 && SkurkensHP > 0)
{
Console.WriteLine("Next round, FIGHT!");
Console.WriteLine($"{HjälteNamn}: {HjältesHP}  {SkurkNamn}: {SkurkensHP}");

int HjältenSkada = generator.Next(35);
SkurkensHP -= HjältenSkada;
SkurkensHP = Math.Max(0, SkurkensHP);
Console.WriteLine($"{HjälteNamn} orsakade {HjältenSkada} skada på {SkurkNamn}");

int Skurkenskada = generator.Next(35);
HjältesHP -= Skurkenskada;
HjältesHP = Math.Max(0, HjältesHP);
Console.WriteLine($"{SkurkNamn} orsakade {Skurkenskada} skada på {HjälteNamn}");

Console.WriteLine("För att fortsätta, tryck på en valfri knapp");

Console.ReadKey();
}

Console.WriteLine("Destructive FINISH");

if (HjältesHP == 0 && SkurkensHP == 0)
{
Console.WriteLine("Ingen segrare");

}



Console.WriteLine(slumptal);





Console.ReadLine();