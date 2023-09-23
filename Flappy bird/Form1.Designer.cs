﻿namespace Flappy_bird
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.PipeBot = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::Flappy_bird.Properties.Resources.bird;
            this.FlappyBird.Location = new System.Drawing.Point(62, 229);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(82, 65);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // PipeBot
            // 
            this.PipeBot.Image = global::Flappy_bird.Properties.Resources.pipe;
            this.PipeBot.Location = new System.Drawing.Point(388, 376);
            this.PipeBot.Name = "PipeBot";
            this.PipeBot.Size = new System.Drawing.Size(100, 303);
            this.PipeBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBot.TabIndex = 1;
            this.PipeBot.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::Flappy_bird.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(388, -133);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(100, 317);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 2;
            this.PipeTop.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappy_bird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-15, 585);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(598, 76);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(89, 20);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(551, 647);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.PipeBot);
            this.Controls.Add(this.FlappyBird);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox PipeBot;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label Score;
    }
}

