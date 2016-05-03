using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Equipment
    {
        private string cType;
        private int cStr;
        private int cHp;
        private int cMana;

        public Equipment()
        {

        }


        public Equipment(string type, int str, int hp, int mana)
        {
            cType = type;
            cStr = str;
            cHp = hp;
            cMana = mana;
        }

        public string type
        {
            set { cType = value; }
            get { return cType; }
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
    }
}
