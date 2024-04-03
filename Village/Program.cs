using libvillageois;
using static libvillageois.Potion;

Villageois a, b; string rep;

a = new Villageois("Panoramix", 16, true);
b = new Villageois("Abraracourcix");

Console.WriteLine(b.getPoids());

b.setPoids(26);

Console.WriteLine(a.ToString());

Console.WriteLine(a.getNom()); 
Console.WriteLine(a.getPoids());

Console.WriteLine(a.poidsSouleve() + "Kg");
Console.WriteLine(b.poidsSouleve() + "Kg");
Console.WriteLine(a.Soulevememepoids(b));

Console.WriteLine(a.getPoids());

a.setDose(3);
Console.WriteLine(value: $"{a.getNom()} prend {a.getPotion().getDose()} doses");


Console.WriteLine("Apres les doses " + a.plusfort(b));

Console.WriteLine($"{a.getNom()} soulève {a.poidsSouleve()} poids"); Console.WriteLine($"{b.getNom()} soulève {b.poidsSouleve()} poids");

Village villageGaulois=new Village(5000, "glenBret", "petit village");
villageGaulois.AjouterVillageois(a);
villageGaulois.AjouterVillageois(b);
villageGaulois.AjouterNewVillageois("Homeopatix",20,true,3);
Console.WriteLine(villageGaulois.GetVillageois("Panoramix").ToString());
Console.WriteLine($"Il y a {villageGaulois.GetHabitant().Count} habitants dans kle village {villageGaulois.getNom()}");



