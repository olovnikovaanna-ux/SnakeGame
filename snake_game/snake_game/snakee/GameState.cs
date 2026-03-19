using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace snakee
{
    public class GameState
    {
        public Food Food;
        public Snake Snake;
        public Frame Frame;
        public bool Pause = false;
        public bool Exit = false;
        public int Fps;

        public GameState(bool exit)
        {
            if (Exit = true);
            {
                Console.WriteLine("game over");
                Console.ReadKey();                
                Console.Clear();
            }
        }

        public GameStat(bool pause)
        {
            if (Pause = true) ;
            {
                 (Pause) = (!Pause);
                Console.WriteLine("вы поставили игру на паузу");                               
            }
        }
    }
}
