using System;

namespace AbstractFactory
{
    public abstract class Game
    {
        public abstract void CreateColor();
        public abstract void Statistics();
    }
    public class HorrorGame : Game
    {
        public HorrorGame()
        {
            Console.WriteLine("Создаем страшный постер");
        }
        public override void CreateColor()
        {
            Console.WriteLine("Темная, сдержанная цветокоррекция");
        }
        public override void Statistics()
        {
            Console.WriteLine("Много скримеров");
        }
    }
    public class FunnyGame : Game
    {
        public FunnyGame()
        {
            Console.WriteLine("Создаем забавный постер");
        }
        public override void CreateColor()
        {
            Console.WriteLine("Яркая цветокоррекция");
        }
        public override void Statistics()
        {
            Console.WriteLine("Вставляем шутки");
        }
    }
    public abstract class Scenary
    {
        public abstract void CreateGames();
        public abstract void CreateSizefont();
    }
    public class HorrorGameplay : Scenary
    {
        public HorrorGameplay()
        {
            Console.WriteLine("Страшный сюжет");
        }
        public override void CreateGames()
        {
            Console.WriteLine("Локация заброшенная деревня");
        }
        public override void CreateSizefont()
        {
            Console.WriteLine("Концовка с отсылкой на продолжение");
        }
    }
    public class FunnyGameplay : Scenary
    {
        public FunnyGameplay()
        {
            Console.WriteLine("Сюжет отсутствует");
        }
        public override void CreateGames()
        {
            Console.WriteLine("Добовляем кооператив для игры с друзьями");
        }
        public override void CreateSizefont()
        {
            Console.WriteLine("Счастливый конец");
        }
    }

    public abstract class Games
    {
        public abstract Game CreateImage();
        public abstract Scenary CreateGame();
    }
    public class GamesGrownup : Games
    {
        public GamesGrownup()
        {
            Console.WriteLine("Игра-хоррор");
        }
        public override Game CreateImage()
        {
            return new HorrorGame();
        }
        public override Scenary CreateGame()
        {
            return new HorrorGameplay();
        }
    }
    public class AllAges : Games
    {
        public AllAges()
        {
            Console.WriteLine("Весёлая игра");
        }
        public override Game CreateImage()
        {
            return new FunnyGame();
        }
        public override Scenary CreateGame()
        {
            return new FunnyGameplay();
        }
    }

    public class Controller
    {
        Games Object;
        public Controller(Games Object)
        {
            this.Object = Object;
        }
        public void Create(string f)
        {
            if (f == "6")
            {
                Game im = Object.CreateImage();
                im.CreateColor();
                im.Statistics();
                Scenary fn = Object.CreateGame();
                fn.CreateGames();
                fn.CreateSizefont();
            }
            if (f == "18")
            {
                Game im = Object.CreateImage();
                im.CreateColor();
                im.Statistics();
                Scenary fn = Object.CreateGame();
                fn.CreateGames();
                fn.CreateSizefont();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Controller BG = new Controller(new GamesGrownup());
            BG.Create("18");
            Console.WriteLine("\n");
            Controller BC = new Controller(new AllAges());
            BC.Create("6");
        }
    }
}