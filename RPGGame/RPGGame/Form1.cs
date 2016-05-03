// Nathan Lewis - RPGGame - 4-18-16
// x and y variables always refure to the x and y gameboard grid in relation to "Tiles CLass"

// Notes - This was by far the largest project I have done to date.  It turned out well, but I got into
// trouble because I used textboxes to store data that did not nessisarly have an object or variable storing 
// the same data.  This gave me problems when it came to loading the game and saving the game.  I ended up
// having to do some odd things to compensate for it.  Overall I do not think it was a good idea to do it.
// Beucause of this I do not know if I will do more with the game.  I may start over and avoid making the 
// same mistakes.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RPGGame
{
    public partial class Form1 : Form
    {
        Player hero = new Player(1, 1, 25, 25, 1);
        Player[] monster = new Player[25];

        Equipment sword = new Equipment("Sword", 0, 0, 0);
        Equipment helm = new Equipment("Helm", 0, 0, 0);
        Equipment chestPlate = new Equipment("Chest Plate", 0, 0, 0);
        Equipment sheald = new Equipment("Sheald", 0, 0, 0);
        Equipment magicRing = new Equipment("Magic Ring", 0, 0, 0);
        Equipment openLootSlot = new Equipment();

        static int gameBoardWidth = 60;
        static int gameBoardHeight = 60;        
        Tile[,] aTile = new Tile[gameBoardWidth, gameBoardHeight];
        //                   this is  x (L / R)  this is y (up / down)
        

        int playerUpCount = -6;          // for the board movement
        int playerRightCount = -6;       // for the board movement
        bool onlyOneTime = true;         // for things that should only happen one time on start up  

        OnBoardItem[] chest = new OnBoardItem[3];
        

        static int lootMonsters = 0;     // this is for the loot system.  if it is more than 0 the player can loot an item
        static int gameLvl = 1;          // this controls the lvl of the game it will go up if askes

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        //++++++++++++++++++++++++ drawing functions ++++++++++++++++++++++++++++++++++//
        private void btnLoad_Click(object sender, EventArgs e)
        {
            drawGameBoard();
            string[] files = new string[15];
            StreamReader gamefiles = new StreamReader("GameData.txt");

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = gamefiles.ReadLine();
            }
            gamefiles.Close();

            helm.hp = Convert.ToInt32(files[0]);
            helm.mana = Convert.ToInt32(files[1]);
            helm.str = Convert.ToInt32(files[2]);

            chestPlate.hp = Convert.ToInt32(files[3]);
            chestPlate.mana = Convert.ToInt32(files[4]);
            chestPlate.str = Convert.ToInt32(files[5]);
            
            sword.hp = Convert.ToInt32(files[6]);
            sword.mana = Convert.ToInt32(files[7]);
            sword.str = Convert.ToInt32(files[8]);
            
            sheald.hp = Convert.ToInt32(files[9]);
            sheald.mana = Convert.ToInt32(files[10]);
            sheald. str = Convert.ToInt32(files[11]);
            
            magicRing.hp = Convert.ToInt32(files[12]);
            magicRing.mana = Convert.ToInt32(files[13]);
            magicRing.str = Convert.ToInt32(files[14]);           
        }

        private void drawGameBoard()
        {           
            drawAllsquares();
            drawTreepatch1();
            drawTreeBoarder();
            drawRandomTrees();
            drawcastle();
           
            if (onlyOneTime == true)
            {
                buildMonsters();
                buildLootChest();
                onlyOneTime = false;
                
            }
            int i;
            for (i = 0; i < chest.Length; i++)
            {
                drawLootChest(chest[i]);
            }
            drawHero();
   
        }

        private void drawAllsquares()
        {
            int x = 0;
            int y = 0;

            for (x = 0; x < gameBoardWidth; x++)
            {
                for ( y = 0; y < gameBoardHeight; y++)
                {
                    int tilePixLeft = 25 * x;
                    int tilePixTop = 25 * y;

                    aTile[x,y]  = new Tile(x, y, false, tilePixLeft, tilePixTop);
                }
            }            
        }

        private void drawTreeBoarder()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush green = new SolidBrush(Color.Green);
            Brush brown = new SolidBrush(Color.Brown);

            int x = 0;
            int y = 0;
            bool solid = true;

            for (x = 0; x < gameBoardWidth; x++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }

            x = 0;
            for (y = 0; y < gameBoardHeight; y++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }

            y = 51; // can replace this with gameBoardHeight - 1 if not building on windows 10 computer
            for( x = 0; x < gameBoardWidth; x++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }

            x = 52; // can replace this with gameBoardWidth - 1;
            for (y = 0; y < gameBoardHeight; y++)
            {
                int tilePixLeft = 25 * x;
                int tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
            }
        }

        private void drawTreepatch1()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush green = new SolidBrush(Color.Green);
            Brush brown = new SolidBrush(Color.Brown);

            int x = 0;
            int y = 0;
            bool solid = true;

            for (x = 4; x < 30; x++)
            {
                for (y = 4; y < 7; y++)
                {
                    int tilePixLeft = 25 * x;
                    int tilePixTop = 25 * y;

                    aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                    gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                    gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
                }
            }
        }

        private void drawRandomTrees()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush green = new SolidBrush(Color.Green);
            Brush brown = new SolidBrush(Color.Brown);


            int x = 0;
            int y = 0;
            bool solid = true;

            for (y = 0; y < gameBoardHeight; y++)
            {
                for (x = 0; x < gameBoardWidth; x++)
                {
                    int tilePixLeft = 25 * x;
                    int tilePixTop = 25 * y;
                    if (x % 4 == 0 && y % 4 == 0)
                    {
                        aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);

                        gObject.FillRectangle(green, tilePixLeft + 5, tilePixTop + 5, 13, 13);
                        gObject.FillRectangle(brown, tilePixLeft + 10, tilePixTop + 13, 5, 12);
                    }

                }
            }



        }

        private void drawcastle()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Brush gray = new SolidBrush(Color.Gray);

            int tilePixLeft;
            int tilePixTop;
            bool solid = true;

            int x;
            int y = 25;
            
            for (x = 4; x < 25; x++)
            {
                tilePixLeft = 25 * x;
                tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);
                gObject.FillRectangle(black, tilePixLeft, tilePixTop, 25, 25);
                gObject.FillRectangle(gray, tilePixLeft + 5, tilePixTop + 5, 15, 15);
            }
            y = 35;
            for (x = 4; x < 25; x++)
            {
                tilePixLeft = 25 * x;
                tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);
                gObject.FillRectangle(black, tilePixLeft, tilePixTop, 25, 25);
                gObject.FillRectangle(gray, tilePixLeft + 5, tilePixTop + 5, 15, 15);

                if ( x == 14)
                {
                    x = 17;
                }
            }
            x = 4;
            for (y = 25; y < 35; y++)
            {
                tilePixLeft = 25 * x;
                tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);
                gObject.FillRectangle(black, tilePixLeft, tilePixTop, 25, 25);
                gObject.FillRectangle(gray, tilePixLeft + 5, tilePixTop + 5, 15, 15);
            }
            x = 25;
            for (y = 25; y < 36; y++)
            {
                tilePixLeft = 25 * x;
                tilePixTop = 25 * y;

                aTile[x, y] = new Tile(x, y, solid, tilePixLeft, tilePixTop);
                gObject.FillRectangle(black, tilePixLeft, tilePixTop, 25, 25);
                gObject.FillRectangle(gray, tilePixLeft + 5, tilePixTop + 5, 15, 15);
            }
        }

        private void buildLootChest()
        {
                   
            int setleft = 36;
            int setTop = 17;
            chest[0] = new OnBoardItem(setleft, setTop, setleft * 25, setTop * 25);
            setleft = 23;
            setTop = 3;
            chest[1] = new OnBoardItem(setleft, setTop, setleft * 25, setTop * 25);
            setleft = 24;
            setTop = 3;
            chest[2] = new OnBoardItem(setleft, setTop, setleft * 25, setTop * 25);

            int i;
            for (i = 0; i < chest.Length; i++)
            {
                drawLootChest(chest[i]);
            }                
        }

        private void drawLootChest(OnBoardItem aChest)
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Brush brown = new SolidBrush(Color.Brown);
            Brush olive = new SolidBrush(Color.Olive);
            Brush gold = new SolidBrush(Color.Gold);
        
            gObject.FillRectangle(olive, aChest.left, aChest.top, 25, 25);
            gObject.FillRectangle(black, aChest.left + 5, aChest.top + 5, 15, 15);
            gObject.FillRectangle(brown, aChest.left + 6, aChest.top + 6, 13, 2);
            gObject.FillRectangle(brown, aChest.left + 6, aChest.top + 11, 13, 7);
            gObject.FillRectangle(gold, aChest.left + 11, aChest.top + 10, 3, 3);

        }

        private void drawHero()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
            Brush gray = new SolidBrush(Color.Gray);
            Brush yellow = new SolidBrush(Color.Yellow);

            printStates();              // controls the text boxes that display hitpoints and mana

            hero.left = hero.tileX * 25;
            hero.top = hero.tileY * 25;

            gObject.FillRectangle(black, hero.left + 10, hero.top + 5, 5, 18);
            gObject.FillRectangle(yellow, hero.left + 11, hero.top + 2, 3, 19);   // sword
            gObject.FillRectangle(black, hero.left + 20, hero.top + 7, 3, 14);
            gObject.FillRectangle(black, hero.left + 8, hero.top + 3, 7, 7);
            gObject.FillRectangle(black, hero.left + 11, hero.top + 15, 7, 3);
            gObject.FillRectangle(yellow, hero.left + 9, hero.top + 4 , 2, 2);     // eyes
            gObject.FillRectangle(yellow, hero.left + 13, hero.top + 4, 2, 2);     //
            gObject.FillRectangle(yellow, hero.left + 17, hero.top + 14, 4, 4);    // hands
        }

        private void cleanSquare()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush Olive = new SolidBrush(Color.Olive);
            gObject.FillRectangle(Olive, hero.left, hero.top, 25, 25);
        }

  
