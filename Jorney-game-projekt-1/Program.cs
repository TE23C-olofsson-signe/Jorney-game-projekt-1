// Karaktärer man kan välja att gå ett äventyr med. 
using System.Diagnostics;

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
else if (name == "Vi")
{

}


static void Jinx()
{

    Console.WriteLine();
    // Få ett vapen 
    Console.WriteLine("Du spawnar på en rak väg i piltmore. Du börjar gå tills du träffar din  vän Silco.");
    Console.WriteLine("Han säger att du måste välja mellan fyra vapen.");


    bool clear = false;
    string weaponname = "";

    List<string> arm = ["ShockPistol", "Pistol", "FlameChompers", "Rocketlauncher"];

    foreach (var item in arm)
    {
        Console.WriteLine(item);
    }

    while (!clear)
    {

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

    // Slå skurken med det vapen du fick 
    int Villain_hp = 450;


    Console.WriteLine("Beronde på vilket vapen du har är det en skurk du behöver slå innan du kan ta dig vidare");
    int yourWeaponHp = 0;
    string villainName = "";

    if (weaponname == "ShockPistol")
    {
        yourWeaponHp = 20;
        villainName = "Ambessa";
        
    
    }
    else if (weaponname == "Pistol")
    {
        yourWeaponHp = 50;
        villainName = "Maddie";
    }

    else if (weaponname == "FlameChompers")
    {
        yourWeaponHp = 100;
        villainName = "Rictus";

    }

    else if (weaponname == "Rocketlauncher")
    {
        yourWeaponHp = 150;
        villainName = "Catlyn";
    }

    FirstFight(weaponname, "Jinx", villainName,yourWeaponHp,Villain_hp);


  

    Console.WriteLine("Yay du slog " + villainName);

    Console.WriteLine();

    // rikting på vart man ska gå 
    Console.WriteLine(" Du börjar gå, du stannar vid en korsning du kan antingen gå ");
    List<string> direction = ["Höger", "Vänster", "HögerUpp", "VänsterUpp"];
    string choosingDirection = "";
    bool right = false;


    foreach (var item in direction)
    {
        Console.WriteLine(item);
    }
    while (!right)
    {

        choosingDirection = Console.ReadLine();

        if (direction.Contains(choosingDirection))
        {
            Console.WriteLine("du går åt " + choosingDirection);
            right = true;
        }
        else
        {
            Console.WriteLine("Jag sa ett rikting ");
        }
    }

    int Villain_hp2 = 460;

    string saved = "";

    if (choosingDirection == "Höger")
    {

        saved = "Claggor";
        villainName = "Ambessa";
        Console.WriteLine($"När {villainName} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp = 40;
        weaponname = "Shockpistol";
        

    }
    else if (choosingDirection == "Vänster")
    {

        villainName = "Maddie";
        saved = "Silco";
        Console.WriteLine($"När {villainName} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp = 100;
        weaponname = "Pistol";

    }

    else if (choosingDirection == "HögerUpp")
    {

        villainName = "Rictus";
        saved = "Mylo";
        Console.WriteLine($"När{villainName} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp = 200;
        weaponname = "FlameChompers";

    }
    else if (choosingDirection == "VänsrerUpp")
    {

        saved = "Isha";
        Console.WriteLine($"När {villain_name4} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp = 300;
        weaponname = "Rocketlauncher";
        villainName = villain_name4;
    }

     SavingFight(saved,villainName,"Jinx",Villain_hp2,weaponname,yourWeaponHp); 




    Console.WriteLine("yay du lyckades rädda " + saved);

    Console.WriteLine("Du är klar med äventryret.");
}

static void Vi()
{
    Console.WriteLine("Du spawnar i the under city vid bron du börjar gå framåt till du möter din vän Babbete");
    Console.WriteLine("Hon säger att du ska välja ett av fyra vapen");

    List<string> weapon = ["Atlas Gauntlets", "Blast Shield", "Golem Gan", "Pilbåge"];
    string armname;

    foreach (var item in weapon)
    {
        Console.WriteLine(item);
    }

    bool look = false;
    armname = Console.ReadLine();

    while (!look)
    {
        if (weapon.Contains(armname))
        {
            Console.WriteLine("Du har " + armname);
            look = true;
        }
        else
        {
            Console.WriteLine("Ett vapen från listan ");
        }
    }

    Console.WriteLine();


    Console.WriteLine("Du kommer möta en skurk beronde på vilket vapen du valde.");


    string Badguy = "";
    int BadguyHp = 450;
    int yourArmhp=0; 
    

    if (armname == "Atlas Goutlet")
    {
        Badguy = "Viktor";
        yourArmhp=50; 
    }

    

    FirstFight(armname, "Vi", Badguy,yourArmhp,BadguyHp);
    
    string taken= ""; 
    int BadguyHp2=0; 
    int yourArmhp2=0; 

    SavingFight(taken,Badguy,"Vi",BadguyHp,armname,yourArmhp2); 

}

static void FirstFight(string weapon, string heroName, string bruteName, int weaponHp, int bruteHp)
{
    Console.WriteLine($"{heroName} attackerar med sin {weapon} battles{bruteName} ");

    while (bruteHp>0)
    {
         Console.WriteLine("\n-----====Slå skurken ====----");
        Console.WriteLine($"{heroName}:{weapon}: {weaponHp} {bruteName}: {bruteHp}\n");

        int weaponDamage =weaponHp;
        bruteHp -= weaponDamage;
        bruteHp = Math.Max(0, bruteHp);
        Console.WriteLine($"{weapon} gör {weaponDamage} skada på {bruteName}");

        Console.ReadKey();
    }
}

static void SavingFight(string savingName,string bruteName,string heroName,int bruteHp2,string weapon,int weaponHp2)
{
     Console.WriteLine($"{bruteName} tar {savingName} {heroName} måste rädda{savingName}och {bruteName} Hp adderas med 10 och{weapon} Hp gångras med 2 ");

     while (bruteHp2>0)
     {
          Console.WriteLine("\n-----====Slå skurken ====----");
        Console.WriteLine($"{heroName}:{weapon}: {weaponHp2} {bruteName}: {bruteHp2}\n");

        int weaponDamage =weaponHp2;
        bruteHp2 -= weaponDamage;
        bruteHp2 = Math.Max(0, bruteHp2);
        Console.WriteLine($"{weapon} gör {weaponDamage} skada på {bruteName}");

        Console.ReadKey();
     }

}


Console.ReadLine();