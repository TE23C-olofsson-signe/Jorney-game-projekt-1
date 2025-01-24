// Karaktärer man kan välja att gå ett äventyr med. 
bool done= false; 
while (!done)
{
List<string> character = ["Jinx", "Vi", "Ekko", "Catlyn", "Vander" ];

Console.WriteLine("Skriv ett namn från listan");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(character[i]);
}

// Hämta in namnet
        string name = Console.ReadLine(); 
        // avslutar loopen om det är ett namn från listan 
    if (character.Contains(name))
    {
        done= true; 
    }
    else{
        Console.WriteLine("Nej välj en av karaktärerna i listan"); 
    }
}
// OM namnet är Jinx
//  Jinx()
// ELLER OM namnet är Vi
//  



static void Jinx()
{
    bool clear = false; 
  while(!clear){
    
  }
}
Console.ReadLine(); 