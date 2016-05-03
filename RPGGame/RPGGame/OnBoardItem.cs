using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class OnBoardItem
    {
        private int cTileX;
        private int cTileY;
        private int cLeft;
        private int cTop;

        public OnBoardItem(int tileX, int tileY, int left, int top)
        {
            cTileX = tileX;
            cTileY = tileY;
            cLeft = left;
            cTop = top;
        }

        public int tileX
        {
            set { cTileX = value; }
            get { return cTileX; }
        }
        public int tileY
        {
            set { cTileY = value; }
            get { return cTileY; }
        }
        public int left
        {
            set { cLeft = value; }
            get { return cLeft; }
        }
        public int top
        {
            set { cTop = value; }
            get { return cTop; }
        }

    }
}
