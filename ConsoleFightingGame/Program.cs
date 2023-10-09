using PlayerLogic;
using EnemyLogic;

Player player = new();

bool start = true;
bool playing = false;


//The start of the game, choose type, name, affiliation and information
while(start == true)
{

}


//The gameplay
while(playing == true)
{
    player.Action(Console.ReadKey().KeyChar);
}