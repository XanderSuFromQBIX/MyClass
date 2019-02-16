using System;
using System.Collections.Generic;

namespace CreatureDictonary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Monster> monsterDict = new Dictionary<string, Monster>();
            int w = 0;
            Console.WriteLine("Wellcome to the Creature dictonary, you can experiment with commands \"Add\", \"List\", \"End\", \"Show (Name)\", \"War\" and \"Duel\" try one out now.");
            string answer;
            while (w < 10)
            {
                answer = Console.ReadLine();
                if(answer == "Add")
                {
                    string name;
                    int hp;
                    int attack;
                    Console.Write("You are making a Creature! State the name: ");
                    name = Console.ReadLine();
                    Console.Write($"Now State the amount of Health {name} has: ");
                    hp = int.Parse(Console.ReadLine());
                    Console.Write("Now State the attack dammage: ");
                    attack = int.Parse(Console.ReadLine());
                    var monst = new Monster(name, hp, attack);
                    monsterDict.Add(name, monst);
                }
                else if(answer == "List")
                {
                    foreach (var creature in monsterDict.Values)
                    {
                        creature.DisplayStats();
                    }
                }
                else if(answer.StartsWith("Show"))
                {
                    answer = answer.Remove(0, 5);
                    if (monsterDict.ContainsKey(answer))
                    {
                        monsterDict[answer].DisplayStats();
                    }
                    else
                    {
                        Console.WriteLine($"{answer} does not exist.");
                    }
                    
                }
                else if(answer == "End")
                {
                    break;
                }
                else if(answer == "Duel")
                {
                    int s = 0;
                    string p, e;
                    Monster pl, en;
                    Console.Write("You are having a battle! List a Creature's name: ");
                    p = Console.ReadLine();
                    pl = monsterDict[p];
                    Console.Write("List the other Creature's name: ");
                    e = Console.ReadLine();
                    en = monsterDict[e];
                    while(s < 1)
                    {
                        pl.Hit(en);
                        if(pl.IsDead())
                        {
                            Console.WriteLine($"{e} is the winner");
                            foreach(var c in monsterDict.Values)
                            {
                                c.Hp = 0;
                                c.Hp += c.Max;
                            }
                            Console.ReadLine();
                            break;
                        }
                        en.Hit(pl);
                        if(en.IsDead())
                        {
                            Console.WriteLine($"{p} is the winner");
                            foreach (var c in monsterDict.Values)
                            {
                                c.Hp = 0;
                                c.Hp = c.Hp + c.Max;
                            }
                            Console.ReadLine();
                            break;
                        }
                    }
                }
                else if(answer == "War")
                {
                    string p1, p2, p3, e1, e2, e3;
                    Monster pl1, pl2, pl3, en1, en2, en3;
                    Console.WriteLine("You are having a War! A War is a battle with 3 people on each team.");
                    Console.Write("State Team 1's first member: ");
                    p1 = Console.ReadLine();
                    pl1 = monsterDict[p1];
                    Console.Write("State it's second member: ");
                    p2 = Console.ReadLine();
                    pl2 = monsterDict[p2];
                    Console.Write("State it's third member: ");
                    p3 = Console.ReadLine();
                    pl3 = monsterDict[p3];
                    Console.Write("State Team 2's first member: ");
                    e1 = Console.ReadLine();
                    en1 = monsterDict[e1];
                    Console.Write("State it's second member: ");
                    e2 = Console.ReadLine();
                    en2 = monsterDict[e2];
                    Console.Write("State it's third member: ");
                    e3 = Console.ReadLine();
                    en3 = monsterDict[e3];
                    while(w < 5)
                    {
                        en1.Hit(pl1);
                        en2.Hit(pl2);
                        en3.Hit(pl3);
                        if(en1.IsDead() && en2.IsDead() && en3.IsDead())
                        {
                            Console.WriteLine($"{p1}, {p2}, and {p3} are the winners!!!!!!");
                            Console.ReadLine();
                            foreach (var c in monsterDict.Values)
                            {
                                c.Hp = 0;
                                c.Hp = c.Hp + c.Max;
                            }
                        }
                        pl1.Hit(en1);
                        pl2.Hit(en2);
                        pl3.Hit(en3);
                        if(pl1.IsDead() && pl2.IsDead() && pl3.IsDead())
                        {
                            Console.WriteLine($"{e1}, {e2}, and {e3} are the winners!!!!!!!!");
                            Console.ReadLine();
                            foreach (var c in monsterDict.Values)
                            {
                                c.Hp = 0;
                                c.Hp = c.Hp + c.Max;
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine($"\"{answer}\" is not a valid command");
                }
            }
        }
    }

    public class Monster
    {
        public string Name;
        public int Max;
        public int Hp;
        public int Strength;
        private static Random rnd = new Random();

        public Monster(string name, int hp, int power)
        {
            Name = name;
            Hp = hp;
            Max = hp;
            Strength = power;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Creature: {Name} has {Hp} Hp.");
        }

        public void Hit(Monster attackingCreature)
        {
            int attackDammage = attackingCreature.GetAttackDammage();
            Console.WriteLine($"{attackingCreature.Name} is attacking {Name} for somewhere around {attackingCreature.Strength} Hp!");
            Console.ReadLine();
            Hit(attackDammage);
        }

        public void Hit(int hitDammage)
        {
            if ((Hp - hitDammage) <= 0)
            {
                Hp = 0;
                Console.WriteLine($"{Name} now has 0 Hp, {Name} is Dead.");
                Console.ReadLine();
            }
            else
            {
                Hp -= hitDammage;
                Console.WriteLine($"{Name} has lost {hitDammage} Hp, {Name} has {Hp} Hp left.");
                Console.ReadLine();
            }
            Console.WriteLine("");
        }

        public int GetAttackDammage()
        {
            int powar = rnd.Next(0, Strength);
            return powar;
        }

        public bool IsDead()
        {
            return (Hp == 0);
        }
    }
}
