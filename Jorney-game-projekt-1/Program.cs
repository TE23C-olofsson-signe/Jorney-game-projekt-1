﻿// Karaktärer man kan välja att gå ett äventyr med. 
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
else if (name== "Vi")
{
    
}


static void Jinx()
{

    Console.WriteLine();
    // Få ett vapen 
    Console.WriteLine("Du spawnar på en rak väg i piltmore. Du börjar gå tills du träffar en vän. Han säger att du måste välja mellan fyra vapen.");


    bool clear = false;
    string weaponname = "";

    List<string> arm = ["ShockPistol", "Pistol", "FlameChompers", "Rocketlauncher"];

    while (!clear)
    {
        foreach (var item in arm)
        {
            Console.WriteLine(item);
        }


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

    string villain_name = "Ambessa";
    string villain_name2 = "";
    string villain_name3 = "Rictus";
    string villain_name4 = "Catlyn";

    Console.WriteLine("Beronde på vilket vapen du har är det en skurk du behöver slå innan du kan ta dig vidare");
    int yourWeaponHp = 0;
    string villainName = "";

    if (weaponname == "ShockPistol")
    {
        yourWeaponHp = 20;
        villainName = villain_name;
    }
    else if (weaponname == "Pistol")
    {
        yourWeaponHp = 50;
        villainName = villain_name2;
    }

    else if (weaponname == "FlameChompers")
    {
        yourWeaponHp = 100;
        villainName = villain_name3;

    }

    else if (weaponname == "Rocketlauncher")
    {
        yourWeaponHp = 150;
        villainName = villain_name4;
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

    Console.WriteLine("Yay du slog " + villainName);

    Console.WriteLine();

// rikting på vart man ska gå 
    Console.WriteLine(" Du börjar gå, du stannar vid en korsning du kan antingen gå ");
    List<string> direction = ["Höger", "Vänster", "HögerUpp", "VänsterUpp"];
    string choosingDirection = "";
    bool right = false;
    while (!right)
    {


        foreach (var item in direction)
        {
            Console.WriteLine(item);
        }

        choosingDirection = Console.ReadLine();

        if (direction.Contains(choosingDirection))
        {
            Console.WriteLine("du går åt " + choosingDirection);
            right=true; 
        }
        else
        {
            Console.WriteLine("Jag sa ett rikting ");
        }
    }

    int Badguyhp= 460; 
    
    string saved = ""; 
    
    if (choosingDirection == "Höger")
    {
       
        saved = "Claggor";
        Console.WriteLine($"När {villain_name} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp = 40; 
        weaponname= "Shockpistol"; 
        villainName=villain_name; 
     
    }
    else if (choosingDirection == "Vänster")
    {
       
        saved = "Silco";
        Console.WriteLine($"När {villain_name2} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp= 100; 
        weaponname="Pistol";
         villainName=villain_name2;
        
    }

    else if (choosingDirection == "HögerUpp")
    {
        
        saved = "Mylo";
        Console.WriteLine($"När{villain_name3} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp= 200; 
        weaponname="FlameChompers";
         villainName=villain_name3;

    }
    else if (choosingDirection == "VänsrerUpp")
    {

        saved = "Isha";
        Console.WriteLine($"När {villain_name4} fick tillbaka sin kraft tog hon {saved} tillfånga och nu utmanar hon dig till strid (hennes hit point har ökat +10 och ditt vapen har gångrat med 2)");
        yourWeaponHp=300; 
        weaponname= "Rocketlauncher";
         villainName=villain_name4;
    }
    
     while (Badguyhp > 0)
    {
        Console.WriteLine("\n-----====Rädda Någon ====----");
        Console.WriteLine($"{choosingDirection}:{yourWeaponHp} {villainName}: {Badguyhp}\n");

        int weaponDamage = yourWeaponHp;
        Badguyhp -= weaponDamage;
        Badguyhp = Math.Max(0, Badguyhp);
        Console.WriteLine($"{weaponname} gör {weaponDamage} skada på {villainName}");

        Console.ReadKey();
    }

   

    Console.WriteLine("yay du lyckades rädda "+saved);

    Console.WriteLine("Du är klar med äventryret."); 
}

static void Vi()
{
    Console.WriteLine("Du spawnar i the under city vid bron du börjar gå framåt till du möter din vän Babbete");
}


Console.ReadLine();