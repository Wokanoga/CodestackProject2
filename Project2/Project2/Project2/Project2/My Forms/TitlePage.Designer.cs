namespace Project2.My_Forms
{
    partial class TitlePage
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
            this.pic_Waluigi = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new MetroFramework.Controls.MetroTile();
            this.btn_Start = new MetroFramework.Controls.MetroTile();
            this.btn_Music = new MetroFramework.Controls.MetroTile();
            this.btn_AboutUs = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Waluigi)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Waluigi
            // 
            this.pic_Waluigi.Location = new System.Drawing.Point(223, 112);
            this.pic_Waluigi.Name = "pic_Waluigi";
            this.pic_Waluigi.Size = new System.Drawing.Size(811, 763);
            this.pic_Waluigi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Waluigi.TabIndex = 0;
            this.pic_Waluigi.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ActiveControl = null;
            this.btn_Exit.Location = new System.Drawing.Point(851, 753);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(215, 134);
            this.btn_Exit.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Exit.UseSelectable = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.ActiveControl = null;
            this.btn_Start.Location = new System.Drawing.Point(188, 753);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(215, 134);
            this.btn_Start.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Start";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Start.UseSelectable = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // btn_Music
            // 
            this.btn_Music.ActiveControl = null;
            this.btn_Music.Location = new System.Drawing.Point(630, 753);
            this.btn_Music.Name = "btn_Music";
            this.btn_Music.Size = new System.Drawing.Size(215, 134);
            this.btn_Music.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_Music.TabIndex = 3;
            this.btn_Music.Text = "Toggle Music";
            this.btn_Music.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Music.UseSelectable = true;
            this.btn_Music.Click += new System.EventHandler(this.Btn_Music_Click);
            // 
            // btn_AboutUs
            // 
            this.btn_AboutUs.ActiveControl = null;
            this.btn_AboutUs.Location = new System.Drawing.Point(409, 753);
            this.btn_AboutUs.Name = "btn_AboutUs";
            this.btn_AboutUs.Size = new System.Drawing.Size(215, 134);
            this.btn_AboutUs.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_AboutUs.TabIndex = 4;
            this.btn_AboutUs.Text = "About Us";
            this.btn_AboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AboutUs.UseSelectable = true;
            this.btn_AboutUs.Click += new System.EventHandler(this.btn_AboutUs_Click);
            // 
            // TitlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 910);
            this.Controls.Add(this.btn_AboutUs);
            this.Controls.Add(this.btn_Music);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pic_Waluigi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "TitlePage";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Waluigi\'s Revenge";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TitlePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Waluigi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Waluigi;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTile btn_Exit;
        private MetroFramework.Controls.MetroTile btn_Start;
        private MetroFramework.Controls.MetroTile btn_Music;
        private MetroFramework.Controls.MetroTile btn_AboutUs;
    }
}