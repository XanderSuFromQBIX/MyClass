using Q_BIX_Zach;
using Q_BIX_Zach.Creatures;
using System;
using System.Collections.Generic;

namespace CreatureWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogre = new Ogre(100, "Shoes", 40, 5, CreatureSkills.smack, CreatureSkills.clobber, CreatureWeapons.Club);
            var fox = new Fox(35, "Willy", 50, 25, CreatureSkills.bite, CreatureSkills.scratch, CreatureWeapons.ClawsAndTeeth);
            var human = new Human(150, "Xander Su", 50, 5, CreatureSkills.slash, CreatureSkills.stab, CreatureWeapons.Sword);
            var slime = new Slime(50, "Bliib", 20, 50, CreatureSkills.slimeBall, CreatureSkills.slimeLick, CreatureWeapons.SlimeBody);
            var werewolf = new Werewolf(200, "Remus Lupin", 75, 2, CreatureSkills.scratch, CreatureSkills.bite, CreatureWeapons.ClawsAndTeeth);
            var demon = new Demon(250, "Void Derra", 200, 0, CreatureSkills.demonCut, CreatureSkills.deathByDemons, CreatureWeapons.DemonBlade);
            var demonGod = new Demon(500, "King Derra", 400, -20, CreatureSkills.demonCut, CreatureSkills.deathByDemons, CreatureWeapons.DemonBlade);

            Dictionary<string, Creature> teamCreatureDictionary = new Dictionary<string, Creature>();
            Dictionary<string, Creature> enemyCreatureDictionary = new Dictionary<string, Creature>();
            enemyCreatureDictionary.Add(fox.Name, fox);
            enemyCreatureDictionary.Add(ogre.Name, ogre);            
            enemyCreatureDictionary.Add(demon.Name, demon);
            enemyCreatureDictionary.Add(demonGod.Name, demonGod);

            teamCreatureDictionary.Add(human.Name, human);
            teamCreatureDictionary.Add(slime.Name, slime);
            teamCreatureDictionary.Add(werewolf.Name, werewolf);

            //foreach (KeyValuePair<string, Creature> creaturekvp in teamCreatureDictionary)
            //{
                //creaturekvp.Value.PrintTeamDeatails();
            //}

            foreach (string creatureName in teamCreatureDictionary.Keys)
            {
                Creature creature = teamCreatureDictionary[creatureName];               
                creature.PrintTeamDeatails();
            }

            foreach (var creaturekvp2 in enemyCreatureDictionary)
            {
                creaturekvp2.Value.PrintEnemyDeatails();
            }
            int x = 0;
            int s = 1;
            while(x < 10)
            {
                if (s > 10)
                {
                    Console.WriteLine("That's to many rounds, take a break.");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine($"Round {s}!");
                Console.ReadLine();
                s++;
                string p, e;
                Creature player, enemy;
                Console.WriteLine("What Creature do you want to be? (pick from Team members and write the name)");
                p = Console.ReadLine();
                player = teamCreatureDictionary[p];
                Console.WriteLine("What Creature do you want to fight? (pick from Enemys and write the name)");
                e = Console.ReadLine();
                enemy = enemyCreatureDictionary[e];
                while (x < 10)
                {
                    player.Hit(enemy);
                    if (player.IsDead())
                    {
                        Console.WriteLine("You lost!");
                        Console.ReadLine();
                        player.Revive();
                        enemy.Revive();
                        break;
                    }
                    enemy.Hit(player);
                    if (enemy.IsDead())
                    {
                        Console.WriteLine("You won!");
                        Console.ReadLine();
                        player.Revive();
                        enemy.Revive();
                        break;
                    }
                    else if(enemy.IsDead() && player.IsDead())
                    {
                        Console.WriteLine("There was a tie");
                        Console.ReadLine();
                        player.Revive();
                        enemy.Revive();
                        break;
                    }
                }
            }
            
            //int s = 0;
            //while (s < 1)
            //{
            //    Console.WriteLine("Press Enter to start fighting.");
            //    Console.ReadLine();
            //    int y = 0;
            //    while (y < 110000000)
            //    {
            //        y++;

            //        human.Hit(ogre);
            //        human.Hit(demonGod);
            //        if(human.Hp < 60)
            //        {
            //            human.GetHeal2(slime);
            //        }
            //        if (human.IsDead() && slime.IsDead() && werewolf.IsDead())
            //        {
            //            Console.WriteLine("The battle has been lost");
            //            break;
            //        }
            //        else
            //        {
            //            Wave1();

            //            if (ogre.IsDead() && fox.IsDead() && demon.IsDead() && demonGod.IsDead())
            //            {
            //                Console.WriteLine("The Battle has been won!!");
            //                break;
            //            }

            //            else if (human.IsDead() && slime.IsDead() && werewolf.IsDead())
            //            {
            //                Console.WriteLine("The battle has been lost");
            //                break;

            //            }

            //        }
            //        Wave2();
            //    }
            //    string answer;
            //    Console.WriteLine("Do you want to Battle again?(Yes or No)");
            //    answer = Console.ReadLine();
            //    if (answer == "Yes")
            //    {
            //        ogre.Revive();
            //        fox.Revive();
            //        human.Revive();
            //        demon.Revive();
            //        slime.Revive();
            //        demonGod.Revive();
            //        werewolf.Revive();
            //    }
            //    else if (answer == "No")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error, Forgot to capitalize or typed in a not valid answer.");
            //        Console.WriteLine("The Program will end Because of this, press Enter.");
            //        Console.ReadLine();
            //        break;
            //    }
            //}


            //void Wave1()
            //{
            //    human.Hit(ogre);
            //    ogre.Hit(human);
            //    human.GetHeal2(slime);
            //    slime.Hit(fox);
            //    human.Hit(fox);
            //    werewolf.Hit(ogre);
            //    human.Hit(demon);
            //    demonGod.Hit(slime);
            //}

            //void Wave2()
            //{
            //    slime.Hit(ogre);
            //    fox.Hit(human);
            //    human.GetHeal2(slime);
            //    ogre.GetHeal2(fox);
            //    ogre.Hit(werewolf);
            //    demon.Hit(human);
            //    human.Hit(demonGod);
            //    demonGod.Hit(human);
            //    demonGod.Hit(slime);
            //    demonGod.Hit(werewolf);
            //}
            
        }
    }
}
