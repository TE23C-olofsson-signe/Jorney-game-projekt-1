// Karaktärer man kan välja att gå ett äventyr med. 
using System.Diagnostics;

bool done = false;
string name = "";
while (!done)
{
    List<string> character = ["Jinx", "Vi", "Ekko","Caitlyn", "Vander"];

    Console.WriteLine("Skriv ett namn från listan");
    foreach (var item in character)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine();

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
//Om namnet är Vi
else if (name == "Vi")
{
    Vi();
}

else if (name=="Ekko")
{
    Ekko(); 
}

else if (name=="Caitlyn")
{
    Caitlyn();
}


static void Jinx()
{

    Console.WriteLine();
    // Få ett vapen och start punkt 
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
        // Hämtar in vapen namnet och kör loopen tills det är ett namn i listan 
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

    // Vilka skurkar man kan slå med det vapen du valde 
    int Villain_hp = 750;


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
        villainName = "Maddi";
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

    FirstFight(weaponname, "Jinx", villainName, yourWeaponHp, Villain_hp);

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
        // Hämtar in direktionen som du valde 
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

    Console.WriteLine();

    //  rädda och skurkarna hitpoints 
    int Villain_hp2 = 760;

    string saved = "";

    //Vilket håll man valde och vilken skurk och vem man ska rädda och ny vapen hitpoint 
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

        villainName = "Catlyn";
        saved = "Isha";
        Console.WriteLine($"När {villainName} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp = 300;
        weaponname = "Rocketlauncher";
    }

    SavingFight(saved, villainName, "Jinx", Villain_hp2, weaponname, yourWeaponHp);
}

static void Vi()
{
    // Vi start punkt och få  välja ett vapen 
    Console.WriteLine("Du spawnar i the under city vid bron du börjar gå framåt till du möter din vän Babbete");
    Console.WriteLine("Hon säger att du ska välja ett av fyra vapen");

    // Vaperna Vi kan välja 
    List<string> weapon = ["Atlas Gauntlets", "Blast Shield", "Pilbåge", "Golem Gan"];

    foreach (var item in weapon)
    {
        Console.WriteLine(item);
    }

    bool look = false;
    string armname;
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


    Console.WriteLine("Beronde på vilket vapen du har är det en skurk du behöver slå innan du kan ta dig vidare");

    //Skurkarnas Hp,objekt för skurkarnas namn och objek för ditt vapen hp
    string Badguy = "";
    int BadguyHp = 450;
    int yourArmhp = 0;

    //Vilket vapen man valde  hitpoints och Skurkensnamn 
    if (armname == "Atlas Goutlet")
    {
        Badguy = "Viktor";
        yourArmhp = 30;
    }
    else if (armname == "Blast Shield")
    {
        Badguy = "Ambessa";
        yourArmhp = 70;
    }
    else if (armname == "Pilbåge")
    {
        Badguy = "Sevika";
        yourArmhp = 110;
    }
    else if (armname == "Golem Gan")
    {
        Badguy = "Silco";
        yourArmhp = 160;
    }

    // Kallar på metoden 
    FirstFight(armname, "Vi", Badguy, yourArmhp, BadguyHp);

    Console.WriteLine("Du kommer till en korsning du kan välja mellan att gå");

    List<string> direktion = ["Höger", "Vänster", "Vänster Vänster", "Höger Höger"];
    string chooseDirektion; 

    foreach (var item in direktion)
    {
        Console.WriteLine(item); 
    }
    bool icecream=false; 

    chooseDirektion=Console.ReadLine(); 

    while (!icecream)
    {
        if (direktion.Contains(chooseDirektion))
        {
            Console.WriteLine("Du valde att gå åt"+chooseDirektion); 
            icecream=true; 
        }
        else
        {
            Console.WriteLine("En rikting sa jag"); 
        }
    }

    // Skurkarnas nya hp och ditt dubbla hp 
    string taken = "";
    int BadguyHp2 = 460;
    int yourArmhp2 = 0;

    if (chooseDirektion=="Höger")
    {
        taken="Loris";
        Badguy="Viktor";
        Console.WriteLine($"När {Badguy} fick tillbaka sin kraft tog hon {taken} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        armname="Atlas Goutlet";
        yourArmhp2=60;

    }
    else if (chooseDirektion=="Vänster")
    {
        taken="Jayce";
        Badguy="Ambessa";
        Console.WriteLine($"När {Badguy} fick tillbaka sin kraft tog hon {taken} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)"); 
        armname="Blast Shield";
        yourArmhp2=140;
    }
    else if (chooseDirektion=="Vänster Vänster")
    {
        taken="Caitlyn"; 
        Badguy="Sevika";
        Console.WriteLine($"När {Badguy} fick tillbaka sin kraft tog hon {taken} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)"); 
        armname="Pilbåge";
        yourArmhp2=220;
    }
    else if (chooseDirektion=="Höger Höger")
    {
        taken="Powder";
        Badguy="Silco";
        Console.WriteLine($"När {Badguy} fick tillbaka sin kraft tog hon {taken} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        armname="Golem Gan";
        yourArmhp2=320; 
    }

    // Kallar på metoden 
    SavingFight(taken, Badguy, "Vi", BadguyHp2, armname, yourArmhp2);

}

static void Ekko()
{
       // Ekkos start punkt och få välja ett vapen 
        Console.WriteLine("Du spawnar i zaun vid the firefighter base  du börjar gå framåt till du möter din vän Powder");
        Console.WriteLine("Hon säger att du ska välja ett av fyra vapen");

        // Lista vapen som Ekko kan välja¨
        List<string> Gun =["Sword","Bat","Smoke Grenade","Hoverboard"];
        string gunName; 

        foreach (var item in Gun)
        {
            Console.WriteLine(item); 
        }

        //loopens vilkor och hämtar vapentets namn 
        bool cola= false; 
        gunName=Console.ReadLine();

        // går tills Namnet matchar  listan 
        while (!cola)
        {
            if (Gun.Contains(gunName))
            {
                Console.WriteLine("Du har"+gunName);
                cola=true;
            }
            else
            {
                Console.WriteLine("Ett vapen från listan ");
            }
        }

        Console.WriteLine();

        Console.WriteLine("Beronde på vilket vapen du har är det en skurk du behöver slå innan du kan ta dig vidare");

         //Skurkarnas Hp,objekt för skurkarnas namn och objek för ditt vapen hp
        string crook="";
        int crookHp=350; 
        int yourGunHp=0; 

        //Vilket vapen man valde  hitpoints och Skurkensnamn
        if (gunName=="Sword")
        {
            crook="Marcus";
            yourGunHp=10; 
        }
        else if (gunName=="Bat")
        {
            crook="Renni";
            yourGunHp=80;
        }
        else if (gunName=="Smoke Grenade")
        {
            crook="Lock";
            yourGunHp=120;
        }
        else if (gunName=="Hoverboard")
        {
            crook="Silco";
            yourGunHp=170; 
        }

        //Kallar på metoden
        FirstFight(gunName,"Ekko",crook,yourGunHp,crookHp);

        Console.WriteLine("Du kommer till en korsning du kan välja mellan att gå");
        List<string> vägbeskrivning=["Höger","Vänster","Upp","Höger Vänster"];
        string choosingVägbeskrivning;

        foreach (var item in vägbeskrivning)
        {
            Console.WriteLine(item);
        }

        choosingVägbeskrivning=Console.ReadLine();
        bool sprite=false; 

        while (!sprite)
        {
            if (vägbeskrivning.Contains(choosingVägbeskrivning))
            {
                Console.WriteLine("Du valde att gå åt"+choosingVägbeskrivning);
                sprite=true;
            }
            else
            {
                Console.WriteLine("Jag sa välj vilket håll du ska gå");
            }
        }

        string rescue="";
        int crookHp2=360; 
        int yourGunHp2=0;

        if (choosingVägbeskrivning=="Höger")
        {
            rescue="Eve";
            crook="Marcus";
            Console.WriteLine($"När {crook} fick tillbaka sin kraft tog hon {rescue} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
            gunName="Sword";
            yourGunHp2=20;
        }
        else if (choosingVägbeskrivning=="Vänster")
        {
            rescue="Scar";
            crook="Renni";
            Console.WriteLine($"När {crook} fick tillbaka sin kraft tog hon {rescue} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
            gunName="Bat";
            yourGunHp2=160;
        }
        else if (choosingVägbeskrivning=="Upp")
        {
            rescue="Heimerdinger";
            crook="Lock";
            Console.WriteLine($"När {crook} fick tillbaka sin kraft tog hon {rescue} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
            gunName="Smoke Grenade";
            yourGunHp2=240;
        }
        else if (choosingVägbeskrivning=="Höger Vänster")
        {
            rescue="Benzo";
            crook="Silco";
            Console.WriteLine($"När {crook} fick tillbaka sin kraft tog hon {rescue} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
            gunName="Hoverboard";
            yourGunHp2=340;
        }

        //Kallar på metod
        SavingFight(rescue,crook, "Ekko", crookHp2, gunName, yourGunHp2);

}

static void Caitlyn()
{
    Console.WriteLine("Du spawnar i the under city vid bron du börjar gå framåt till du möter din vän Vi");
    Console.WriteLine("Hon säger att du måste välja mellan fyra vapen.");

    List<string> armor=["Peacemaker","Caliber Net","Ace in the Hole","Hextech Riffle"];
    string armorName;

    foreach (var item in armor)
    {
        Console.WriteLine(item);
    }

    bool cake=false;
    armorName=Console.ReadLine();

    while (!cake)
    {
        if (armor.Contains(armorName))
        {
            Console.WriteLine("Du valde"+armorName);
            cake=true;
        }
        else
        {
        Console.WriteLine("Ett vapen från listan ");
        }   
    }

    string rogue="";
    int rogueHp=550;
    int yourArmorHp=0;

    if (armorName=="Peacemaker")
    {
        rogue="Silco";
        yourArmorHp=40;

    }
    else if (armorName=="Caliber Net")
    {
        rogue="Ambessa";
        yourArmorHp=60;
    }
    else if (armorName=="Ace in the Hole")
    {
        rogue="Maddi";
        yourArmorHp=130;
    }
    else if (armorName=="Hextech Riffle")
    {
        rogue="Jinx";
        yourArmorHp=180;
    }

    FirstFight(armorName,"Caitlyn",rogue,yourArmorHp,rogueHp);
    
    Console.WriteLine("Du kommer till en korsning du kan välja mellan att gå");
    List<string> wayinstruction=["Höger","Höger Vänster","Vänster","Vänster Höger"];
    string chooseWayinsruction;

    foreach (var item in wayinstruction)
    {
        Console.WriteLine(item);
    }

    bool cream=false;
    chooseWayinsruction=Console.ReadLine();

    while (!cream)
    {
        if (wayinstruction.Contains(chooseWayinsruction))
        {
            Console.WriteLine("Du valde att gå åt"+chooseWayinsruction);
            cream=true; 
        }
        else
        {
            Console.WriteLine("Välj en åt vilket håll du ska gå");
        }
    }

    string salvage="";
    int rogueHp2=560;
    int yourArmorHp2=0; 
    
    if (chooseWayinsruction=="Höger")
    {
        salvage="Jayce";
        rogue="Silco";
        Console.WriteLine($"När {rogue} fick tillbaka sin kraft tog hon {salvage} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        armorName="Peacemaker";
        yourArmorHp2=80;
    }
    else if (chooseWayinsruction=="Höger Vänster")
    {
        salvage="Ekko";
        rogue="Ambessa";
        Console.WriteLine($"När {rogue} fick tillbaka sin kraft tog hon {salvage} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        armorName="Caliber Net";
        yourArmorHp2=120; 
    }
    else if (chooseWayinsruction=="Vänster")
    {
        salvage="Tobias";
        rogue="Maddi";
        Console.WriteLine($"När {rogue} fick tillbaka sin kraft tog hon {salvage} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        armorName="Ace in the Hole";
        yourArmorHp2=260;
    }
    else if (chooseWayinsruction=="Vänster Höger")
    {
        salvage="Cassandra";
        rogue="Jinx";
        Console.WriteLine($"När {rogue} fick tillbaka sin kraft tog hon {salvage} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        armorName="Hextech Riffle";
        yourArmorHp2=360;
    }

    SavingFight(salvage,rogue,"Caitlyn",rogueHp2,armorName,yourArmorHp2);
}


// Alla komandon   för den första striden
static void FirstFight(string weapon, string heroName, string bruteName, int weaponHp, int bruteHp)
{
    Console.WriteLine($"{heroName} attackerar med sin {weapon} battles{bruteName} ");

    while (bruteHp > 0)
    {
        Console.WriteLine($"\n-----====Slå {bruteName} ====----");
        Console.WriteLine($"{heroName}:{weapon}: {weaponHp} {bruteName}: {bruteHp}\n");

        int weaponDamage = weaponHp;
        bruteHp -= weaponDamage;
        bruteHp = Math.Max(0, bruteHp);
        Console.WriteLine($"{weapon} gör {weaponDamage} skada på {bruteName}");

        Console.ReadKey();
    }
    Console.WriteLine("YAY du slog" + bruteName);
}

// Alla komandon för räddnings slagsmålet
static void SavingFight(string savingName, string bruteName, string heroName, int bruteHp2, string weapon, int weaponHp2)
{
    Console.WriteLine($"{bruteName} tar {savingName} {heroName} måste rädda{savingName}och {bruteName} Hp adderas med 10 och{weapon} Hp gångras med 2 ");

    while (bruteHp2 > 0)
    {
        Console.WriteLine($"\n-----====Rädda{savingName} ====----");
        Console.WriteLine($"{heroName}:{weapon}: {weaponHp2} {bruteName}: {bruteHp2}\n");

        int weaponDamage = weaponHp2;
        bruteHp2 -= weaponDamage;
        bruteHp2 = Math.Max(0, bruteHp2);{}
        Console.WriteLine($"{weapon} gör {weaponDamage} skada på {bruteName}");

        Console.ReadKey();
    }

    Console.WriteLine($"YAY du lyckaderädda{savingName} och ditt äventyr är slut");

}


Console.ReadLine();