using System;

namespace Q_BIX_Zach.Creatures
{
    class Demon : Creature
    {
        public Demon(int hit, string profile, int power, int heal, CreatureSkills s1, CreatureSkills s2, CreatureWeapons equipment)
            : base(hit, profile, power, heal, s1, s2, equipment)
        {
        }

        protected override void ShowHitSound()
        {
            Console.WriteLine("Curse you!");
        }
    }
}
