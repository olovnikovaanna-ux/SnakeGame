

using System.Transactions;

int playerX = 5;
int playerY = 10;
ConsoleKey currentKey = ConsoleKey.NoName;
bool flag = true;
int probel = 58;
int probel1 = 3;
int p = 58;
int p1 = 3;
int consoleWindow;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine();
Console.Write("                                            НАЖМИТЕ");
Console.ResetColor();
Console.Write(" ENTER ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("ЧТОБЫ НАЧАТЬ ИГРУ");
Console.ResetColor();
ConsoleKey key2 = Console.ReadKey(true).Key;

if (key2 == ConsoleKey.Enter)
{
    Console.Beep(400, 300);


    while (flag)
    {
        if (Console.KeyAvailable)  //если что то нажато
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                flag = false;
                Console.Beep(500, 200); // 500-частота гц, 200-длительность
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("                                                ==== GAME OVER ====   ");
                Console.ResetColor();
                continue;
            }


            if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                playerY--;
            if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                playerY++;
            if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                playerX--;
            if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                playerX++;


            if (playerX < 0) playerX = 117;
            if (playerX > 117) playerX = 0;
            
            if (playerY < 0) playerY = 29;
            if (playerY > 29) playerY = 0;

            if (key == ConsoleKey.Spacebar)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(probel,probel1 );
                Console.WriteLine("ЗАЧЕМ?"); 
            }
               

               
            if (key == ConsoleKey.P)

            {
                
                Console.SetCursorPosition(p, p1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("          вы поставили игру на паузу. для продолжения повторно нажмите P");
                Console.ResetColor();
                Console.ReadKey();
                while (key != ConsoleKey.P) 
                {
                    key = Console.ReadKey(true).Key;
                }
            }



        }
            Console.Clear();
            Console.SetCursorPosition(playerX, playerY);
            Console.Beep(2000, 150);
            Console.WriteLine("@");
            Thread.Sleep(50);
      }
 }
