

using System.Transactions;

int playerX = 5;
int playerY = 10;
bool flag = true;
int probel = 58;
int probel1 = 3;
int p = 58;
int p1 = 3;
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
            ConsoleKey key3 = Console.ReadKey(true).Key;
            if (key3 == ConsoleKey.Spacebar)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(probel,probel1 );
                Console.WriteLine("ЗАЧЕМ?"); 
            }
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

                ConsoleKey key1 = Console.ReadKey(true).Key;
                if (key == ConsoleKey.P)

                {
                Console.ForegroundColor = ConsoleColor.Green;                    
                Console.WriteLine("вы поставили игру на паузу. для продолжения повторно нажмите P");
                Console.SetCursorPosition(playerX--, playerY--);
                Console.ResetColor();
            }

            }
            Console.Clear();
            Console.SetCursorPosition(playerX++, playerY++);
            Console.Beep(2000, 150);
            Console.WriteLine("@");
            Thread.Sleep(50);


        }
    }
