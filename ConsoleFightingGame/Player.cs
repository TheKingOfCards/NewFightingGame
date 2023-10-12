namespace PlayerLogic
{
    public class Player
    {
        int health = 0;
        int maxHealth = 100;

        int mana = 0;
        int maxMana = 80;

        int xp = 0;
        int coins = 0;
        int level = 0;
        int levelPoints = 0;

        char characterType;
        char elementAffiliation;

        int healthPotions = 0;
        int maxHealthPotions = 5;
        int healthPotionHealAmount = 20;

        int manaPotions = 0;
        int maxManaPotions = 5;
        int manaPotionRaiseAmount = 15;

        bool isFighting = false;
        bool isLooting = false;

        List<String> equippedSpells = new();


        public Player()
        {
            health = maxHealth;
            mana = maxMana;

            equippedSpells.Add("NoSpell");
        }


        //Writes out the actions the player can do
        public void WriteActionChoices()
        {
            isFighting = true;
            if(isFighting == true)
            {
                Console.WriteLine("1. Physical Action \n2. Spells \n3. Potions");
            }else if(isLooting == true)
            {

            }

            Action(Console.ReadKey().KeyChar);
        }


        //Takes the players action with a char
        public void Action(char playerInput)
        {
            if(isFighting == true) //The actions the player can take while fighting
            {
                if(playerInput == '1')
                {
                    Console.WriteLine("1. Attack \n2. Shield \n3. Dodge");
                    UsePhysical(Console.ReadKey().KeyChar);
                }else if(playerInput == '2')
                {
                    UseSpells(Console.ReadKey().KeyChar);
                }else if(playerInput == '3')
                {
                    Console.WriteLine("1. Health Potion\n2. Mana Potion");
                    UsePotions(Console.ReadKey().KeyChar);
                }else if(playerInput == '4')
                {
                    Console.WriteLine("1. Perks"); 
                    Perks();
                }
            }else if(isLooting == true) //The actions the player can take while looting
            {

            }
        }


        //Player decide which spell they would like to use
        public void UseSpells(char spellSelect)
        {
                
        }


        //Player can either attack, use spells or get a higher dodge chance
        public void UsePhysical(char physicalSelect)
        {
            Console.WriteLine("Works");
        }


        //Uses healthpotions or manapotions
        public void UsePotions(char potionSelect)
        {
            if(potionSelect == '1') //Heals the player
            {
                health += healthPotionHealAmount;
                if(health > maxHealth)
                {
                    health = maxHealth;
                }
            }else if(potionSelect == '2') //Raises the players mana points
            {
                mana += manaPotionRaiseAmount;
                if(mana > maxMana)
                {
                    mana = maxMana;
                }
            }
        }


        //Takes in a enemys pysical damage in a parameter and puts takes away from health
        public void TakeDamage(int baseDamage, String usedSpell)
        {
            if(usedSpell == "NoSpell") //Take physical damage
            {

            }else //Take spelldamage and passive effects
            {

            }
        }


        //Shows the player perks and if they can get them
        public void Perks()
        {

        }



        //Takes in the base xp from enemies killed and adds it to player xp (multipliers)
        public int GetXp(int baseXp)
        {
            return xp;
        }
    }
}