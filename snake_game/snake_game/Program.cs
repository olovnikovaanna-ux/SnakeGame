

int playerX = 5;
int playerY = 10;
bool flag = true;

Console.WriteLine("НАЖМИТЕ ENTER ЧТОБЫ НАЧАТЬ ИГРУ");
ConsoleKey key2 = Console.ReadKey(true).Key;
if (key2 == ConsoleKey.Enter) 
{
    Console.Beep(400, 300);
    while (flag)
    {
        if (Console.KeyAvailable)  //если что то нажато
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape) //если клавиша esc нажата
            {
                flag = false;
                Console.Beep(500, 200); // 500-частота гц, 200-длительность
                continue;
            }

            ConsoleKey key1 = Console.ReadKey(true).Key;
            if (key == ConsoleKey.P)
                
            {                
                Console.SetCursorPosition(playerX--, playerY--);
                
            }
            
        }
        Console.Clear();
        Console.SetCursorPosition(playerX++, playerY++);
        Console.Beep(2000,150);
        Console.WriteLine("@");
        Thread.Sleep(200);

        
    }
}