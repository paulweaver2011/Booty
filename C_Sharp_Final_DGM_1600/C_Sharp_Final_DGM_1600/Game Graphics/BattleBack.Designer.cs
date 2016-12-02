namespace C_Sharp_Final_DGM_1600
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuExitDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuContinueGameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSettingsDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSoundsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PBoxBackground = new System.Windows.Forms.PictureBox();
            this.BtnAttack = new System.Windows.Forms.Button();
            this.BtnDefend = new System.Windows.Forms.Button();
            this.BtnMagic = new System.Windows.Forms.Button();
            this.BtnItem = new System.Windows.Forms.Button();
            this.BtnFlailAbout = new System.Windows.Forms.Button();
            this.PBoxMonster1 = new System.Windows.Forms.PictureBox();
            this.PBoxMonster3 = new System.Windows.Forms.PictureBox();
            this.PBoxMonster2 = new System.Windows.Forms.PictureBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            this.MnuSoundsButton.Name = "MnuSoundsButton";
            this.MnuSoundsButton.Size = new System.Drawing.Size(108, 22);
            this.MnuSoundsButton.Text = "Sound";
            // 
            // PBoxBackground
            // 
            this.PBoxBackground.Image = ((System.Drawing.Image)(resources.GetObject("PBoxBackground.Image")));
            this.PBoxBackground.Location = new System.Drawing.Point(12, 27);
            this.PBoxBackground.Name = "PBoxBackground";
            this.PBoxBackground.Size = new System.Drawing.Size(1159, 478);
            this.PBoxBackground.TabIndex = 1;
            this.PBoxBackground.TabStop = false;
            // 
            // BtnAttack
            // 
            this.BtnAttack.Font = new System.Drawing.Font("Outrun future", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttack.Location = new System.Drawing.Point(12, 511);
            this.BtnAttack.Name = "BtnAttack";
            this.BtnAttack.Size = new System.Drawing.Size(227, 111);
            this.BtnAttack.TabIndex = 2;
            this.BtnAttack.Text = "Attack";
            this.BtnAttack.UseVisualStyleBackColor = true;
            // 
            // BtnDefend
            // 
            this.BtnDefend.Font = new System.Drawing.Font("Outrun future", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDefend.Location = new System.Drawing.Point(245, 511);
            this.BtnDefend.Name = "BtnDefend";
            this.BtnDefend.Size = new System.Drawing.Size(227, 111);
            this.BtnDefend.TabIndex = 4;
            this.BtnDefend.Text = "Defend";
            this.BtnDefend.UseVisualStyleBackColor = true;
            // 
            // BtnMagic
            // 
            this.BtnMagic.Font = new System.Drawing.Font("Outrun future", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMagic.Location = new System.Drawing.Point(478, 511);
            this.BtnMagic.Name = "BtnMagic";
            this.BtnMagic.Size = new System.Drawing.Size(227, 111);
            this.BtnMagic.TabIndex = 5;
            this.BtnMagic.Text = "Magic";
            this.BtnMagic.UseVisualStyleBackColor = true;
            // 
            // BtnItem
            // 
            this.BtnItem.Font = new System.Drawing.Font("Outrun future", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnItem.Location = new System.Drawing.Point(711, 511);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(227, 111);
            this.BtnItem.TabIndex = 6;
            this.BtnItem.Text = "Item";
            this.BtnItem.UseVisualStyleBackColor = true;
            // 
            // BtnFlailAbout
            // 
            this.BtnFlailAbout.Font = new System.Drawing.Font("Outrun future", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFlailAbout.Location = new System.Drawing.Point(944, 511);
            this.BtnFlailAbout.Name = "BtnFlailAbout";
            this.BtnFlailAbout.Size = new System.Drawing.Size(227, 111);
            this.BtnFlailAbout.TabIndex = 7;
            this.BtnFlailAbout.Text = "Flail About";
            this.BtnFlailAbout.UseVisualStyleBackColor = true;
            // 
            // PBoxMonster1
            // 
            this.PBoxMonster1.BackColor = System.Drawing.Color.Transparent;
            this.PBoxMonster1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBoxMonster1.BackgroundImage")));
            this.PBoxMonster1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxMonster1.Location = new System.Drawing.Point(478, 55);
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
            this.PBoxMonster3.Location = new System.Drawing.Point(711, 84);
            this.PBoxMonster3.Name = "PBoxMonster3";
            this.PBoxMonster3.Size = new System.Drawing.Size(227, 334);
            this.PBoxMonster3.TabIndex = 9;
            this.PBoxMonster3.TabStop = false;
            // 
            // PBoxMonster2
            // 
            this.PBoxMonster2.BackColor = System.Drawing.Color.Transparent;
            this.PBoxMonster2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBoxMonster2.BackgroundImage")));
            this.PBoxMonster2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBoxMonster2.Location = new System.Drawing.Point(245, 84);
            this.PBoxMonster2.Name = "PBoxMonster2";
            this.PBoxMonster2.Size = new System.Drawing.Size(227, 334);
            this.PBoxMonster2.TabIndex = 10;
            this.PBoxMonster2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 628);
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
            this.Name = "Form1";
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
    }
}

