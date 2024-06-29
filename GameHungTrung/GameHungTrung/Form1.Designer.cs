namespace GameHungTrung
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
            this.components = new System.ComponentModel.Container();
            this.Diem = new System.Windows.Forms.Label();
            this.Rot = new System.Windows.Forms.Label();
            this.nguoichoi = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nguoichoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Diem
            // 
            this.Diem.AutoSize = true;
            this.Diem.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diem.Location = new System.Drawing.Point(46, 27);
            this.Diem.Name = "Diem";
            this.Diem.Size = new System.Drawing.Size(47, 24);
            this.Diem.TabIndex = 3;
            this.Diem.Tag = "txtScore";
            this.Diem.Text = "Điểm";
            // 
            // Rot
            // 
            this.Rot.AutoSize = true;
            this.Rot.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rot.Location = new System.Drawing.Point(502, 27);
            this.Rot.Name = "Rot";
            this.Rot.Size = new System.Drawing.Size(43, 24);
            this.Rot.TabIndex = 4;
            this.Rot.Tag = "txtMiss";
            this.Rot.Text = "Rớt : ";
            // 
            // nguoichoi
            // 
            this.nguoichoi.Image = global::GameHungTrung.Properties.Resources.chicken_normal;
            this.nguoichoi.Location = new System.Drawing.Point(268, 586);
            this.nguoichoi.Name = "nguoichoi";
            this.nguoichoi.Size = new System.Drawing.Size(80, 85);
            this.nguoichoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nguoichoi.TabIndex = 5;
            this.nguoichoi.TabStop = false;
            this.nguoichoi.Tag = "Player";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GameHungTrung.Properties.Resources.egg;
            this.pictureBox3.Location = new System.Drawing.Point(506, 111);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "eggs";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GameHungTrung.Properties.Resources.egg;
            this.pictureBox2.Location = new System.Drawing.Point(287, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "eggs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GameHungTrung.Properties.Resources.egg;
            this.pictureBox1.Location = new System.Drawing.Point(49, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "eggs";
            // 
            // Gametimer
            // 
            this.Gametimer.Enabled = true;
            this.Gametimer.Interval = 20;
            this.Gametimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(622, 683);
            this.Controls.Add(this.nguoichoi);
            this.Controls.Add(this.Rot);
            this.Controls.Add(this.Diem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Hứng Trứng Nào !!!";
            this.Load += new System.EventHandler(this.MainGameTimerEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.nguoichoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Diem;
        private System.Windows.Forms.Label Rot;
        private System.Windows.Forms.PictureBox nguoichoi;
        private System.Windows.Forms.Timer Gametimer;
    }
}

