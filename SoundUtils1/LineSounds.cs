using System;

namespace SoundUtils
{
    static public class LineSounds
    {
        static public void LinePassSound()
        {
            Console.Beep(1000, 200);
            Console.Beep(500, 400);
            Console.Beep(400, 300);
            Console.Beep(1200, 90);
            Console.Beep(1000, 200);
        }

        static public void DeadSound()
        {
            Console.Beep(1500, 150);
            Console.Beep(150, 150);
            Console.Beep(300, 30);
            Console.Beep(600, 60);
            Console.Beep(1200, 120);
        }

        static public void HealSounds()
        {
            Console.Beep(600, 500);
            Console.Beep(900, 500);
            Console.Beep(2200, 500);
            Console.Beep(800, 1000);
            Console.Beep(900, 1000);
            Console.Beep(1000, 500);
        }

        static public void HitSound()
        {
            Console.Beep(1000, 200);
            Console.Beep(750, 150);
            Console.Beep(500, 100);
            Console.Beep(250, 50);
            Console.Beep(1500, 300);
            Console.Beep(900, 1234);
            Console.Beep(1000, 1234);
        }

        static public void LifeSound()
        {
            Console.Beep(200, 90);
            Console.Beep(50, 120);
            Console.Beep(1000, 200);
            Console.Beep(500, 32);
            Console.Beep(50, 120);
            Console.Beep(200, 90);
            Console.Beep(50, 120);
            Console.Beep(1000, 200);
            Console.Beep(500, 32);
            Console.Beep(50, 120);
        }
    }
}
