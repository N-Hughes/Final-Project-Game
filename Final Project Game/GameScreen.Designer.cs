namespace Final_Project_Game
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameEngine = new System.Windows.Forms.Timer(this.components);
            this.outputLabel = new System.Windows.Forms.Label();
            this.enemyPicture = new System.Windows.Forms.PictureBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.defendButton = new System.Windows.Forms.Button();
            this.restButton = new System.Windows.Forms.Button();
            this.strikeButton = new System.Windows.Forms.Button();
            this.slashButton = new System.Windows.Forms.Button();
            this.iceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // GameEngine
            // 
            this.GameEngine.Enabled = true;
            this.GameEngine.Interval = 18;
            this.GameEngine.Tick += new System.EventHandler(this.GameEngine_Tick);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(525, 124);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(466, 215);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Enemy has dealt 43 damage \r\n\r\nYou dealt 13 damage\r\n\r\n";
            // 
            // enemyPicture
            // 
            this.enemyPicture.BackColor = System.Drawing.Color.Transparent;
            this.enemyPicture.BackgroundImage = global::Final_Project_Game.Properties.Resources.enemySeven;
            this.enemyPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyPicture.Location = new System.Drawing.Point(20, 16);
            this.enemyPicture.Name = "enemyPicture";
            this.enemyPicture.Size = new System.Drawing.Size(482, 333);
            this.enemyPicture.TabIndex = 1;
            this.enemyPicture.TabStop = false;
            // 
            // attackButton
            // 
            this.attackButton.BackColor = System.Drawing.Color.White;
            this.attackButton.FlatAppearance.BorderSize = 0;
            this.attackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.attackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.attackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attackButton.ForeColor = System.Drawing.Color.White;
            this.attackButton.Location = new System.Drawing.Point(645, 722);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(107, 32);
            this.attackButton.TabIndex = 2;
            this.attackButton.UseVisualStyleBackColor = false;
            this.attackButton.Click += new System.EventHandler(this.attackButton_Click);
            // 
            // defendButton
            // 
            this.defendButton.BackColor = System.Drawing.Color.White;
            this.defendButton.FlatAppearance.BorderSize = 0;
            this.defendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.defendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.defendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defendButton.Location = new System.Drawing.Point(645, 777);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(110, 33);
            this.defendButton.TabIndex = 3;
            this.defendButton.UseVisualStyleBackColor = false;
            this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
            // 
            // restButton
            // 
            this.restButton.BackColor = System.Drawing.Color.White;
            this.restButton.FlatAppearance.BorderSize = 0;
            this.restButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.restButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.restButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restButton.Location = new System.Drawing.Point(672, 833);
            this.restButton.Name = "restButton";
            this.restButton.Size = new System.Drawing.Size(67, 30);
            this.restButton.TabIndex = 4;
            this.restButton.UseVisualStyleBackColor = false;
            this.restButton.Click += new System.EventHandler(this.restButton_Click);
            // 
            // strikeButton
            // 
            this.strikeButton.BackColor = System.Drawing.Color.Transparent;
            this.strikeButton.FlatAppearance.BorderSize = 0;
            this.strikeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.strikeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.strikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strikeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikeButton.ForeColor = System.Drawing.Color.White;
            this.strikeButton.Location = new System.Drawing.Point(808, 722);
            this.strikeButton.Name = "strikeButton";
            this.strikeButton.Size = new System.Drawing.Size(107, 32);
            this.strikeButton.TabIndex = 5;
            this.strikeButton.Text = "Strike";
            this.strikeButton.UseVisualStyleBackColor = false;
            this.strikeButton.Visible = false;
            this.strikeButton.Click += new System.EventHandler(this.strikeButton_Click);
            // 
            // slashButton
            // 
            this.slashButton.BackColor = System.Drawing.Color.Transparent;
            this.slashButton.FlatAppearance.BorderSize = 0;
            this.slashButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.slashButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.slashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slashButton.ForeColor = System.Drawing.Color.White;
            this.slashButton.Location = new System.Drawing.Point(808, 796);
            this.slashButton.Name = "slashButton";
            this.slashButton.Size = new System.Drawing.Size(107, 32);
            this.slashButton.TabIndex = 6;
            this.slashButton.Text = "Slash";
            this.slashButton.UseVisualStyleBackColor = false;
            this.slashButton.Visible = false;
            this.slashButton.Click += new System.EventHandler(this.slashButton_Click);
            // 
            // iceButton
            // 
            this.iceButton.BackColor = System.Drawing.Color.Transparent;
            this.iceButton.FlatAppearance.BorderSize = 0;
            this.iceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.iceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iceButton.ForeColor = System.Drawing.Color.White;
            this.iceButton.Location = new System.Drawing.Point(1047, 722);
            this.iceButton.Name = "iceButton";
            this.iceButton.Size = new System.Drawing.Size(107, 32);
            this.iceButton.TabIndex = 7;
            this.iceButton.Text = "Ice";
            this.iceButton.UseVisualStyleBackColor = false;
            this.iceButton.Visible = false;
            this.iceButton.Click += new System.EventHandler(this.iceButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(808, 870);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chargedstrike";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Final_Project_Game.Properties.Resources.REAL_GAME_SCREEN;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iceButton);
            this.Controls.Add(this.slashButton);
            this.Controls.Add(this.strikeButton);
            this.Controls.Add(this.restButton);
            this.Controls.Add(this.defendButton);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.enemyPicture);
            this.Controls.Add(this.outputLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameEngine;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox enemyPicture;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Button restButton;
        private System.Windows.Forms.Button strikeButton;
        private System.Windows.Forms.Button slashButton;
        private System.Windows.Forms.Button iceButton;
        private System.Windows.Forms.Button button1;
    }
}
