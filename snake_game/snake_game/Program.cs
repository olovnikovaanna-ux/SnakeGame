

using System.Transactions;

int playerX = 5;
int playerY = 10;
bool flag = true;
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
            if (key3 == ConsoleKey.Backspace)
            {
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
                    Console.SetCursorPosition(playerX--, playerY--);

                }

            }
            Console.Clear();
            Console.SetCursorPosition(playerX++, playerY++);
            Console.Beep(2000, 150);
            Console.WriteLine("@");
            Thread.Sleep(50);


        }
    }
