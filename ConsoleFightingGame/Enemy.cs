namespace EnemyLogic
{
    public class Enemy
    {
        public string name;

        public int health;
        public int mana;

        public float dodgeChance;
        public float critChance;

        public List<String> spells = new();
        public List<String> names = new();
        List<Char> affiliations = new();

        public char elementAffiliation;
        public string printAffiliation;

        public Random random = new();
        public Enemy()
        {
            affiliations.Add('F');
            affiliations.Add('E');
            affiliations.Add('W');
            affiliations.Add('A');
            affiliations.Add('N');
        }


        
        //Prints the stats of the enemy
        public void PrintStats()
        {
            Console.Clear();
            Console.WriteLine($"{name} Hp: {health} Element:{printAffiliation}");
        }
        

        //Decides the affilitation of the enemy and make it so that PrintStats can write it out
        public void GetAffilitation()
        {
            int index = random.Next(affiliations.Count);

            elementAffiliation = affiliations[index];

            //Makes it so that the whole name of the element can be printed in PrintStats
            if(elementAffiliation == 'F')
            {
                printAffiliation = "Fire";
            }else if(elementAffiliation == 'E')
            {
                printAffiliation = "Earth";
            }else if(elementAffiliation == 'W')
            {
                printAffiliation = "Water";
            }else if(elementAffiliation == 'A')
            {
                printAffiliation = "Air";
            }else
            {
                printAffiliation = "Normal";
            }
        }


        //Gives the enemy a name from the list in its class
        public void GetName()
        {
            int index = random.Next(names.Count);

            name = names[index];
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


    //Class for the more nibmle enemy
    public class NibmleEnemy: Enemy
    {
        public int maxhealth = 50;

        public NibmleEnemy()
        {
            health = maxhealth;

            names.Add("Assassin");
            names.Add("Thief");
            names.Add("ShadowStalker");
            names.Add("Specter");
            names.Add("Rogue");

            GetName();
            GetAffilitation();
        }
    }



    //Class for the tank enemy
    public class TankEnemy: Enemy
    {
        public int maxhealth = 150;

        public TankEnemy()
        {
            health = maxhealth;
            dodgeChance = 10f;
            critChance = 5f;

            names.Add("The Ugly Troll");
            names.Add("Giant");
            names.Add("Titan");
            names.Add("Beast");
            names.Add("The Hulking Goliath");

            GetName();
            GetAffilitation();
        }
    }


    //Class for the flying enemy
    public class FlyingEnemy: Enemy
    {
        public int maxhealth = 75;

        public FlyingEnemy()
        {
            names.Add("Skyborne Harrier");
            names.Add("Aerial Seraph");
            names.Add("Stormwing Drake");
            names.Add("Falconclaw Avian");
            names.Add("Wyvern");

            GetName();
            GetAffilitation();
        } 
    }



    public class ElementalEnemy: Enemy
    {
        public int maxHealth = 75;

        List<Char> elementalAffiliation = new();

        public ElementalEnemy()
        {
            health = maxHealth;

            elementalAffiliation.Add('F');
            elementalAffiliation.Add('E');
            elementalAffiliation.Add('W');
            elementalAffiliation.Add('A');

            ElementalGetAffiliation();
            ElementalGetName(elementAffiliation);
        }


        //Has seperate because it most have a affiliation
        public void ElementalGetAffiliation()
        {
            int index = random.Next(elementalAffiliation.Count);

            elementAffiliation = elementalAffiliation[index];
        }


        //Has sperate because the name depends on its affiliation
        public void ElementalGetName(char affiliation)
        {
            if(affiliation == 'F')
            {
                name = "Fire Guardian";
            }else if(affiliation == 'E')
            {
                name = "Earth Guardian";
            }else if(affiliation == 'W')
            {
                name = "Water Guardian";
            }else
            {
                name = "Air Guardian";
            }
        }
    }



    //Class for the wizard enemy
    public class WizardEnemy: Enemy
    {
        int maxHealth = 75;
        
        public WizardEnemy()
        {
            health = maxHealth;

            names.Add("");
            names.Add("");
            names.Add("");
            names.Add("");
            names.Add("");
        }
    }
}
