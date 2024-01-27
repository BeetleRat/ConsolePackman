using System;

namespace ConsolePackman
{
    public class Game
    {
        private Player player;
        private bool isGameStart;
        private char[,] currentMap;
        private int priceCount;

        public static void Start(int priceCount)
        {
            if (priceCount >= 0)
            {
                new Game(priceCount);
            }
            else
            {
                Console.WriteLine("Количество призов должно быть положительным");
            }
        }

        public Game(int priceCount)
        {
            this.priceCount = priceCount;
            IntiMap();
            StartGame();
        }

        private void IntiMap()
        {
            currentMap = Maps.MAP1;
            InitConsole();
            SetPrices();
            CountPrices();
        }

        private void InitConsole()
        {
            // Отключаем видимость каретки в консоли
            Console.CursorVisible = false;
            int newWidth = Math.Max(Console.BufferWidth, currentMap.GetLength(1) + 6);
            int newHeight = Math.Max(Console.BufferHeight, currentMap.GetLength(0) + 6);
            // Устанавливаем размер буфера консоли
            Console.SetBufferSize(newWidth, newHeight);
        }

        private void SetPrices()
        {
            Random random = new Random();
            int x;
            int y;
            while (priceCount >= 0)
            {
                x = random.Next(currentMap.GetLength(1));
                y = random.Next(currentMap.GetLength(0));

                if (currentMap[y, x] == Maps._)
                {
                    currentMap[y, x] = Maps.X;
                    priceCount--;
                }
            }
        }

        private void CountPrices()
        {
            foreach (char cell in currentMap)
            {
                if (cell == Maps.X)
                {
                    priceCount++;
                }
            }
        }

        private void StartGame()
        {
            player = Player.OnPosition(1, 1);
            isGameStart = true;

            // Отрисовываем кадры игры
            PrintFrames();
        }

        private void PrintFrames()
        {
            while (isGameStart)
            {
                PrintMap();
                PrintPlayer();
                PrintBag();
                ReadNewPlayerPosition();
                Console.Clear();
            }

            EndGame();
        }

        private void PrintMap()
        {
            for (int i = 0; i < currentMap.GetLength(0); i++)
            {
                for (int j = 0; j < currentMap.GetLength(1); j++)
                {
                    Console.Write(currentMap[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private void PrintPlayer()
        {
            Console.SetCursorPosition(player.Position.X * 2, player.Position.Y);
            Console.Write(player.Symbol);
        }

        private void PrintBag()
        {
            Console.SetCursorPosition(0, currentMap.GetLength(0) + 5);
            Console.Write("Сумка: ");
            foreach (char item in player.Bag)
            {
                Console.Write(item + " ");
            }
        }

        private void ReadNewPlayerPosition()
        {
            ConsoleKeyInfo readKey = Console.ReadKey();
            int positionX = player.Position.X;
            int positionY = player.Position.Y;
            switch (readKey.Key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    ChangePlayerPosition(new Vector2D(positionX, positionY - 1));
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    ChangePlayerPosition(new Vector2D(positionX, positionY + 1));
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    ChangePlayerPosition(new Vector2D(positionX - 1, positionY));
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    ChangePlayerPosition(new Vector2D(positionX + 1, positionY));
                    break;
                case ConsoleKey.Q:
                    isGameStart = false;
                    break;
            }
        }

        private void ChangePlayerPosition(Vector2D newPosition)
        {
            if (newPosition.X >= 0 && newPosition.Y >= 0
                                   && currentMap[newPosition.Y, newPosition.X] != '#')
            {
                player.Position = newPosition;
                CheckCell();
            }
        }

        private void CheckCell()
        {
            if (currentMap[player.Position.Y, player.Position.X] == Maps.X)
            {
                player.PutItemToBag(Maps.X);
                currentMap[player.Position.Y, player.Position.X] = Maps.OpenX;
                if (player.Bag.Count == priceCount)
                {
                    isGameStart = false;
                }
            }
        }

        private void EndGame()
        {
            currentMap = Maps.WIN_MAP;
            InitConsole();
            PrintMap();
            PrintBag();
            Console.ReadKey();
        }
    }
}