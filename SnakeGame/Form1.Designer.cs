namespace SnakeGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.gameOverPic = new System.Windows.Forms.PictureBox();
            this.playCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.startButton.Location = new System.Drawing.Point(598, 66);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 36);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startGame);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(708, 130);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(19, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "0";
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(708, 175);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(19, 20);
            this.txtHighScore.TabIndex = 3;
            this.txtHighScore.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(594, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "HighScore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(594, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Score:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gold;
            this.saveButton.Location = new System.Drawing.Point(598, 656);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 36);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // gameOverPic
            // 
            this.gameOverPic.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gameOverPic.Image = global::SnakeGame.Properties.Resources.gameOver2;
            this.gameOverPic.Location = new System.Drawing.Point(151, 12);
            this.gameOverPic.Name = "gameOverPic";
            this.gameOverPic.Size = new System.Drawing.Size(301, 223);
            this.gameOverPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gameOverPic.TabIndex = 8;
            this.gameOverPic.TabStop = false;
            // 
            // playCanvas
            // 
            this.playCanvas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playCanvas.Location = new System.Drawing.Point(12, 12);
            this.playCanvas.Name = "playCanvas";
            this.playCanvas.Size = new System.Drawing.Size(580, 680);
            this.playCanvas.TabIndex = 1;
            this.playCanvas.TabStop = false;
            this.playCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updatePicBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.gameOverPic);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.playCanvas);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameOverPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox playCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox gameOverPic;
    }
}

