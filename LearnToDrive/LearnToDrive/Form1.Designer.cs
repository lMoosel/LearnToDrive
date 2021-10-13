
namespace LearnToDrive
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
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblSpeed = new System.Windows.Forms.Label();
            this.picBottom3 = new System.Windows.Forms.PictureBox();
            this.picTop3 = new System.Windows.Forms.PictureBox();
            this.picTop2 = new System.Windows.Forms.PictureBox();
            this.picTop1 = new System.Windows.Forms.PictureBox();
            this.picBottom2 = new System.Windows.Forms.PictureBox();
            this.picCar = new System.Windows.Forms.PictureBox();
            this.picBottom1 = new System.Windows.Forms.PictureBox();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblLastScore = new System.Windows.Forms.Label();
            this.lblLast3Average = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 17;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(12, 547);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(87, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Current Speed: 0";
            // 
            // picBottom3
            // 
            this.picBottom3.BackColor = System.Drawing.Color.Gray;
            this.picBottom3.BackgroundImage = global::LearnToDrive.Properties.Resources.Image1;
            this.picBottom3.Location = new System.Drawing.Point(398, 275);
            this.picBottom3.Name = "picBottom3";
            this.picBottom3.Size = new System.Drawing.Size(200, 25);
            this.picBottom3.TabIndex = 7;
            this.picBottom3.TabStop = false;
            // 
            // picTop3
            // 
            this.picTop3.BackColor = System.Drawing.Color.Gray;
            this.picTop3.BackgroundImage = global::LearnToDrive.Properties.Resources.Image1;
            this.picTop3.Location = new System.Drawing.Point(398, 100);
            this.picTop3.Name = "picTop3";
            this.picTop3.Size = new System.Drawing.Size(200, 25);
            this.picTop3.TabIndex = 6;
            this.picTop3.TabStop = false;
            // 
            // picTop2
            // 
            this.picTop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picTop2.BackgroundImage = global::LearnToDrive.Properties.Resources.Image1;
            this.picTop2.Location = new System.Drawing.Point(199, 100);
            this.picTop2.Name = "picTop2";
            this.picTop2.Size = new System.Drawing.Size(200, 25);
            this.picTop2.TabIndex = 5;
            this.picTop2.TabStop = false;
            // 
            // picTop1
            // 
            this.picTop1.BackColor = System.Drawing.Color.Black;
            this.picTop1.BackgroundImage = global::LearnToDrive.Properties.Resources.Image1;
            this.picTop1.Location = new System.Drawing.Point(0, 100);
            this.picTop1.Name = "picTop1";
            this.picTop1.Size = new System.Drawing.Size(200, 25);
            this.picTop1.TabIndex = 4;
            this.picTop1.TabStop = false;
            // 
            // picBottom2
            // 
            this.picBottom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picBottom2.BackgroundImage = global::LearnToDrive.Properties.Resources.Image1;
            this.picBottom2.Location = new System.Drawing.Point(199, 275);
            this.picBottom2.Name = "picBottom2";
            this.picBottom2.Size = new System.Drawing.Size(200, 25);
            this.picBottom2.TabIndex = 3;
            this.picBottom2.TabStop = false;
            // 
            // picCar
            // 
            this.picCar.BackColor = System.Drawing.SystemColors.Control;
            this.picCar.Image = global::LearnToDrive.Properties.Resources.Car2;
            this.picCar.Location = new System.Drawing.Point(12, 200);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(50, 25);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picCar.TabIndex = 2;
            this.picCar.TabStop = false;
            this.picCar.Visible = false;
            this.picCar.Click += new System.EventHandler(this.picCar_Click);
            // 
            // picBottom1
            // 
            this.picBottom1.BackColor = System.Drawing.Color.Black;
            this.picBottom1.BackgroundImage = global::LearnToDrive.Properties.Resources.Image1;
            this.picBottom1.Location = new System.Drawing.Point(0, 275);
            this.picBottom1.Name = "picBottom1";
            this.picBottom1.Size = new System.Drawing.Size(200, 25);
            this.picBottom1.TabIndex = 1;
            this.picBottom1.TabStop = false;
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Location = new System.Drawing.Point(12, 508);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(71, 13);
            this.lblBestScore.TabIndex = 9;
            this.lblBestScore.Text = "Best Score: 0";
            // 
            // lblLastScore
            // 
            this.lblLastScore.AutoSize = true;
            this.lblLastScore.Location = new System.Drawing.Point(12, 488);
            this.lblLastScore.Name = "lblLastScore";
            this.lblLastScore.Size = new System.Drawing.Size(70, 13);
            this.lblLastScore.TabIndex = 10;
            this.lblLastScore.Text = "Last Score: 0";
            // 
            // lblLast3Average
            // 
            this.lblLast3Average.AutoSize = true;
            this.lblLast3Average.Location = new System.Drawing.Point(12, 448);
            this.lblLast3Average.Name = "lblLast3Average";
            this.lblLast3Average.Size = new System.Drawing.Size(97, 13);
            this.lblLast3Average.TabIndex = 11;
            this.lblLast3Average.Text = "Average (Last 3): 0";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(12, 468);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(59, 13);
            this.lblAverage.TabIndex = 12;
            this.lblAverage.Text = "Average: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblLast3Average);
            this.Controls.Add(this.lblLastScore);
            this.Controls.Add(this.lblBestScore);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.picBottom3);
            this.Controls.Add(this.picTop3);
            this.Controls.Add(this.picTop2);
            this.Controls.Add(this.picTop1);
            this.Controls.Add(this.picBottom2);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.picBottom1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBottom1;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.PictureBox picBottom2;
        private System.Windows.Forms.PictureBox picTop2;
        private System.Windows.Forms.PictureBox picTop1;
        private System.Windows.Forms.PictureBox picTop3;
        private System.Windows.Forms.PictureBox picBottom3;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblLastScore;
        private System.Windows.Forms.Label lblLast3Average;
        private System.Windows.Forms.Label lblAverage;
    }
}

