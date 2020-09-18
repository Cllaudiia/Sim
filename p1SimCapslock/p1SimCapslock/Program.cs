using System;
using System.Security.Cryptography;

namespace p1_sim_capslock
{
    
    class Program
    {
        Random r = new Random();
        
        public int dawn(int amount)
        {
            int damage = 0;
            for (int i = 0; i < amount; i++)
            {
                damage += r.Next(75, 151);
            }
            return damage;
            
        }
        int scythe(int amount)
        {
            
            int damage = 0;
            for (int i = 0; i < amount; i++)
            {
                double acc = r.NextDouble();
                int verzik = r.Next(0, 11);
                int playerRoll = (acc > .9612) ? 0 : r.Next(0,49);
                int verzikRoll = r.Next(0, 11);
                damage += (playerRoll > verzikRoll) ? verzikRoll : playerRoll;

                playerRoll = (acc > .9612) ? 0 : r.Next(0,25);
                verzikRoll = r.Next(0, 11);
                damage += (playerRoll > verzikRoll) ? verzikRoll : playerRoll;

                playerRoll = (acc > .9612) ? 0 : r.Next(0,13);
                verzikRoll = r.Next(0, 11);
                damage += (playerRoll > verzikRoll) ? verzikRoll : playerRoll;
            }
            return damage;
        }
        int blade(int amount)
        {
            int damage = 0;
            for (int i = 0; i < amount; i++)
            {
                double acc = r.NextDouble();
                int playerRoll = (acc > .9371) ? 0 : r.Next(0,31);
                int verzikRoll = r.Next(0,11);
                damage += (playerRoll > verzikRoll) ? verzikRoll : playerRoll;
            }
            return damage;
        }
        int claw(int amount)
        {
            int damage = 0;
            for (int i = 0; i < amount; i++)
            {
                double acc = r.NextDouble();
                int playerRoll = (acc > .9481) ? 0 : r.Next(0,44);
                int verzikRoll = r.Next(0,11);
                damage += (playerRoll > verzikRoll) ? verzikRoll : playerRoll;
            }
            return damage;
        }
        int trident(int amount)
        {
            int damage = 0;
            for (int i = 0; i < amount; i++)
            {
                double acc = r.NextDouble();
                int playerRoll = (acc > .9289) ? 0 : r.Next(0,29);
                int verzikRoll = r.Next(0,4);
                damage += (playerRoll > verzikRoll) ? verzikRoll : playerRoll;
            }
            return damage;
        }
        double killOdds(int d, int s, int c, int b, int t)
        {
            double kills = 0;
            for (int i = 0; i < 100000000; i++)
            {
                int hp = 2000;
                hp -= dawn(d);
                hp -= scythe(s);
                hp -= blade(b);
                hp -= trident(t);
                hp -= claw(c);
                if (hp < 1) kills++;
                    
            }
            return kills / 100000000;
        }

        static void Main(string[] args)
        {
            Program kill = new Program();
            Console.WriteLine("tick 53: " + 100* kill.killOdds(12, 41, 2, 1, 1)+ "%");
            Console.WriteLine("tick 54: " + 100* kill.killOdds(12, 42, 2, 1, 1) + "%");
            Console.WriteLine("tick 57: " + 100 * kill.killOdds(13, 43, 2, 1, 1) + "%");
            Console.WriteLine("tick 58: " + 100 * kill.killOdds(13, 44, 3, 1, 1) + "%");
            Console.WriteLine("tick 59: " + 100 * kill.killOdds(13, 45, 3, 1, 1) + "%");
            Console.WriteLine("tick 61: " + 100 * kill.killOdds(13, 46, 3, 1, 1) + "%");
            Console.WriteLine("tick 62: " + 100 * kill.killOdds(14, 47, 3, 1, 1) + "%");
            Console.WriteLine("tick 63: " + 100 * kill.killOdds(14, 48, 3, 1, 1) + "%");
            Console.WriteLine("tick 64: " + 100 * kill.killOdds(14, 49, 3, 1, 1) + "%");




        }
    }
}
