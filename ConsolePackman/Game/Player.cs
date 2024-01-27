using System.Collections.Generic;

namespace ConsolePackman
{
    public class Player
    {
        private Vector2D position;
        private char symbol = '@';
        private readonly List<char> bag;

        public Vector2D Position
        {
            get => position;
            set => position = value;
        }

        public char Symbol => symbol;

        public List<char> Bag => bag;

        private Player(int x, int y)
        {
            position = new Vector2D(x, y);
            bag = new List<char>();
        }

        public static Player OnPosition(int x, int y)
        {
            return new Player(x, y);
        }

        public void PutItemToBag(char item)
        {
            bag.Add(item);
        }
    }
}