using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Tile
    {
        private int cTileX;
        private int cTileY;
        private bool cSolid = true;
        private int cLeft;
        private int cTop;

        public Tile(int tileX, int tileY, bool solid, int top, int left)
        {            
            cTileX = tileX;
            cTileY = tileY;
            cSolid = solid;
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
        public bool solid
        {
            set { cSolid = value; }
            get { return cSolid; }

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
