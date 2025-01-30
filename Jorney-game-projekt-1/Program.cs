// Karaktärer man kan välja att gå ett äventyr med. 
bool done = false;
string name = "";
while (!done)
{
    List<string> character = ["Jinx", "Vi", "Ekko", "Catlyn", "Vander"];

    Console.WriteLine("Skriv ett namn från listan");
    foreach (var item in character)
    {
        Console.WriteLine(item);
    }

    PrintPrompt();

    // Hämtar in namnet
    name = Console.ReadLine();
    // avslutar loopen om det är ett namn från listan 
    if (character.Contains(name))
    {
        Console.WriteLine();
        Console.WriteLine("Nu är du " + name);
        done = true;
    }
    else
    {
        Console.WriteLine("Nej, välj en av karaktärerna i listan");
    }
}

// OM namnet är Jinx
if (name == "Jinx")
{
    Jinx();
}

static void PrintPrompt()
{
    Console.WriteLine("");
    Console.Write("> ");
}

static void Jinx()
{

    Console.WriteLine();
    // Få ett vapen 
    Console.WriteLine("Du spanar på en rak väg. Du börjar gå tills du träffar en vän. Han säger att du måste välja mellan fyra vapen. ");


    bool clear = false;
    string weaponname = "";

    List<string> arm = ["ShockPistol", "Pistol", "FlameChompers", "Rocketlauncher"];

    while (!clear)
    {
        foreach (var item in arm)
        {
            Console.WriteLine(item);
        }
        PrintPrompt();

        weaponname = Console.ReadLine();

        if (arm.Contains(weaponname))
        {
            clear = true;
            Console.WriteLine();
            Console.WriteLine("Nu har du " + weaponname);
        }
        else
        {
            Console.WriteLine("Välj ett vapen ur listan");
        }
    }

    Console.WriteLine();
    // namnen på skurkarna och dess hitpoints.
    int Villain_hp = 450;

    string villain_name = "Ambessa";
    string villain_name2 = "Catlyn";
    string villain_name3 = "Rictus";
    string villain_name4 = "Sevika";

    // olika skurkar beronde vilket vapen du valde, skurkarna har samma hit points. 
    Console.WriteLine("Beronde på vilket vapen du har är det en skurk du behöver slå innan du kan ta dig vidare");

    int yourWeaponHp = 0;
    string villainName = "";

    if (weaponname == "ShockPistol")
    {
        yourWeaponHp = 20;
        villainName= villain_name; 
    }
    else if (weaponname == "Pistol")
    {
        yourWeaponHp = 50;
        villainName= villain_name4;
    }

    else if (weaponname == "Rocketlauncher")
    {
        yourWeaponHp = 150; 
        villainName = villain_name2;

    }

    else if (weaponname == "FlameChompers")
    {
        yourWeaponHp = 100; 
        villainName = villain_name3; 
    }

    while (Villain_hp > 0)
    {
        Console.WriteLine("\n-----====Skurken====----");
        Console.WriteLine($"{weaponname}:{yourWeaponHp} {villainName}: {Villain_hp}\n");

        int weaponDamage = yourWeaponHp;
        Villain_hp -= weaponDamage;
        Villain_hp = Math.Max(0, Villain_hp);
        Console.WriteLine($"{weaponname} gör {weaponDamage} skada på {villainName}");

        Console.ReadKey();
    }

    Console.WriteLine("Yay du slog "+villainName);

    Console.WriteLine("");


   
}


Console.ReadLine();