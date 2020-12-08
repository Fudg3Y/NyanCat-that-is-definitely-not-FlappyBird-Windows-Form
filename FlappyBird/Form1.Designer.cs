namespace FlappyBird
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeMiddle = new System.Windows.Forms.PictureBox();
            this.roof = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pipeMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(12, 628);
            this.scoreText.MinimumSize = new System.Drawing.Size(47, 13);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(47, 13);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            this.scoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeMiddle
            // 
            this.pipeMiddle.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.pipeMiddle.Image = global::FlappyBird.Properties.Resources.star2;
            this.pipeMiddle.Location = new System.Drawing.Point(414, 310);
            this.pipeMiddle.Name = "pipeMiddle";
            this.pipeMiddle.Size = new System.Drawing.Size(64, 56);
            this.pipeMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeMiddle.TabIndex = 9;
            this.pipeMiddle.TabStop = false;
            // 
            // roof
            // 
            this.roof.Location = new System.Drawing.Point(1, -18);
            this.roof.Name = "roof";
            this.roof.Size = new System.Drawing.Size(783, 23);
            this.roof.TabIndex = 8;
            this.roof.TabStop = false;
            // 
            // ground
            // 
            this.ground.Location = new System.Drawing.Point(1, 645);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(783, 37);
            this.ground.TabIndex = 7;
            this.ground.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.flappyBird.Image = global::FlappyBird.Properties.Resources._17xo;
            this.flappyBird.Location = new System.Drawing.Point(44, 236);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(147, 69);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.pipeBottom.Image = global::FlappyBird.Properties.Resources.star2;
            this.pipeBottom.Location = new System.Drawing.Point(167, 491);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(64, 56);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackgroundImage = global::FlappyBird.Properties.Resources.background;
            this.pipeTop.Image = global::FlappyBird.Properties.Resources.star2;
            this.pipeTop.Location = new System.Drawing.Point(544, 85);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(71, 51);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 696);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Pink;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(261, 218);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(231, 130);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(784, 650);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.pipeMiddle);
            this.Controls.Add(this.roof);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "NyanCat :) : ) : ) :) :) :) :) :) :) :DDDDDDDDDDDDD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox roof;
        private System.Windows.Forms.PictureBox pipeMiddle;
        private System.Windows.Forms.Button restartButton;
    }
}

