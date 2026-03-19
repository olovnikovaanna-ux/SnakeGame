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
        public bool Pause;
        public bool Exit;
        public int Fps;
    }
}
