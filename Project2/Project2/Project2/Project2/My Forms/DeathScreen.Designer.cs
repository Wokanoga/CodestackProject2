namespace Project2.My_Forms
{
    partial class DeathScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathScreen));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.pic_Death = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Death)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.Location = new System.Drawing.Point(242, 521);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(295, 86);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Restart.Location = new System.Drawing.Point(812, 521);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(295, 86);
            this.btn_Restart.TabIndex = 1;
            this.btn_Restart.Text = "Start Over";
            this.btn_Restart.UseVisualStyleBackColor = false;
            // 
            // pic_Death
            // 
            this.pic_Death.Image = ((System.Drawing.Image)(resources.GetObject("pic_Death.Image")));
            this.pic_Death.Location = new System.Drawing.Point(242, 12);
            this.pic_Death.Name = "pic_Death";
            this.pic_Death.Size = new System.Drawing.Size(865, 352);
            this.pic_Death.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Death.TabIndex = 2;
            this.pic_Death.TabStop = false;
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1240, 910);
            this.Controls.Add(this.pic_Death);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeathScreen";
            this.Load += new System.EventHandler(this.DeathScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Death)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.PictureBox pic_Death;
    }
}