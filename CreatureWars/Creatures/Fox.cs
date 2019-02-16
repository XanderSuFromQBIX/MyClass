using System;

namespace Q_BIX_Zach.Creatures
{
    public class Fox : Creature
    {
        public Fox(int hit, string profile, int power, int heal, CreatureSkills s1, CreatureSkills s2, CreatureWeapons equipment)
            : base(hit, profile, power, heal, s1, s2, equipment)
        { 
        }
        public void WhatDasTheFoxSay()
        {
            Console.WriteLine("The fox does not say");
            base.ShowHitSound();
            Console.WriteLine("But the fox does say");
            this.ShowHitSound();
        }
        protected override void ShowHitSound()
        {
            Console.WriteLine("Yelp!");
        }
    }
}
