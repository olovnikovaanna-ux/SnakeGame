//using System.Drawing;
//using System.Transactions;
//using static System.Net.Mime.MediaTypeNames;


//internal class Program2
//{

   

   
     
    

//    private static void Main(string[] args)
//    {
//        int _playerX = 5;
//        int _playerY = 10;
//        bool flag = true;

//        //char BORDER_CHAR = '#';
//        //int OFFSET = 5;
//        //int fps = 100;
//        //int fieldWidth;
//        //int fieldHeight;

//        //Console.CursorVisible = false;
//        ////Console.WindowWidth = 60;                   
//        ////Console.WindowHeight = 30;                  
//        //fieldWidth = Console.WindowWidth;
//        //fieldHeight = Console.WindowHeight;

//        //int width = 77;
//        //int height = 100;
//        //int offset = 3;
//        //char borderChar = '#';


//        //int upperBorder = offset;           // верхняя граница поля
//        //int lowerBorder = offset + height;  // нижняя граница поля
//        //int leftBorder = offset;            // левая граница поля
//        //int rightBorder = offset + width;   // правая граница поля


//        SetCursorPosition(playerX: 43, playerY: 3);
//        WriteColor("ЧТОБЫ НАЧАТЬ ИГРУ, НАЖМИТЕ", ConsoleColor.Green);  
//        WriteColor(" ENTER\n");


//        for (int i = 0; i < 101; i++)
//        {
//            Console.Write("#");

//        }
//        SetCursorPosition(0, 25);
//        for (int i = 0; i < 101; i++)
//        {
//            Console.Write("#");

//        }

//        SetCursorPosition(0, 4);
//        for (int i = 0; i < 21; i++)
//        {
//            Console.WriteLine("#");

//        }

//        SetCursorPosition(101, 4);
//        for (int i = 101; i < 102; i++)
//        {
//            Console.WriteLine("#");
            
//        }

//        ConsoleKey key2 = Console.ReadKey(true).Key; // TO DO:

//        if (key2 == ConsoleKey.Enter)
//        {
//            Console.Beep(400, 300);



//            while (flag)
//            {


//                //Console.Clear();

//                //for (int x = leftBorder; x < rightBorder; x++)
//                //{
//                //    Console.SetCursorPosition(x, upperBorder);
//                //    Console.Write(borderChar);
//                //}

//                //for (int x = leftBorder; x < rightBorder; x++)
//                //{
//                //    Console.SetCursorPosition(x, lowerBorder);
//                //    Console.Write(borderChar);
//                //}

//                //for (int y = upperBorder; y < lowerBorder; y++)
//                //{
//                //    Console.SetCursorPosition(leftBorder, y);
//                //    Console.Write(borderChar);
//                //}

//                //for (int y = upperBorder; y < lowerBorder; y++)
//                //{
//                //    Console.SetCursorPosition(rightBorder, y);
//                //    Console.Write(borderChar);
//                //}



//                if (_playerX == 100)
//                {
//                    _playerX = 0;
//                }

//                if (_playerY == 24)
//                {
//                    _playerY = 4;
//                }

//                if (Console.KeyAvailable)  //если что то нажато
//                {
//                    ConsoleKey key = Console.ReadKey(true).Key;
//                    if (key == ConsoleKey.Escape)
//                    {
//                        flag = false;
//                        Console.Beep(500, 200); // 500-частота гц, 200-длительность
//                        Console.Clear();

//                         SetCursorPosition(playerX: 50, playerY: 3);
//                        WriteColor("==== GAME OVER ====", ConsoleColor.Red);                        
//                        continue;
//                    }


//                    if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
//                        _playerY--;
//                    if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
//                        _playerY++;
//                    if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
//                        _playerX--;
//                    if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
//                        _playerX++;



//                    if (key == ConsoleKey.Spacebar)
//                    {
//                        SetCursorPosition(playerX: 58, playerY: 3);

//                        WriteColor("ПАУЗА", ConsoleColor.Yellow);
//                    }



//                    if (key == ConsoleKey.P)

//                    {

//                        SetCursorPosition(playerX: 25, playerY: 3);
//                        Console.ForegroundColor = ConsoleColor.Green;
//                        Console.WriteLine("вы поставили игру на паузу. для продолжения повторно нажмите P");
//                        Console.ResetColor();
//                        Console.ReadKey();
//                        while (key != ConsoleKey.P)
//                        {
//                            key = Console.ReadKey(true).Key;
//                        }
//                    }



//                }

//                //void DraveSnake()
//                //{


//                //    Console.Clear();
//                //    SetCursorPosition(_playerX, _playerY);
//                //    Console.Beep(2000, 150);
//                //    Console.WriteLine("@");
//                //    Thread.Sleep(50);
//                //}


//                Console.Clear();
//                SetCursorPosition(_playerX, _playerY);
//                Console.Beep(2000, 150);
//                Console.WriteLine("@");
//                Thread.Sleep(50);

//            }

//        }



//    }


//    // void DraveSnake()
//    //{
//    //    int _playerX = 5;
//    //    int _playerY = 10;

//    //    Console.Clear();
//    //    SetCursorPosition(_playerX, _playerY);
//    //    Console.Beep(2000, 150);
//    //    Console.WriteLine("@");
//    //    Thread.Sleep(50);
//    //}


//    private static void WriteColor(string text, ConsoleColor color = ConsoleColor.White)
//    {
//        Console.ForegroundColor = color;
//        Console.Write(text);
//        Console.ResetColor();
//    }


//    private static void SetCursorPosition(int playerX = 5, int playerY = 10)
//    {
//        Console.SetCursorPosition(playerX, playerY);
//    }
//}