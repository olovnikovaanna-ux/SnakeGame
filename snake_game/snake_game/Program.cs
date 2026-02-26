using System.Drawing;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;


internal class Program
{

    
    private static void Main(string[] args)
    {
        int _playerX = 5;
        int _playerY = 10;
        bool flag = true;
        
        SetCursorPosition(playerX: 58, playerY: 3);
        WriteColor("\n\nЧТОБЫ НАЧАТЬ ИГРУ, НАЖМИТЕ", ConsoleColor.Green);  
        WriteColor(" ENTER ");


        ConsoleKey key2 = Console.ReadKey(true).Key; // TO DO:

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

                        SetCursorPosition(playerX: 58, playerY: 3);
                        WriteColor("\n\n==== GAME OVER ====", ConsoleColor.Red);
                        continue;
                    }


                    if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                        _playerY--;
                    if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                        _playerY++;
                    if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                        _playerX--;
                    if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                        _playerX++;



                    if (key == ConsoleKey.Spacebar)
                    {
                        SetCursorPosition(playerX: 58, playerY: 3);

                        WriteColor("ПАУЗА", ConsoleColor.Yellow);
                    }



                    if (key == ConsoleKey.P)

                    {

                        SetCursorPosition(playerX: 58, playerY: 3);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("     вы поставили игру на паузу. для продолжения повторно нажмите P");
                        Console.ResetColor();
                        Console.ReadKey();
                        while (key != ConsoleKey.P)
                        {
                            key = Console.ReadKey(true).Key;
                        }
                    }



                }
                Console.Clear();
                SetCursorPosition(_playerX, _playerY);
                Console.Beep(2000, 150);
                Console.WriteLine("@");
                Thread.Sleep(50);

            }

        }



    }





    private static void WriteColor(string text, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.Write(text);
        Console.ResetColor();
    }


    private static void SetCursorPosition(int playerX = 5, int playerY = 10)
    {
        Console.SetCursorPosition(playerX, playerY);
    }
}