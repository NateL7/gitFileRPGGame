namespace RPGGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plGameBoard = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPlayerUp = new System.Windows.Forms.Button();
            this.btnPlayerDown = new System.Windows.Forms.Button();
            this.btnPlayerLeft = new System.Windows.Forms.Button();
            this.BtnPlayerRight = new System.Windows.Forms.Button();
            this.txtMaxHp = new System.Windows.Forms.TextBox();
            this.txtMaxMana = new System.Windows.Forms.TextBox();
            this.txtCurrentMana = new System.Windows.Forms.TextBox();
            this.txtCurrentHp = new System.Windows.Forms.TextBox();
            this.txtLootName = new System.Windows.Forms.TextBox();
            this.txtLootHp = new System.Windows.Forms.TextBox();
            this.txtLootMana = new System.Windows.Forms.TextBox();
            this.txtLootStr = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnLoot = new System.Windows.Forms.Button();
            this.btnEquip = new System.Windows.Forms.Button();
            this.btnInvintory = new System.Windows.Forms.Button();
            this.txtHelmStr = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLabelLoot = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLabelRing = new System.Windows.Forms.TextBox();
            this.txtLabelSheald = new System.Windows.Forms.TextBox();
            this.txtLabelSword = new System.Windows.Forms.TextBox();
            this.txtLabel2 = new System.Windows.Forms.TextBox();
            this.txtLabel1 = new System.Windows.Forms.TextBox();
            this.txtEquipRingHp = new System.Windows.Forms.TextBox();
            this.txtEquipRingMana = new System.Windows.Forms.TextBox();
            this.txtEquipRingStr = new System.Windows.Forms.TextBox();
            this.txtEquipShealdHp = new System.Windows.Forms.TextBox();
            this.txtEquipShealdMana = new System.Windows.Forms.TextBox();
            this.txtEquipShealdStr = new System.Windows.Forms.TextBox();
            this.txtEquipSwordHp = new System.Windows.Forms.TextBox();
            this.txtEquipSwordMana = new System.Windows.Forms.TextBox();
            this.txtEquipSwordStr = new System.Windows.Forms.TextBox();
            this.txtEquipChestStr = new System.Windows.Forms.TextBox();
            this.txtEquipChestMana = new System.Windows.Forms.TextBox();
            this.txtEquipChestHp = new System.Windows.Forms.TextBox();
            this.txtEquipHelmMana = new System.Windows.Forms.TextBox();
            this.txtEquipHelmHp = new System.Windows.Forms.TextBox();
            this.txtEquipHelmStr = new System.Windows.Forms.TextBox();
            this.plGameBoard.SuspendLayout();
            this.txtHelmStr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // plGameBoard
            // 
            this.plGameBoard.Controls.Add(this.canvas);
            this.plGameBoard.Location = new System.Drawing.Point(428, 18);
            this.plGameBoard.Name = "plGameBoard";
            this.plGameBoard.Size = new System.Drawing.Size(643, 556);
            this.plGameBoard.TabIndex = 0;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Olive;
            this.canvas.Location = new System.Drawing.Point(3, 3);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(2000, 2000);
            this.canvas.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gray;
            this.btnLoad.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(18, 579);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(144, 67);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPlayerUp
            // 
            this.btnPlayerUp.Location = new System.Drawing.Point(834, 581);
            this.btnPlayerUp.Name = "btnPlayerUp";
            this.btnPlayerUp.Size = new System.Drawing.Size(75, 67);
            this.btnPlayerUp.TabIndex = 2;
            this.btnPlayerUp.Text = "&d";
            this.btnPlayerUp.UseVisualStyleBackColor = true;
            this.btnPlayerUp.Click += new System.EventHandler(this.btnPlayerUp_Click);
            // 
            // btnPlayerDown
            // 
            this.btnPlayerDown.Location = new System.Drawing.Point(915, 580);
            this.btnPlayerDown.Name = "btnPlayerDown";
            this.btnPlayerDown.Size = new System.Drawing.Size(75, 67);
            this.btnPlayerDown.TabIndex = 3;
            this.btnPlayerDown.Text = "&c";
            this.btnPlayerDown.UseVisualStyleBackColor = true;
            this.btnPlayerDown.Click += new System.EventHandler(this.btnPlayerDown_Click);
            // 
            // btnPlayerLeft
            // 
            this.btnPlayerLeft.Location = new System.Drawing.Point(753, 580);
            this.btnPlayerLeft.Name = "btnPlayerLeft";
            this.btnPlayerLeft.Size = new System.Drawing.Size(75, 67);
            this.btnPlayerLeft.TabIndex = 4;
            this.btnPlayerLeft.Text = "&s";
            this.btnPlayerLeft.UseVisualStyleBackColor = true;
            this.btnPlayerLeft.Click += new System.EventHandler(this.btnPlayerLeft_Click);
            // 
            // BtnPlayerRight
            // 
            this.BtnPlayerRight.Location = new System.Drawing.Point(996, 581);
            this.BtnPlayerRight.Name = "BtnPlayerRight";
            this.BtnPlayerRight.Size = new System.Drawing.Size(75, 67);
            this.BtnPlayerRight.TabIndex = 5;
            this.BtnPlayerRight.Text = "&f";
            this.BtnPlayerRight.UseVisualStyleBackColor = true;
            this.BtnPlayerRight.Click += new System.EventHandler(this.BtnPlayerRight_Click);
            // 
            // txtMaxHp
            // 
            this.txtMaxHp.BackColor = System.Drawing.Color.Gray;
            this.txtMaxHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxHp.Location = new System.Drawing.Point(343, 316);
            this.txtMaxHp.Name = "txtMaxHp";
            this.txtMaxHp.ReadOnly = true;
            this.txtMaxHp.Size = new System.Drawing.Size(42, 31);
            this.txtMaxHp.TabIndex = 2;
            // 
            // txtMaxMana
            // 
            this.txtMaxMana.BackColor = System.Drawing.Color.Gray;
            this.txtMaxMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxMana.Location = new System.Drawing.Point(343, 353);
            this.txtMaxMana.Name = "txtMaxMana";
            this.txtMaxMana.ReadOnly = true;
            this.txtMaxMana.Size = new System.Drawing.Size(42, 31);
            this.txtMaxMana.TabIndex = 6;
            // 
            // txtCurrentMana
            // 
            this.txtCurrentMana.BackColor = System.Drawing.Color.Gray;
            this.txtCurrentMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentMana.Location = new System.Drawing.Point(297, 353);
            this.txtCurrentMana.Name = "txtCurrentMana";
            this.txtCurrentMana.ReadOnly = true;
            this.txtCurrentMana.Size = new System.Drawing.Size(40, 31);
            this.txtCurrentMana.TabIndex = 7;
            // 
            // txtCurrentHp
            // 
            this.txtCurrentHp.BackColor = System.Drawing.Color.Gray;
            this.txtCurrentHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHp.Location = new System.Drawing.Point(297, 316);
            this.txtCurrentHp.Name = "txtCurrentHp";
            this.txtCurrentHp.ReadOnly = true;
            this.txtCurrentHp.Size = new System.Drawing.Size(40, 31);
            this.txtCurrentHp.TabIndex = 8;
            // 
            // txtLootName
            // 
            this.txtLootName.BackColor = System.Drawing.Color.Gray;
            this.txtLootName.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLootName.Location = new System.Drawing.Point(97, 221);
            this.txtLootName.Name = "txtLootName";
            this.txtLootName.ReadOnly = true;
            this.txtLootName.Size = new System.Drawing.Size(147, 31);
            this.txtLootName.TabIndex = 12;
            // 
            // txtLootHp
            // 
            this.txtLootHp.BackColor = System.Drawing.Color.Gray;
            this.txtLootHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLootHp.Location = new System.Drawing.Point(250, 221);
            this.txtLootHp.Name = "txtLootHp";
            this.txtLootHp.ReadOnly = true;
            this.txtLootHp.Size = new System.Drawing.Size(41, 31);
            this.txtLootHp.TabIndex = 11;
            // 
            // txtLootMana
            // 
            this.txtLootMana.BackColor = System.Drawing.Color.Gray;
            this.txtLootMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLootMana.Location = new System.Drawing.Point(297, 221);
            this.txtLootMana.Name = "txtLootMana";
            this.txtLootMana.ReadOnly = true;
            this.txtLootMana.Size = new System.Drawing.Size(40, 31);
            this.txtLootMana.TabIndex = 10;
            // 
            // txtLootStr
            // 
            this.txtLootStr.BackColor = System.Drawing.Color.Gray;
            this.txtLootStr.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLootStr.Location = new System.Drawing.Point(343, 221);
            this.txtLootStr.Name = "txtLootStr";
            this.txtLootStr.ReadOnly = true;
            this.txtLootStr.Size = new System.Drawing.Size(42, 31);
            this.txtLootStr.TabIndex = 9;
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Silver;
            this.btnAttack.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(615, 579);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 67);
            this.btnAttack.TabIndex = 10;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.BackColor = System.Drawing.Color.Silver;
            this.btnHeal.Font = new System.Drawing.Font("Rockwell", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.Location = new System.Drawing.Point(534, 580);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(75, 67);
            this.btnHeal.TabIndex = 11;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = false;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnLoot
            // 
            this.btnLoot.BackColor = System.Drawing.Color.Silver;
            this.btnLoot.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoot.Location = new System.Drawing.Point(453, 579);
            this.btnLoot.Name = "btnLoot";
            this.btnLoot.Size = new System.Drawing.Size(75, 67);
            this.btnLoot.TabIndex = 12;
            this.btnLoot.Text = "Loot Item";
            this.btnLoot.UseVisualStyleBackColor = false;
            this.btnLoot.Click += new System.EventHandler(this.btnLoot_Click);
            // 
            // btnEquip
            // 
            this.btnEquip.BackColor = System.Drawing.Color.Silver;
            this.btnEquip.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquip.Location = new System.Drawing.Point(365, 579);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(82, 67);
            this.btnEquip.TabIndex = 13;
            this.btnEquip.Text = "Equip Item";
            this.btnEquip.UseVisualStyleBackColor = false;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnInvintory
            // 
            this.btnInvintory.BackColor = System.Drawing.Color.DimGray;
            this.btnInvintory.Font = new System.Drawing.Font("Rockwell Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvintory.Location = new System.Drawing.Point(168, 579);
            this.btnInvintory.Name = "btnInvintory";
            this.btnInvintory.Size = new System.Drawing.Size(113, 67);
            this.btnInvintory.TabIndex = 14;
            this.btnInvintory.Text = "Save Game";
            this.btnInvintory.UseVisualStyleBackColor = false;
            this.btnInvintory.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // txtHelmStr
            // 
            this.txtHelmStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHelmStr.Controls.Add(this.textBox2);
            this.txtHelmStr.Controls.Add(this.textBox1);
            this.txtHelmStr.Controls.Add(this.txtLabelLoot);
            this.txtHelmStr.Controls.Add(this.pictureBox5);
            this.txtHelmStr.Controls.Add(this.pictureBox4);
            this.txtHelmStr.Controls.Add(this.pictureBox3);
            this.txtHelmStr.Controls.Add(this.pictureBox2);
            this.txtHelmStr.Controls.Add(this.pictureBox1);
            this.txtHelmStr.Controls.Add(this.txtLabelRing);
            this.txtHelmStr.Controls.Add(this.txtLabelSheald);
            this.txtHelmStr.Controls.Add(this.txtLabelSword);
            this.txtHelmStr.Controls.Add(this.txtLabel2);
            this.txtHelmStr.Controls.Add(this.txtLabel1);
            this.txtHelmStr.Controls.Add(this.txtEquipRingHp);
            this.txtHelmStr.Controls.Add(this.txtEquipRingMana);
            this.txtHelmStr.Controls.Add(this.txtEquipRingStr);
            this.txtHelmStr.Controls.Add(this.txtEquipShealdHp);
            this.txtHelmStr.Controls.Add(this.txtEquipShealdMana);
            this.txtHelmStr.Controls.Add(this.txtEquipShealdStr);
            this.txtHelmStr.Controls.Add(this.txtEquipSwordHp);
            this.txtHelmStr.Controls.Add(this.txtEquipSwordMana);
            this.txtHelmStr.Controls.Add(this.txtEquipSwordStr);
            this.txtHelmStr.Controls.Add(this.txtEquipChestStr);
            this.txtHelmStr.Controls.Add(this.txtEquipChestMana);
            this.txtHelmStr.Controls.Add(this.txtEquipChestHp);
            this.txtHelmStr.Controls.Add(this.txtLootName);
            this.txtHelmStr.Controls.Add(this.txtEquipHelmMana);
            this.txtHelmStr.Controls.Add(this.txtLootHp);
            this.txtHelmStr.Controls.Add(this.txtLootMana);
            this.txtHelmStr.Controls.Add(this.txtEquipHelmHp);
            this.txtHelmStr.Controls.Add(this.txtLootStr);
            this.txtHelmStr.Controls.Add(this.txtEquipHelmStr);
            this.txtHelmStr.Controls.Add(this.txtMaxMana);
            this.txtHelmStr.Controls.Add(this.txtCurrentMana);
            this.txtHelmStr.Controls.Add(this.txtCurrentHp);
            this.txtHelmStr.Controls.Add(this.txtMaxHp);
            this.txtHelmStr.Location = new System.Drawing.Point(18, 21);
            this.txtHelmStr.Name = "txtHelmStr";
            this.txtHelmStr.Size = new System.Drawing.Size(404, 541);
            this.txtHelmStr.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(22, 353);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(268, 31);
            this.textBox2.TabIndex = 37;
            this.textBox2.Text = "Current mana Points";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(268, 31);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "Current Hit Points";
            // 
            // txtLabelLoot
            // 
            this.txtLabelLoot.BackColor = System.Drawing.Color.DimGray;
            this.txtLabelLoot.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelLoot.Location = new System.Drawing.Point(7, 221);
            this.txtLabelLoot.Name = "txtLabelLoot";
            this.txtLabelLoot.ReadOnly = true;
            this.txtLabelLoot.Size = new System.Drawing.Size(84, 31);
            this.txtLabelLoot.TabIndex = 35;
            this.txtLabelLoot.Text = "Loot";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = global::RPGGame.Properties.Resources.ring;
            this.pictureBox5.Location = new System.Drawing.Point(60, 151);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 31);
            this.pictureBox5.TabIndex = 34;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::RPGGame.Properties.Resources.sheald;
            this.pictureBox4.Location = new System.Drawing.Point(60, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 31);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::RPGGame.Properties.Resources.helm;
            this.pictureBox3.Location = new System.Drawing.Point(60, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::RPGGame.Properties.Resources.chestplate;
            this.pictureBox2.Location = new System.Drawing.Point(60, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::RPGGame.Properties.Resources.sword1;
            this.pictureBox1.Location = new System.Drawing.Point(60, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txtLabelRing
            // 
            this.txtLabelRing.BackColor = System.Drawing.Color.DimGray;
            this.txtLabelRing.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelRing.Location = new System.Drawing.Point(97, 151);
            this.txtLabelRing.Name = "txtLabelRing";
            this.txtLabelRing.ReadOnly = true;
            this.txtLabelRing.Size = new System.Drawing.Size(147, 31);
            this.txtLabelRing.TabIndex = 29;
            this.txtLabelRing.Text = "Ring";
            // 
            // txtLabelSheald
            // 
            this.txtLabelSheald.BackColor = System.Drawing.Color.DimGray;
            this.txtLabelSheald.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelSheald.Location = new System.Drawing.Point(97, 114);
            this.txtLabelSheald.Name = "txtLabelSheald";
            this.txtLabelSheald.ReadOnly = true;
            this.txtLabelSheald.Size = new System.Drawing.Size(147, 31);
            this.txtLabelSheald.TabIndex = 28;
            this.txtLabelSheald.Text = "Sheald";
            // 
            // txtLabelSword
            // 
            this.txtLabelSword.BackColor = System.Drawing.Color.DimGray;
            this.txtLabelSword.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelSword.Location = new System.Drawing.Point(97, 77);
            this.txtLabelSword.Name = "txtLabelSword";
            this.txtLabelSword.ReadOnly = true;
            this.txtLabelSword.Size = new System.Drawing.Size(147, 31);
            this.txtLabelSword.TabIndex = 27;
            this.txtLabelSword.Text = "Sword";
            // 
            // txtLabel2
            // 
            this.txtLabel2.BackColor = System.Drawing.Color.DimGray;
            this.txtLabel2.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel2.Location = new System.Drawing.Point(97, 40);
            this.txtLabel2.Name = "txtLabel2";
            this.txtLabel2.ReadOnly = true;
            this.txtLabel2.Size = new System.Drawing.Size(147, 31);
            this.txtLabel2.TabIndex = 26;
            this.txtLabel2.Text = "Chest Plate";
            // 
            // txtLabel1
            // 
            this.txtLabel1.BackColor = System.Drawing.Color.DimGray;
            this.txtLabel1.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabel1.Location = new System.Drawing.Point(97, 3);
            this.txtLabel1.Name = "txtLabel1";
            this.txtLabel1.ReadOnly = true;
            this.txtLabel1.Size = new System.Drawing.Size(147, 31);
            this.txtLabel1.TabIndex = 25;
            this.txtLabel1.Text = "Helm";
            // 
            // txtEquipRingHp
            // 
            this.txtEquipRingHp.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipRingHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipRingHp.Location = new System.Drawing.Point(251, 151);
            this.txtEquipRingHp.Name = "txtEquipRingHp";
            this.txtEquipRingHp.ReadOnly = true;
            this.txtEquipRingHp.Size = new System.Drawing.Size(40, 31);
            this.txtEquipRingHp.TabIndex = 24;
            this.txtEquipRingHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipRingMana
            // 
            this.txtEquipRingMana.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipRingMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipRingMana.Location = new System.Drawing.Point(297, 151);
            this.txtEquipRingMana.Name = "txtEquipRingMana";
            this.txtEquipRingMana.ReadOnly = true;
            this.txtEquipRingMana.Size = new System.Drawing.Size(40, 31);
            this.txtEquipRingMana.TabIndex = 23;
            this.txtEquipRingMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipRingStr
            // 
            this.txtEquipRingStr.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipRingStr.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipRingStr.Location = new System.Drawing.Point(345, 151);
            this.txtEquipRingStr.Name = "txtEquipRingStr";
            this.txtEquipRingStr.ReadOnly = true;
            this.txtEquipRingStr.Size = new System.Drawing.Size(40, 31);
            this.txtEquipRingStr.TabIndex = 22;
            this.txtEquipRingStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipShealdHp
            // 
            this.txtEquipShealdHp.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipShealdHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipShealdHp.Location = new System.Drawing.Point(251, 114);
            this.txtEquipShealdHp.Name = "txtEquipShealdHp";
            this.txtEquipShealdHp.ReadOnly = true;
            this.txtEquipShealdHp.Size = new System.Drawing.Size(40, 31);
            this.txtEquipShealdHp.TabIndex = 21;
            this.txtEquipShealdHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipShealdMana
            // 
            this.txtEquipShealdMana.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipShealdMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipShealdMana.Location = new System.Drawing.Point(297, 114);
            this.txtEquipShealdMana.Name = "txtEquipShealdMana";
            this.txtEquipShealdMana.ReadOnly = true;
            this.txtEquipShealdMana.Size = new System.Drawing.Size(40, 31);
            this.txtEquipShealdMana.TabIndex = 20;
            this.txtEquipShealdMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipShealdStr
            // 
            this.txtEquipShealdStr.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipShealdStr.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipShealdStr.Location = new System.Drawing.Point(345, 114);
            this.txtEquipShealdStr.Name = "txtEquipShealdStr";
            this.txtEquipShealdStr.ReadOnly = true;
            this.txtEquipShealdStr.Size = new System.Drawing.Size(40, 31);
            this.txtEquipShealdStr.TabIndex = 19;
            this.txtEquipShealdStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipSwordHp
            // 
            this.txtEquipSwordHp.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipSwordHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipSwordHp.Location = new System.Drawing.Point(251, 77);
            this.txtEquipSwordHp.Name = "txtEquipSwordHp";
            this.txtEquipSwordHp.ReadOnly = true;
            this.txtEquipSwordHp.Size = new System.Drawing.Size(40, 31);
            this.txtEquipSwordHp.TabIndex = 18;
            this.txtEquipSwordHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipSwordMana
            // 
            this.txtEquipSwordMana.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipSwordMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipSwordMana.Location = new System.Drawing.Point(297, 77);
            this.txtEquipSwordMana.Name = "txtEquipSwordMana";
            this.txtEquipSwordMana.ReadOnly = true;
            this.txtEquipSwordMana.Size = new System.Drawing.Size(40, 31);
            this.txtEquipSwordMana.TabIndex = 17;
            this.txtEquipSwordMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipSwordStr
            // 
            this.txtEquipSwordStr.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipSwordStr.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipSwordStr.Location = new System.Drawing.Point(345, 77);
            this.txtEquipSwordStr.Name = "txtEquipSwordStr";
            this.txtEquipSwordStr.ReadOnly = true;
            this.txtEquipSwordStr.Size = new System.Drawing.Size(40, 31);
            this.txtEquipSwordStr.TabIndex = 16;
            this.txtEquipSwordStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipChestStr
            // 
            this.txtEquipChestStr.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipChestStr.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipChestStr.Location = new System.Drawing.Point(251, 40);
            this.txtEquipChestStr.Name = "txtEquipChestStr";
            this.txtEquipChestStr.ReadOnly = true;
            this.txtEquipChestStr.Size = new System.Drawing.Size(40, 31);
            this.txtEquipChestStr.TabIndex = 15;
            this.txtEquipChestStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipChestMana
            // 
            this.txtEquipChestMana.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipChestMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipChestMana.Location = new System.Drawing.Point(297, 40);
            this.txtEquipChestMana.Name = "txtEquipChestMana";
            this.txtEquipChestMana.ReadOnly = true;
            this.txtEquipChestMana.Size = new System.Drawing.Size(40, 31);
            this.txtEquipChestMana.TabIndex = 14;
            this.txtEquipChestMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipChestHp
            // 
            this.txtEquipChestHp.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipChestHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipChestHp.Location = new System.Drawing.Point(345, 40);
            this.txtEquipChestHp.Name = "txtEquipChestHp";
            this.txtEquipChestHp.ReadOnly = true;
            this.txtEquipChestHp.Size = new System.Drawing.Size(40, 31);
            this.txtEquipChestHp.TabIndex = 13;
            this.txtEquipChestHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipHelmMana
            // 
            this.txtEquipHelmMana.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipHelmMana.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipHelmMana.Location = new System.Drawing.Point(297, 3);
            this.txtEquipHelmMana.Name = "txtEquipHelmMana";
            this.txtEquipHelmMana.ReadOnly = true;
            this.txtEquipHelmMana.Size = new System.Drawing.Size(40, 31);
            this.txtEquipHelmMana.TabIndex = 11;
            this.txtEquipHelmMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipHelmHp
            // 
            this.txtEquipHelmHp.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipHelmHp.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipHelmHp.Location = new System.Drawing.Point(250, 3);
            this.txtEquipHelmHp.Name = "txtEquipHelmHp";
            this.txtEquipHelmHp.ReadOnly = true;
            this.txtEquipHelmHp.Size = new System.Drawing.Size(40, 31);
            this.txtEquipHelmHp.TabIndex = 10;
            this.txtEquipHelmHp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEquipHelmStr
            // 
            this.txtEquipHelmStr.BackColor = System.Drawing.Color.DimGray;
            this.txtEquipHelmStr.Font = new System.Drawing.Font("Rockwell Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipHelmStr.Location = new System.Drawing.Point(345, 3);
            this.txtEquipHelmStr.Name = "txtEquipHelmStr";
            this.txtEquipHelmStr.ReadOnly = true;
            this.txtEquipHelmStr.Size = new System.Drawing.Size(40, 31);
            this.txtEquipHelmStr.TabIndex = 9;
            this.txtEquipHelmStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1098, 669);
            this.Controls.Add(this.plGameBoard);
            this.Controls.Add(this.txtHelmStr);
            this.Controls.Add(this.btnInvintory);
            this.Controls.Add(this.btnEquip);
            this.Controls.Add(this.btnLoot);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.BtnPlayerRight);
            this.Controls.Add(this.btnPlayerLeft);
            this.Controls.Add(this.btnPlayerDown);
            this.Controls.Add(this.btnPlayerUp);
            this.Name = "Form1";
            this.Text = "An RPG Game Made by Nate";
            this.plGameBoard.ResumeLayout(false);
            this.txtHelmStr.ResumeLayout(false);
            this.txtHelmStr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plGameBoard;
        private System.Windows.Forms.Panel canvas;
        
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPlayerUp;
        private System.Windows.Forms.Button btnPlayerDown;
        private System.Windows.Forms.Button btnPlayerLeft;
        private System.Windows.Forms.Button BtnPlayerRight;     
        private System.Windows.Forms.TextBox txtMaxHp;
        private System.Windows.Forms.TextBox txtMaxMana;
        private System.Windows.Forms.TextBox txtCurrentMana;
        private System.Windows.Forms.TextBox txtCurrentHp;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnLoot;
        private System.Windows.Forms.TextBox txtLootName;
        private System.Windows.Forms.TextBox txtLootHp;
        private System.Windows.Forms.TextBox txtLootMana;
        private System.Windows.Forms.TextBox txtLootStr;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnInvintory;
        private System.Windows.Forms.Panel txtHelmStr;
        private System.Windows.Forms.TextBox txtEquipHelmMana;
        private System.Windows.Forms.TextBox txtEquipHelmHp;
        private System.Windows.Forms.TextBox txtEquipHelmStr;
        private System.Windows.Forms.TextBox txtEquipChestStr;
        private System.Windows.Forms.TextBox txtEquipChestMana;
        private System.Windows.Forms.TextBox txtEquipChestHp;
        private System.Windows.Forms.TextBox txtEquipSwordHp;
        private System.Windows.Forms.TextBox txtEquipSwordMana;
        private System.Windows.Forms.TextBox txtEquipSwordStr;
        private System.Windows.Forms.TextBox txtEquipShealdHp;
        private System.Windows.Forms.TextBox txtEquipShealdMana;
        private System.Windows.Forms.TextBox txtEquipShealdStr;
        private System.Windows.Forms.TextBox txtEquipRingHp;
        private System.Windows.Forms.TextBox txtEquipRingMana;
        private System.Windows.Forms.TextBox txtEquipRingStr;
        private System.Windows.Forms.TextBox txtLabelRing;
        private System.Windows.Forms.TextBox txtLabelSheald;
        private System.Windows.Forms.TextBox txtLabelSword;
        private System.Windows.Forms.TextBox txtLabel2;
        private System.Windows.Forms.TextBox txtLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtLabelLoot;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

