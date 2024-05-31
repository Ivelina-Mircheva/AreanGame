using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");

            //warrior and axe try
            Console.WriteLine();
            Console.WriteLine("--------------------------NEW GAME--------------------------");
            GameEngine gE = new GameEngine()
            {
                HeroA = new Warrior("Warrior", 20, 10, new Axe("Axe")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
            };

            gE.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gE.Winner}");

            //hunter and crossbow try
            Console.WriteLine();
            Console.WriteLine("--------------------------NEW GAME--------------------------");
            GameEngine ge = new GameEngine()
            {
                HeroA = new Hunter("Hunter",15, 10, new Crossbow("Crossbow")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
            };
            //Console.WriteLine("Weapon is "+ge.HeroA.Weapon + "on hero "+ge.HeroA);// - да показва оръжията
            ge.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {ge.Winner}");


            //Fire mace try
            Console.WriteLine();
            Console.WriteLine("--------------------------NEW GAME--------------------------");
            GameEngine GE = new GameEngine()
            {
                HeroA = new Hunter("Hunter", 15, 10, new MaceOfFire("fire")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
            };

            GE.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {GE.Winner}");



            //thorHammer try
            Console.WriteLine();
            Console.WriteLine("--------------------------NEW GAME--------------------------");
            GameEngine gameEn = new GameEngine()
            {
                HeroA = new Thor("Thor", 20, 10, new ThorThunderHammer("Hammer")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = ConsoleNotification
            };

            gameEn.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEn.Winner}");
        }
    }
}