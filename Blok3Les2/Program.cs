using Blok3Les2;

List<Auto> Autos = new List<Auto>();

Auto auto1 = new Auto();
//vul de eigenschappen die je hebt aangemaakt in Auto.cs

Autos.Add(auto1);

Auto auto2 = new Auto();
//vul de eigenschappen die je hebt aangemaakt in Auto.cs
//Voeg deze ook toe aan de lijst Autos
for (int i = 1; i<=5; i++ )
{
    //Maak binnen loop new Auto object aan
    //Vraag aan gebruiker (Merk, Type en Kleur)
    //Stel de eigenschappen in
    //Voeg toe aan de lijst Autos

}


foreach (Auto auto in Autos)
{
    //Druk het volgende af voor iedere auto: "Het betreft een <Merk> van het type <Type> in de kleur <Kleur>
    Console.WriteLine("....");
}
