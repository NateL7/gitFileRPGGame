using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Player
    {
        private int cTileX;
        private int cTileY;
        private int cLeft;
        private int cTop;
        private int cLvl;
        private int cStr;
        private int cHp;
        private int cMana;
        private int cMaxHp;
        private int cMaxMana;

        public Player(int tileX, int tileY, int left, int top)
        {
            cTileX = tileX;
            cTileY = tileY;
            cLeft = left;
            cTop = top;
        }

        public Player(int tileX, int tileY, int left, int top, int lvl)
        {
            cTileX = tileX;
            cTileY = tileY;
            cLeft = left;
            cTop = top;
            cLvl = lvl;
            cStr = cLvl;
            cHp = cLvl * 10;
            cMana = cLvl * 2;
            cMaxHp = cLvl * 10;
            cMaxMana = cLvl * 2;
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
        public int lvl
        {
            set { cLvl = value; }
            get { return cLvl; }
        }
        public int str
        {
            set { cStr = value; }
            get { return cStr; }
        }
        public int hp
        {
            set { cHp = value; }
            get { return cHp; }
        } 
        public int mana
        {
            set { cMana = value; }
            get { return cMana; }
        }
        public int maxHp
        {
            set { cMaxHp = value; }
            get { return cMaxHp; }
        }
        public int maxMana
        {
            set { cMaxMana = value; }
            get { return cMaxMana; }
        }

        public int attacking(Player defending)
        {
            defending.hp = defending.hp - str;
            return defending.hp;
        }

        public Player healLife(Player hero)
        {
            if (mana > 0)
            {
                hp = hp + 10;
                mana = mana - 1;
                return hero;
            }
            else
            {
                return hero;
            }
            
        }

    }
}