//+++++++++++++++++++++++++++ player movement +++++++++++++++++++++++++++++++++//
        private void BtnPlayerRight_Click(object sender, EventArgs e)
        {
            int x = hero.tileX + 1;
            int y = hero.tileY; 
            if (aTile[x,y].solid == false)
            {
                cleanSquare();
                hero.tileX = hero.tileX + 1;
                hero.left = x * 25;
                drawHero();
                playerRightCount++;
            }

            if (playerRightCount == 3)
            {
                canvas.Left = canvas.Left - 75;
                playerRightCount = 0;
                drawGameBoard();
            }
            monsterChoice();
        }

        private void btnPlayerLeft_Click(object sender, EventArgs e)
        {
            int x = hero.tileX + -1;
            int y = hero.tileY;
            if (aTile[x, y].solid == false)
            {
                cleanSquare();
                hero.tileX = hero.tileX - 1;
                hero.left = x * 25;
                drawHero();
               playerRightCount--;
            }

            if (playerRightCount == -3)
            {      
                canvas.Left = canvas.Left + 75;
                playerRightCount = 0;
                drawGameBoard();
            }
            monsterChoice();
        }

        private void btnPlayerUp_Click(object sender, EventArgs e)
        {
            int x = hero.tileX;
            int y = hero.tileY - 1;
            if (aTile[x, y].solid == false)
            {
                cleanSquare();
                hero.tileY = hero.tileY - 1;
                hero.top = y * 25;
                drawHero();
                playerUpCount--;
            }

            if (playerUpCount == -3)
            {
                canvas.Top = canvas.Top + 75;
                playerUpCount = 0;
                drawGameBoard();
            }
            monsterChoice();
        }

        private void btnPlayerDown_Click(object sender, EventArgs e)
        {
            int x = hero.tileX;
            int y = hero.tileY + 1;
            if (aTile[x, y].solid == false)
            {
                cleanSquare();
                hero.tileY = hero.tileY + 1;
                hero.top = y * 25;
                drawHero();
                playerUpCount++;
            }

            if (playerUpCount == 3)
            {
                canvas.Top = canvas.Top - 75;
                playerUpCount = 0;
                drawGameBoard();
            }
            monsterChoice();
        }


        //++++++++++++++++++++++++++++ player actions +++++++++++++++++++++++++++++++++//
        private void btnAttack_Click(object sender, EventArgs e)
        {
            int i;


            for(i = 0; i < monster.Length; i++)
            {
                if (monster[i].tileX - 1 <= hero.tileX && hero.tileX <= monster[i].tileX + 1 &&
                monster[i].tileY - 1 <= hero.tileY && hero.tileY <= monster[i].tileY + 1)
                {
                    hero.attacking(monster[i]);
                    if (monster[i].hp <= 0)
                    {
                        killMonster(monster[i]);                       
                    }
                    clearMonster(monster[i]);
                    drawMonsters(monster[i], monster[i].hp);
                    break;
                }               
            }
            monsterChoice();
            drawHero();
        }
        
        private void playerDie()
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush black = new SolidBrush(Color.Black);
           
            int x, y;
            for (x = 0; x < gameBoardWidth; x ++)
            {
                for(y = 0; y < gameBoardHeight; y++)
                {
                    int tilePixLeft = 25 * x;
                    int tilePixTop = 25 * y;

                    aTile[x, y] = new Tile(x, y, false, tilePixLeft, tilePixTop);

                    gObject.FillRectangle(black, tilePixLeft, tilePixTop, 25, 25);

                }

            }
            MessageBox.Show("dead");
            hero.tileX = 3;
            hero.tileY = 3;
            canvas.Top = 0;
            canvas.Left = 0;
            playerUpCount = -6;          // for the board movement
            playerRightCount = -6;
            drawGameBoard();
           
            hero.hp = Convert.ToInt32(txtMaxHp.Text);
            hero.mana = Convert.ToInt32(txtMaxMana.Text);
        }


        //+++++++++++++++++++++++++++ monster functions +++++++++++++++++++++++++++++++//
        private void buildMonsters()
        {
            int setleft = 37;
            int setTop = 17;            
            monster[0] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 35;
            setTop = 17;
            monster[1] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 36;
            setTop = 18;
            monster[2] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 36;
            setTop = 3;
            monster[3] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 37;
            setTop = 3;
            monster[4] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 38;
            setTop = 3;
            monster[5] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 39;
            setTop = 3;
            monster[6] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 40;
            setTop = 3;
            monster[7] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 41;
            setTop = 3;
            monster[8] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 34;
            setTop = 4;
            monster[9] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 35;
            setTop = 4;
            monster[10] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 36;
            setTop = 4;
            monster[11] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 37;
            setTop = 4;
            monster[12] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 38;
            setTop = 4;
            monster[13] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 39;
            setTop = 4;
            monster[14] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 40;
            setTop = 4;
            monster[15] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 41;
            setTop = 4;
            monster[16] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 34;
            setTop = 5;
            monster[17] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 35;
            setTop = 5;
            monster[18] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 36;
            setTop = 5;
            monster[19] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 37;
            setTop = 5;
            monster[20] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 38;
            setTop = 5;
            monster[21] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 39;
            setTop = 5;
            monster[22] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 40;
            setTop = 5;
            monster[23] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);
            setleft = 41;
            setTop = 5;
            monster[24] = new Player(setleft, setTop, setleft * 25, setTop * 25, 1);

            int i;
            for (i = 0; i < monster.Length; i++)
            {
                drawMonsters(monster[i], monster[i].hp);
            }           
        }

        private void clearMonster(Player monster)
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush olive = new SolidBrush(Color.Olive);

            monster.left = monster.tileX * 25;
            monster.top = monster.tileY * 25;

            gObject.FillRectangle(olive, monster.left, monster.top, 25, 25);
        }

        private void drawMonsters(Player monster, int hp)
        {
            if  (monster.lvl == 1 ) { hp = hp * 2; }

            Graphics gObject = canvas.CreateGraphics();
            Brush blue = new SolidBrush(Color.Blue);
            Brush darkRed = new SolidBrush(Color.DarkRed);
            Brush olive = new SolidBrush(Color.Olive);
            Brush yellow = new SolidBrush(Color.Yellow);

            monster.left = monster.tileX * 25;
            monster.top = monster.tileY * 25;

            gObject.FillRectangle(darkRed, monster.left + 2, monster.top, hp, 2);  // this is the life bars over each mosters
            gObject.FillRectangle(blue, monster.left + 5, monster.top + 5, 15, 15);
            gObject.FillRectangle(olive, monster.left + 11, monster.top + 15, 5, 10);
            gObject.FillRectangle(yellow, monster.left + 7, monster.top + 7, 3, 3);
            gObject.FillRectangle(yellow, monster.left + 15, monster.top + 7, 3, 3);

        }

        private void monsterChoice()
        {
            int i = 0;

            for (i = 0; i < monster.Length; i++)
            {
                if (monster[i].tileX - 1 <= hero.tileX && hero.tileX <= monster[i].tileX + 1 &&
                monster[i].tileY - 1 <= hero.tileY && hero.tileY <= monster[i].tileY + 1)
                {
                    monster[i].attacking(hero);
                    if (hero.hp < 1)
                    {                       
                        playerDie();                       
                    }

                }
                else if (monster[i].tileX - 6 <= hero.tileX && hero.tileX <= monster[i].tileX + 6 &&
                     monster[i].tileY - 6 <= hero.tileY && hero.tileY <= monster[i].tileY + 6)
                { 
               
                    clearMonster(monster[i]);
                    int monsterMayMove = rand.Next(1, 3);
                    if (monsterMayMove == 1)
                    {
                        if (monster[i].tileY > hero.tileY) { monsterMoveUp(monster[i]); }
                        if (monster[i].tileY < hero.tileY) { monsterMoveDown(monster[i]); }
                    }
                    if (monsterMayMove == 2)
                    {
                        if (monster[i].tileX > hero.tileX) { monsterMoveLeft(monster[i]); }
                        if (monster[i].tileX < hero.tileX) { monsterMoveRight(monster[i]); }
                    }                   
                }
                drawMonsters(monster[i], monster[i].hp);
            }           
        }

        private void monsterMoveUp(Player curentMonster)
        {
            int i;
            bool taken = false;
            for (i = 0; i < monster.Length; i++ )
            {
                if (curentMonster.tileY - 1 == monster[i].tileY && curentMonster.tileX == monster[i].tileX) { taken = true; }
            }
            
            if (aTile[curentMonster.tileX, curentMonster.tileY - 1].solid == false && taken == false)
            {
                curentMonster.tileY = curentMonster.tileY - 1;
            }
        }

        private void monsterMoveDown(Player currentMonster)
        {
            int i;
            bool taken = false;
            for (i = 0; i < monster.Length; i++)
            {
                if (currentMonster.tileY + 1 == monster[i].tileY && currentMonster.tileX == monster[i].tileX) { taken = true; }
            }
            if (aTile[currentMonster.tileX, currentMonster.tileY + 1].solid == false && taken == false)
            {
                currentMonster.tileY = currentMonster.tileY + 1;
            }
        }

        private void monsterMoveLeft(Player currentMonster)
        {
            int i;
            bool taken = false;
            for (i = 0; i < monster.Length; i++)
            {
                if (currentMonster.tileX - 1 == monster[i].tileX && currentMonster.tileY == monster[i].tileY) { taken = true; }
            }
            if (aTile[currentMonster.tileX - 1, currentMonster.tileY].solid == false && taken == false)
            {
                currentMonster.tileX = currentMonster.tileX - 1;
            }
        }

        private void monsterMoveRight(Player currentMonster)
        {
            int i;
            bool taken = false;
            for (i = 0; i < monster.Length; i++)
            {
                if (currentMonster.tileX + 1 == monster[i].tileX  && currentMonster.tileY == monster[i].tileY) { taken = true; }
            }

            if (aTile[currentMonster.tileX + 1, currentMonster.tileY].solid == false && taken == false)
            {
                currentMonster.tileX = currentMonster.tileX + 1;
            }
        }

        private void killMonster(Player monster)
        {
            Graphics gObject = canvas.CreateGraphics();
            Brush Olive = new SolidBrush(Color.Olive);
            gObject.FillRectangle(Olive, monster.left, monster.top, 25, 25);

            monster.tileX = 54;
            lootMonsters++;
            btnLoot.BackColor = Color.Blue;
        }


