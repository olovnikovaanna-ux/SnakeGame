

int playerX = 5;
int playerY = 10;
bool flag = true;

while (flag)
{
    if (Console.KeyAvailable)  //если что то нажато
    {
        ConsoleKey key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.Escape) //если клавиша esc нажата
        {
            flag = false;
            continue;
        }
    }
    Console.Clear();
    Console.SetCursorPosition(playerX++, playerY++);
    Console.WriteLine("@");
    Thread.Sleep(100);
}
