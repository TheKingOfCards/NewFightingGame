using PlayerLogic;
using EnemyLogic;

Player player = new();
Enemy enemy = new ElementalEnemy();

bool start = true;
bool playing = false;
bool fighting = false;

Console.Title = "The Endeless Magical Dungeon";


//The start of the game, choose type, name, affiliation and information
while(start == true)
{
    printAllStats(player, enemy);
    //Player action begin
    player.WriteActionChoices();
    char input = Console.ReadKey().KeyChar;
    Console.Clear();
    printAllStats(player,enemy);
    player.Action(input);
    //Player action end
}


//The gameplay
while(playing == true)
{
    while(fighting == true)
    {
        player.Action(Console.ReadKey().KeyChar);
    }
}



static void printAllStats(Player player, Enemy enemy)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White; //Writes player stats
    Console.WriteLine($"[{player.name}] [Hp: {player.health}] [Mana: {player.mana}] [{player.element}]");
    Console.Write("Potions: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{player.healthPotions} ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"{player.manaPotions}");

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Enemy: [{enemy.name}] [{enemy.health}] [{enemy.printAffiliation}]\n ");
}