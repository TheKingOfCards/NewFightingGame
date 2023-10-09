namespace EnemyLogic
{
    public class Enemy
    {
        public string name;

        public int health;
        public int mana;

        float dodgeChance;
        float critChance;

        public List<String> npells = new();
        public List<String> names = new();

        char elementAffiliation;

        
        //Decides the affilitation of the enemy
        public void GetAffilitation()
        {

        }


        //Gives the enemy a name from the list in its class
        public void GetName()
        {

        }


        //Decides the attack of the enemy
        public void Attack()
        {

        }


        //Makes it so that the enemy can take damage
        public int TakeDamage(int damage)
        {
            return health;
        }
    }
}