using System.ComponentModel.DataAnnotations;

namespace EnemyLogic
{
    public class TankEnemy: Enemy
    {
        int maxhealth = 150;

        public TankEnemy()
        {
            health = maxhealth;
            
            names.Add("The Ugly Troll");
            names.Add("Giant");
            names.Add("Titan");
            names.Add("Beast");
            names.Add("The Hulking Goliath");

            GetName();
        }
    }
}