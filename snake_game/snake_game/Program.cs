namespace snake_game
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int playerX = 5;
            int playerY = 10;
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.SetCursorPosition(playerX++, playerY++);
                Console.WriteLine("@");
                Thread.Sleep(100);
            }
        }
    }
}