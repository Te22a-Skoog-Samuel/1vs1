string HjälteNamn ="Hjälte";
string SkurkNamn ="Skurk";

int HjältesHP =100;
int SkurkensHP =100;

Random generator = new Random();

while (HjältesHP > 0 && SkurkensHP > 0)

int slumptal = generator.Next(101);

Console.WriteLine(slumptal);



Console.WriteLine("You are FINISHED");

Console.ReadLine();