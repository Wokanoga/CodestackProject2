namespace GameDemo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_NewGame = new MetroFramework.Controls.MetroTile();
            this.btn_LoadGame = new MetroFramework.Controls.MetroTile();
            this.btn_Exit = new MetroFramework.Controls.MetroTile();
            this.btn_About = new MetroFramework.Controls.MetroTile();
            this.lb_Title = new MetroFramework.Controls.MetroLabel();
            this.waluigi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.waluigi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.ActiveControl = null;
            this.btn_NewGame.Location = new System.Drawing.Point(151, 685);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(262, 142);
            this.btn_NewGame.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NewGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_NewGame.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_NewGame.UseCustomForeColor = true;
            this.btn_NewGame.UseSelectable = true;
            // 
            // btn_LoadGame
            // 
            this.btn_LoadGame.ActiveControl = null;
            this.btn_LoadGame.BackColor = System.Drawing.Color.Gold;
            this.btn_LoadGame.Location = new System.Drawing.Point(432, 685);
            this.btn_LoadGame.Name = "btn_LoadGame";
            this.btn_LoadGame.Size = new System.Drawing.Size(262, 142);
            this.btn_LoadGame.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_LoadGame.TabIndex = 1;
            this.btn_LoadGame.Text = "Load Game";
            this.btn_LoadGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_LoadGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_LoadGame.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_LoadGame.UseCustomForeColor = true;
            this.btn_LoadGame.UseSelectable = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.ActiveControl = null;
            this.btn_Exit.BackColor = System.Drawing.Color.Gold;
            this.btn_Exit.Location = new System.Drawing.Point(711, 685);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(262, 142);
            this.btn_Exit.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Exit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Exit.UseCustomForeColor = true;
            this.btn_Exit.UseSelectable = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_About
            // 
            this.btn_About.ActiveControl = null;
            this.btn_About.BackColor = System.Drawing.Color.Gold;
            this.btn_About.Location = new System.Drawing.Point(990, 685);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(262, 142);
            this.btn_About.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btn_About.TabIndex = 3;
            this.btn_About.Text = "About";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_About.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_About.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_About.UseCustomForeColor = true;
            this.btn_About.UseSelectable = true;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_Title.Location = new System.Drawing.Point(664, 18);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(144, 25);
            this.lb_Title.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "Waluigi\'s revenge";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Title.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // waluigi
            // 
            this.waluigi.BackColor = System.Drawing.Color.Transparent;
            this.waluigi.Image = ((System.Drawing.Image)(resources.GetObject("waluigi.Image")));
            this.waluigi.Location = new System.Drawing.Point(245, 63);
            this.waluigi.Name = "waluigi";
            this.waluigi.Size = new System.Drawing.Size(857, 825);
            this.waluigi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.waluigi.TabIndex = 6;
            this.waluigi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(563, 355);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(262, 142);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 8;
            this.metroTile2.Text = "Toggle Music";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_LoadGame);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.waluigi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 850);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 850);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waluigi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_NewGame;
        private MetroFramework.Controls.MetroTile btn_LoadGame;
        private MetroFramework.Controls.MetroTile btn_Exit;
        private MetroFramework.Controls.MetroTile btn_About;
        private MetroFramework.Controls.MetroLabel lb_Title;
        private System.Windows.Forms.PictureBox waluigi;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

