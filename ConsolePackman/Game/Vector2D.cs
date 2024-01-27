namespace ConsolePackman
{
    public struct Vector2D
    {
        private int x;
        private int y;

        public int X => x;
        public int Y => y;

        public Vector2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}