namespace GameDemo
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
            this.btn_NewGame = new MetroFramework.Controls.MetroTile();
            this.btn_LoadGame = new MetroFramework.Controls.MetroTile();
            this.btn_Exit = new MetroFramework.Controls.MetroTile();
            this.btn_About = new MetroFramework.Controls.MetroTile();
            this.lb_Title = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lb_Title.Location = new System.Drawing.Point(622, 82);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(148, 25);
            this.lb_Title.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "Aborto\'s Endeaver";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Title.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(504, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aborto\'s Endeavor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_LoadGame);
            this.Controls.Add(this.btn_NewGame);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 850);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 850);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_NewGame;
        private MetroFramework.Controls.MetroTile btn_LoadGame;
        private MetroFramework.Controls.MetroTile btn_Exit;
        private MetroFramework.Controls.MetroTile btn_About;
        private MetroFramework.Controls.MetroLabel lb_Title;
        private System.Windows.Forms.Label label1;
    }
}

