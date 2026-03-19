namespace snakee
{
    internal class Program
    {
        private static GameState gameState;
        static void Main(string[] args)
        {
            //GameState gameState = new GameState();

           
            Snake _snake = new Snake();
            Frame _frame = new Frame();
            Food _food = new Food();
            
            //инициализировать начальное состаяние игры
            while (!gameState.Exit)
            {
                // 1.обновить состояние игры
                UpdateGameState(_frame, _snake, _food);
                // 2.стереть старый кадр
                ClearScreen();
                // 3.нарисовать новый кадр
                DrawFrame(_frame, _snake, _food);
                // 4. пауза между кадрами
                wite(gameState.fps);
            }
        }  

        private static void DrawFrame(object frame, object snake, object food)
        {
            throw new NotImplementedException();
        }       

        private static void UpdateGameState(object frame, object snake, object food)
        {
            throw new NotImplementedException();
        }

        private static void ClearScreen()
        {
            Console.Clear();
        }

        private static void wite(int time)
        {
           Thread.Sleep(time);
        }
    }
}
