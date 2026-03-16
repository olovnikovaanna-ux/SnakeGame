namespace snakee
{
    internal class Program
    {
        private static GameState _gameState;
        static void Main(string[] args)
        {

         Snake _snake = new Snake();            
         Frame _frame = new Frame();            
         Food _food = new Food();
            int _fps = 100;
        //инициализировать начальное состаяние игры

        // 1.обновить состояние игры
        UpdateGameState(_frame, _snake, _food);
            // 2.стереть старый кадр
            ClearScreen();
            // 3.нарисовать новый кадр
            DrawFrame(_frame, _snake, _food);
            // 4. пауза между кадрами
            Sleep(_fps);
        }

        private static void Sleep(object fps)
        {
            throw new NotImplementedException();
        }

        private static void DrawFrame(object frame, object snake, object food)
        {
            throw new NotImplementedException();
        }

        private static void ClearScreen()
        {
            throw new NotImplementedException();
        }

        private static void UpdateGameState(object frame, object snake, object food)
        {
            throw new NotImplementedException();
        }
    }
}