//+++++++++++++++++++++++++++++++++++++++++ invintory and stats ++++++++++++++++++++++++++++++++++++++++//
       private void printStates()
        {
            int playerTotalMaxHp = hero.maxHp + sword.hp + helm.hp + chestPlate.hp + sheald.hp + magicRing.hp;
            int playerTotalMaxMana = hero.maxMana + sword.mana + helm.mana + chestPlate.mana + sheald.mana + magicRing.mana;
            int playerTotalStr = hero.str + sword.str + helm.str + chestPlate.str + sheald.str + magicRing.str;


            txtMaxHp.Text = playerTotalMaxHp.ToString();
            txtMaxMana.Text = playerTotalMaxMana.ToString();
            txtCurrentHp.Text = hero.hp.ToString();
            txtCurrentMana.Text = hero.mana.ToString();

            txtEquipHelmHp.Text = helm.hp.ToString();
            txtEquipHelmMana.Text = helm.mana.ToString();
            txtEquipHelmStr.Text = helm.str.ToString();

            txtEquipChestHp.Text = chestPlate.hp.ToString();
            txtEquipChestMana.Text = chestPlate.mana.ToString();
            txtEquipChestStr.Text = chestPlate.str.ToString();

            txtEquipSwordHp.Text = sword.hp.ToString();
            txtEquipSwordMana.Text = sword.mana.ToString();
            txtEquipSwordStr.Text = sword.str.ToString();

            txtEquipShealdHp.Text = sheald.hp.ToString();
            txtEquipShealdMana.Text = sheald.mana.ToString();
            txtEquipShealdStr.Text = sheald.str.ToString();

            txtEquipRingHp.Text = magicRing.hp.ToString();
            txtEquipRingMana.Text = magicRing.mana.ToString();
            txtEquipRingStr.Text = magicRing.str.ToString();                 
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCurrentMana.Text) > 0 )
            {
                hero.mana = hero.mana - (1 * hero.lvl);
                hero.hp = hero.hp + (5 * hero.lvl);   
            }
            if (hero.hp > Convert.ToInt32(txtMaxHp.Text))
            {
                hero.hp = Convert.ToInt32(txtMaxHp.Text);
            }
            printStates();
        }

        private void btnLoot_Click(object sender, EventArgs e)
        {
            if (lootMonsters > 0)
            {
                lootItem();
                lootMonsters--;
                if (lootMonsters < 1 )
                {
                    btnLoot.BackColor = Color.Silver;
                }
            }
            int i;
            for (i = 0; i < chest.Length; i++)
            {
                if(hero.left == chest[i].left && hero.top == chest[i].top)
                {
                    lootItem();
                    chest[i].tileY = 52;                    // this line and the next line move the chest off the game board
                    chest[i].top = chest[i].tileY * 25;     // and into the other side of the trees
                }
            }                   
        }

        private void lootItem()
        {
            int lootName = rand.Next(1, 6);
            string sLoot = "";
            if (lootName == 1) { sLoot = "Sword"; }
            else if (lootName == 2) { sLoot = "Helm"; }
            else if (lootName == 3) { sLoot = "Chest Plate"; }
            else if (lootName == 4) { sLoot = "Sheald"; }
            else if (lootName == 5) { sLoot = "Magic Ring"; }
            txtLootName.Text = sLoot;

            int lootHp = rand.Next(1, gameLvl);
            txtLootHp.Text = lootHp.ToString();

            int lootMana = rand.Next(1, gameLvl);
            txtLootMana.Text = lootMana.ToString();

            int adjGameLvl = gameLvl - 3;
            if (adjGameLvl < 1)
            {
                adjGameLvl = 1;
            }
            int lootStr = rand.Next(1, adjGameLvl);
            txtLootStr.Text = (lootStr - 1).ToString();
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (txtLootName.Text == "Sword")
            {
                sword.hp = Convert.ToInt32(txtLootHp.Text);
                sword.mana = Convert.ToInt32(txtLootMana.Text);
                sword.str = Convert.ToInt32(txtLootStr.Text);                               
            }
            else if (txtLootName.Text == "Helm")
            {
                helm.hp = Convert.ToInt32(txtLootHp.Text);
                helm.mana = Convert.ToInt32(txtLootMana.Text);
                helm.str = Convert.ToInt32(txtLootStr.Text);
            }
            else if (txtLootName.Text == "Chest Plate")
            {
                chestPlate.hp = Convert.ToInt32(txtLootHp.Text);
                chestPlate.mana = Convert.ToInt32(txtLootMana.Text);
                chestPlate.str = Convert.ToInt32(txtLootStr.Text);
            }
            else if (txtLootName.Text == "Sheald")
            {
                sheald.hp = Convert.ToInt32(txtLootHp.Text);
                sheald.mana = Convert.ToInt32(txtLootMana.Text);
                sheald.str = Convert.ToInt32(txtLootStr.Text);
            }
            else if (txtLootName.Text == "Magic Ring")
            {
                magicRing.hp = Convert.ToInt32(txtLootHp.Text);
                magicRing.mana = Convert.ToInt32(txtLootMana.Text);
                magicRing.str = Convert.ToInt32(txtLootStr.Text);
            }
            printStates();
            resetLootBox();
        }

        private void resetLootBox()
        {
            txtLootName.Text = "";
            txtLootHp.Text = "";
            txtLootMana.Text = "";
            txtLootStr.Text = "";
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
            StreamWriter gameFiles = new StreamWriter("GameData.txt");

            gameFiles.WriteLine(helm.hp.ToString());
            gameFiles.WriteLine(helm.mana.ToString()); 
            gameFiles.WriteLine(helm.str.ToString());

            gameFiles.WriteLine(chestPlate.hp.ToString());
            gameFiles.WriteLine(chestPlate.mana.ToString());
            gameFiles.WriteLine(chestPlate.str.ToString());

            gameFiles.WriteLine(sword.hp.ToString());
            gameFiles.WriteLine(sword.mana.ToString());
            gameFiles.WriteLine(sword.str.ToString());

            gameFiles.WriteLine(sheald.hp.ToString());
            gameFiles.WriteLine(sheald.mana.ToString());
            gameFiles.WriteLine(sheald.str.ToString());

            gameFiles.WriteLine(magicRing.hp.ToString());
            gameFiles.WriteLine(magicRing.mana.ToString());
            gameFiles.WriteLine(magicRing.str.ToString());

            gameFiles.Close();         
        }       
    }
}
