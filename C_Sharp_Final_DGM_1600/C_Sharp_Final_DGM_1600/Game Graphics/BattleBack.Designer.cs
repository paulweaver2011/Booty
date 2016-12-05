namespace C_Sharp_Final_DGM_1600
{
    partial class C_Sharp_Final
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_Sharp_Final));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuExitDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuContinueGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSettingsDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSoundsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSoundOn = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSoundOff = new System.Windows.Forms.ToolStripMenuItem();
            this.PBoxBackground = new System.Windows.Forms.PictureBox();
            this.BtnAttack = new System.Windows.Forms.Button();
            this.BtnDefend = new System.Windows.Forms.Button();
            this.BtnMagic = new System.Windows.Forms.Button();
            this.BtnItem = new System.Windows.Forms.Button();
            this.BtnFlailAbout = new System.Windows.Forms.Button();
            this.PBoxMonster1 = new System.Windows.Forms.PictureBox();
            this.PBoxMonster3 = new System.Windows.Forms.PictureBox();
            this.PBoxMonster2 = new System.Windows.Forms.PictureBox();
            this.TxtBoxMain = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMonster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMonster3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMonster2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuExitDropDown,
            this.MnuFileDropDown,
            this.MnuSettingsDropDown});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuExitDropDown
            // 
            this.MnuExitDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAboutButton,
            this.MnuExitButton});
            this.MnuExitDropDown.Name = "MnuExitDropDown";
            this.MnuExitDropDown.Size = new System.Drawing.Size(37, 20);
            this.MnuExitDropDown.Text = "Exit";
            // 
            // MnuAboutButton
            // 
            this.MnuAboutButton.Name = "MnuAboutButton";
            this.MnuAboutButton.Size = new System.Drawing.Size(107, 22);
            this.MnuAboutButton.Text = "About";
            this.MnuAboutButton.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MnuExitButton
            // 
            this.MnuExitButton.Name = "MnuExitButton";
            this.MnuExitButton.Size = new System.Drawing.Size(107, 22);
            this.MnuExitButton.Text = "Exit";
            this.MnuExitButton.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // MnuFileDropDown
            // 
            this.MnuFileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNewGameButton,
            this.MnuContinueGameButton});
            this.MnuFileDropDown.Name = "MnuFileDropDown";
            this.MnuFileDropDown.Size = new System.Drawing.Size(37, 20);
            this.MnuFileDropDown.Text = "File";
            // 
            // MnuNewGameButton
            // 
            this.MnuNewGameButton.Name = "MnuNewGameButton";
            this.MnuNewGameButton.Size = new System.Drawing.Size(157, 22);
            this.MnuNewGameButton.Text = "New Game";
            this.MnuNewGameButton.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // MnuContinueGameButton
            // 
            this.MnuContinueGameButton.Name = "MnuContinueGameButton";
            this.MnuContinueGameButton.Size = new System.Drawing.Size(157, 22);
            this.MnuContinueGameButton.Text = "Continue Game";
            // 
            // MnuSettingsDropDown
            // 
            this.MnuSettingsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSoundsButton});
            this.MnuSettingsDropDown.Name = "MnuSettingsDropDown";
            this.MnuSettingsDropDown.Size = new System.Drawing.Size(61, 20);
            this.MnuSettingsDropDown.Text = "Settings";
            // 
            // MnuSoundsButton
            // 
            this.MnuSoundsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSoundOn,
            this.BtnSoundOff});
            this.MnuSoundsButton.Name = "MnuSoundsButton";
            this.MnuSoundsButton.Size = new System.Drawing.Size(152, 22);
            this.MnuSoundsButton.Text = "Sound";
            this.MnuSoundsButton.Click += new System.EventHandler(this.MnuSoundsButton_Click);
            // 
            // BtnSoundOn
            // 
            this.BtnSoundOn.Name = "BtnSoundOn";
            this.BtnSoundOn.Size = new System.Drawing.Size(91, 22);
            this.BtnSoundOn.Text = "On";
            this.BtnSoundOn.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // BtnSoundOff
            // 
            this.BtnSoundOff.Name = "BtnSoundOff";
            this.BtnSoundOff.Size = new System.Drawing.Size(152, 22);
            this.BtnSoundOff.Text = "Off";
            this.BtnSoundOff.Click += new System.EventHandler(this.BtnSoundOff_Click);
            // 
            // PBoxBackground
            // 
            this.PBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("PBoxBackground.Image")));
            this.PBoxBackground.Location = new System.Drawing.Point(12, 27);
            this.PBoxBackground.Name = "PBoxBackground";
            this.PBoxBackground.Size = new System.Drawing.Size(1160, 391);
            this.PBoxBackground.TabIndex = 1;
            this.PBoxBackground.TabStop = false;
            // 
            // BtnAttack
            // 
            this.BtnAttack.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttack.Location = new System.Drawing.Point(12, 523);
            this.BtnAttack.Name = "BtnAttack";
            this.BtnAttack.Size = new System.Drawing.Size(227, 111);
            this.BtnAttack.TabIndex = 2;
            this.BtnAttack.Text = "Attack";
            this.BtnAttack.UseVisualStyleBackColor = true;
            this.BtnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // BtnDefend
            // 
            this.BtnDefend.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefend.Location = new System.Drawing.Point(245, 523);
            this.BtnDefend.Name = "BtnDefend";
            this.BtnDefend.Size = new System.Drawing.Size(227, 111);
            this.BtnDefend.TabIndex = 4;
            this.BtnDefend.Text = "Defend";
            this.BtnDefend.UseVisualStyleBackColor = true;
            // 
            // BtnMagic
            // 
            this.BtnMagic.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMagic.Location = new System.Drawing.Point(478, 523);
            this.BtnMagic.Name = "BtnMagic";
            this.BtnMagic.Size = new System.Drawing.Size(227, 111);
            this.BtnMagic.TabIndex = 5;
            this.BtnMagic.Text = "Magic";
            this.BtnMagic.UseVisualStyleBackColor = true;
            // 
            // BtnItem
            // 
            this.BtnItem.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItem.Location = new System.Drawing.Point(711, 523);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(227, 111);
            this.BtnItem.TabIndex = 6;
            this.BtnItem.Text = "Item";
            this.BtnItem.UseVisualStyleBackColor = true;
            // 
            // BtnFlailAbout
            // 
            this.BtnFlailAbout.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFlailAbout.Location = new System.Drawing.Point(944, 523);
            this.BtnFlailAbout.Name = "BtnFlailAbout";
            this.BtnFlailAbout.Size = new System.Drawing.Size(227, 111);
            this.BtnFlailAbout.TabIndex = 7;
            this.BtnFlailAbout.Text = "Flail About";
            this.BtnFlailAbout.UseVisualStyleBackColor = true;
            this.BtnFlailAbout.Click += new System.EventHandler(this.BtnFlailAbout_Click);
            // 
            // PBoxMonster1
            // 
            this.PBoxMonster1.BackColor = System.Drawing.Color.Transparent;
            this.PBoxMonster1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBoxMonster1.BackgroundImage")));
            this.PBoxMonster1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxMonster1.Location = new System.Drawing.Point(478, 39);
            this.PBoxMonster1.Name = "PBoxMonster1";
            this.PBoxMonster1.Size = new System.Drawing.Size(227, 334);
            this.PBoxMonster1.TabIndex = 8;
            this.PBoxMonster1.TabStop = false;
            this.PBoxMonster1.Click += new System.EventHandler(this.BoxMonster1_Click);
            // 
            // PBoxMonster3
            // 
            this.PBoxMonster3.BackColor = System.Drawing.Color.Transparent;
            this.PBoxMonster3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBoxMonster3.BackgroundImage")));
            this.PBoxMonster3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxMonster3.Location = new System.Drawing.Point(711, 68);
            this.PBoxMonster3.Name = "PBoxMonster3";
            this.PBoxMonster3.Size = new System.Drawing.Size(227, 334);
            this.PBoxMonster3.TabIndex = 9;
            this.PBoxMonster3.TabStop = false;
            this.PBoxMonster3.Click += new System.EventHandler(this.PBoxMonster3_Click);
            // 
            // PBoxMonster2
            // 
            this.PBoxMonster2.BackColor = System.Drawing.Color.Transparent;
            this.PBoxMonster2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBoxMonster2.BackgroundImage")));
            this.PBoxMonster2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxMonster2.Location = new System.Drawing.Point(245, 68);
            this.PBoxMonster2.Name = "PBoxMonster2";
            this.PBoxMonster2.Size = new System.Drawing.Size(227, 334);
            this.PBoxMonster2.TabIndex = 10;
            this.PBoxMonster2.TabStop = false;
            this.PBoxMonster2.Click += new System.EventHandler(this.PBoxMonster2_Click);
            // 
            // TxtBoxMain
            // 
            this.TxtBoxMain.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxMain.Location = new System.Drawing.Point(12, 428);
            this.TxtBoxMain.Multiline = true;
            this.TxtBoxMain.Name = "TxtBoxMain";
            this.TxtBoxMain.Size = new System.Drawing.Size(1159, 82);
            this.TxtBoxMain.TabIndex = 11;
            // 
            // C_Sharp_Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 646);
            this.Controls.Add(this.TxtBoxMain);
            this.Controls.Add(this.PBoxMonster2);
            this.Controls.Add(this.PBoxMonster3);
            this.Controls.Add(this.PBoxMonster1);
            this.Controls.Add(this.BtnFlailAbout);
            this.Controls.Add(this.BtnItem);
            this.Controls.Add(this.BtnMagic);
            this.Controls.Add(this.BtnDefend);
            this.Controls.Add(this.BtnAttack);
            this.Controls.Add(this.PBoxBackground);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "C_Sharp_Final";
            this.Text = "Ars Uberia; The Uberian Chronicles or The Diaries of Dartanias Pendleton III";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMonster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMonster3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxMonster2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuExitDropDown;
        private System.Windows.Forms.ToolStripMenuItem MnuAboutButton;
        private System.Windows.Forms.ToolStripMenuItem MnuExitButton;
        private System.Windows.Forms.ToolStripMenuItem MnuFileDropDown;
        private System.Windows.Forms.ToolStripMenuItem MnuNewGameButton;
        private System.Windows.Forms.ToolStripMenuItem MnuContinueGameButton;
        private System.Windows.Forms.ToolStripMenuItem MnuSettingsDropDown;
        private System.Windows.Forms.ToolStripMenuItem MnuSoundsButton;
        private System.Windows.Forms.PictureBox PBoxBackground;
        private System.Windows.Forms.Button BtnAttack;
        private System.Windows.Forms.Button BtnDefend;
        private System.Windows.Forms.Button BtnMagic;
        private System.Windows.Forms.Button BtnItem;
        private System.Windows.Forms.Button BtnFlailAbout;
        private System.Windows.Forms.PictureBox PBoxMonster1;
        private System.Windows.Forms.PictureBox PBoxMonster3;
        private System.Windows.Forms.PictureBox PBoxMonster2;
        private System.Windows.Forms.TextBox TxtBoxMain;
        private System.Windows.Forms.ToolStripMenuItem BtnSoundOn;
        private System.Windows.Forms.ToolStripMenuItem BtnSoundOff;
    }
}

