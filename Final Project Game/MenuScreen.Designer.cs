namespace Final_Project_Game
{
    partial class MenuScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ConButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.playerBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(713, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Player Name Here:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(583, 153);
            this.button1.TabIndex = 2;
            this.button1.Text = "Play Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConButton
            // 
            this.ConButton.BackColor = System.Drawing.Color.Transparent;
            this.ConButton.FlatAppearance.BorderSize = 0;
            this.ConButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConButton.Location = new System.Drawing.Point(140, 492);
            this.ConButton.Name = "ConButton";
            this.ConButton.Size = new System.Drawing.Size(533, 158);
            this.ConButton.TabIndex = 3;
            this.ConButton.Text = "Continue";
            this.ConButton.UseVisualStyleBackColor = false;
            this.ConButton.Click += new System.EventHandler(this.ConButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(1201, 274);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(546, 153);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Exit Game";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // playerBox
            // 
            this.playerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 38F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBox.Location = new System.Drawing.Point(712, 582);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(646, 65);
            this.playerBox.TabIndex = 5;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Final_Project_Game.Properties.Resources.Untitled_1__1_;
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.ConButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox playerBox;
    }
}
