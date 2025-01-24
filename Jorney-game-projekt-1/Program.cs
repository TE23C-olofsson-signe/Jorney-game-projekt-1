// Karaktärer man kan välja att gå ett äventyr med. 
bool done = false;
string name = "";
while (!done)
{
    List<string> character = ["Jinx", "Vi", "Ekko", "Catlyn", "Vander"];

    Console.WriteLine("Skriv ett namn från listan");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(character[i]);
    }

    // Hämtar in namnet
    name = Console.ReadLine();
    // avslutar loopen om det är ett namn från listan 
    if (character.Contains(name))
    {
        Console.WriteLine("Nu är du" + name);
        done = true;
    }
    else
    {
        Console.WriteLine("Nej välj en av karaktärerna i listan");
    }
}

// OM namnet är Jinx
if (name == "Jinx")
{
    Jinx();
}

static void Jinx()
{
    Console.WriteLine("du spawnar på en rak väg du börjar gå ");

    bool clear = false;
    while (!clear)
    {
        List<string> weapons = ["Shock Pistol", "Flame Chompers", "Pistol ", "Rocketlauncher"];
        List<int> weaponshp= [ 20, 50, 100, 120];
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(weapons[i]  + weaponshp[i]);
        }

        string vapen = Console.ReadLine();

        if (weapons.Contains(vapen))
        {
            clear = true;

        }
        else
        {
            Console.WriteLine("ett vapen sa jag");
        }

    }
}
Jinx();

Console.ReadLine();