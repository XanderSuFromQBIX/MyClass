using System;
using System.Collections.Generic;
using System.Linq;

namespace Q_BIX_Zach.Creatures
{
    public abstract class Creature
    {
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "Shoes")
                {
                    name = "Shoes";
                }
                else
                {
                    name = value;
                }
            }
        }

        private int FullHp;
        public int Hp { get; private set; }
        private int Strength;
        private int Love;
        private static Random rnd = new Random();

        private CreatureSkills Skill1;
        private CreatureSkills Skill2;
        private CreatureWeapons Weapon;


        public Creature(int hit, string profile, int power, int heal, CreatureSkills s1, CreatureSkills s2, CreatureWeapons equipment)
        {
            FullHp = hit;
            Hp = hit;
            Name = profile;
            Strength = power;
            Love = heal;
            Skill1 = s1;
            Skill2 = s2;
            Weapon = equipment;
        }

        public bool IsDead()
        {
            return (Hp == 0);
        }

        public void PrintTeamDeatails()
        {
            Console.WriteLine($"Creature's name = {Name}, creature's Health = {Hp}, creature's type = {this.GetType().Name}. (Team Member)");
            Console.WriteLine($"Weapon = {Weapon}, Skills = {Skill1}, {Skill2}");
            Console.WriteLine("");
            SoundUtils.LineSounds.LinePassSound();
        }

        public void PrintEnemyDeatails()
        {
            Console.WriteLine($"Creature's name = {Name}, creature's Health = {Hp}, creature's type = {this.GetType().Name}. (Enemy)");
            Console.WriteLine($"Weapon = {Weapon}, Skills = {Skill1}, {Skill2}");
            Console.WriteLine("");
            SoundUtils.LineSounds.LinePassSound();
        }

        public void Hit(Creature attackingCreature)
        {
            int attackDammage = attackingCreature.GetAttackDammage();
            Console.WriteLine($"{attackingCreature.Name} is attacking {Name} with {attackingCreature.Name}'s {attackingCreature.Weapon}! {attackingCreature.Name} is using {attackingCreature.Skill1}");
            SoundUtils.LineSounds.HitSound();
            Hit(attackDammage);
        }

        public void Hit(int hitDammage)
        {
            if ((Hp - hitDammage) <= 0)
            {
                Hp = 0;
                Console.WriteLine($"{Name} has {Hp} Hp, {Name} is Dead.");
                SoundUtils.LineSounds.DeadSound();
            }
            else
            {
                Hp -= hitDammage;
                Console.WriteLine($"Your {this.GetType().Name} called {Name} got hit for {hitDammage} Hp, {Name} tryed to use {Skill2} to defend, but failed, {Name} has {Hp} HP left! {Name} says,");
            }
            if (Hp != 0)
            {
                ShowHitSound();
            }

            Console.WriteLine("");
            SoundUtils.LineSounds.LinePassSound();
        }

        public int GetAttackDammage()
        {
            int powar = rnd.Next(0, Strength);
            return powar;
        }

        public int GetHeal()
        {
            int lLove = rnd.Next(0, Love);
            return lLove;
        }

        protected virtual void ShowHitSound()
        {
            Console.WriteLine("owf.");
        }


        //private void ShowHitSound()
        //{
        //    switch (Species)
        //    {
        //        case CreatureType.Ogre:
        //            Console2.WriteLine("Ow!!!");
        //            break;
        //        case CreatureType.Hybrid:
        //            Console2.WriteLine("Owch! That hurt!");
        //            break;
        //        case CreatureType.Slime:
        //            Console2.WriteLine("blipp!");
        //            break;
        //        case CreatureType.WereWolf:
        //            Console2.WriteLine("Grrr");
        //            break;
        //        case CreatureType.Demon:
        //            Console2.WriteLine("Curse You!");
        //            break;

        //    }

        //}

        public void GetHeal2(Creature HealingCreature)
        {
            int world = HealingCreature.GetHeal();
            Console.WriteLine($"{HealingCreature.Name} is Healing {Name}!");
            SoundUtils.LineSounds.HealSounds();
            Heal2(HealingCreature.Love);
        }


        public void Heal2(int healHealth)
        {
            Hp = Hp + healHealth;
            Console.WriteLine($"{Name}, has been healed for {healHealth} Hp! {Name} now has {Hp} Hp!");
            Console.WriteLine("");
            SoundUtils.LineSounds.LinePassSound();
        }

        public void Revive()
        {
            Hp = 0;
            Hp = FullHp + Hp;
            Console.WriteLine($"{Name} has come back to life with {Hp} Hp!");
            Console.WriteLine("");
            SoundUtils.LineSounds.LifeSound();
            SoundUtils.LineSounds.LifeSound();
        }   
    }
}
