namespace trainerzombie_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.godmodeBox = new System.Windows.Forms.CheckBox();
            this.setRoundButton = new System.Windows.Forms.Button();
            this.roundUpDown = new System.Windows.Forms.NumericUpDown();
            this.AmmoButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pointsBox = new System.Windows.Forms.CheckBox();
            this.cButton = new System.Windows.Forms.Button();
            this.throwableButton = new System.Windows.Forms.Button();
            this.freezePointsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roundUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // godmodeBox
            // 
            this.godmodeBox.AutoSize = true;
            this.godmodeBox.Location = new System.Drawing.Point(23, 85);
            this.godmodeBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.godmodeBox.Name = "godmodeBox";
            this.godmodeBox.Size = new System.Drawing.Size(97, 24);
            this.godmodeBox.TabIndex = 2;
            this.godmodeBox.Text = "godmode";
            this.godmodeBox.UseVisualStyleBackColor = true;
            // 
            // setRoundButton
            // 
            this.setRoundButton.Location = new System.Drawing.Point(250, 13);
            this.setRoundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setRoundButton.Name = "setRoundButton";
            this.setRoundButton.Size = new System.Drawing.Size(86, 31);
            this.setRoundButton.TabIndex = 3;
            this.setRoundButton.Text = "set round";
            this.setRoundButton.UseVisualStyleBackColor = true;
            this.setRoundButton.Click += new System.EventHandler(this.setRoundButton_Click);
            // 
            // roundUpDown
            // 
            this.roundUpDown.Location = new System.Drawing.Point(343, 13);
            this.roundUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.roundUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.roundUpDown.Name = "roundUpDown";
            this.roundUpDown.Size = new System.Drawing.Size(137, 27);
            this.roundUpDown.TabIndex = 4;
            // 
            // AmmoButton
            // 
            this.AmmoButton.Location = new System.Drawing.Point(250, 67);
            this.AmmoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AmmoButton.Name = "AmmoButton";
            this.AmmoButton.Size = new System.Drawing.Size(186, 31);
            this.AmmoButton.TabIndex = 6;
            this.AmmoButton.Text = "unlimitedAmmo";
            this.AmmoButton.UseVisualStyleBackColor = true;
            this.AmmoButton.Click += new System.EventHandler(this.AmmoButton_Click);
            // 
            // pointsBox
            // 
            this.pointsBox.AutoSize = true;
            this.pointsBox.Location = new System.Drawing.Point(23, 117);
            this.pointsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pointsBox.Name = "pointsBox";
            this.pointsBox.Size = new System.Drawing.Size(139, 24);
            this.pointsBox.TabIndex = 7;
            this.pointsBox.Text = "unlimited points";
            this.pointsBox.UseVisualStyleBackColor = true;
            // 
            // cButton
            // 
            this.cButton.Location = new System.Drawing.Point(693, 102);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(94, 29);
            this.cButton.TabIndex = 10;
            this.cButton.Text = "connect";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // throwableButton
            // 
            this.throwableButton.Location = new System.Drawing.Point(250, 117);
            this.throwableButton.Name = "throwableButton";
            this.throwableButton.Size = new System.Drawing.Size(142, 29);
            this.throwableButton.TabIndex = 11;
            this.throwableButton.Text = "unlimited throwable";
            this.throwableButton.UseVisualStyleBackColor = true;
            this.throwableButton.Click += new System.EventHandler(this.throwable_Click);
            // 
            // freezePointsButton
            // 
            this.freezePointsButton.Location = new System.Drawing.Point(253, 158);
            this.freezePointsButton.Name = "freezePointsButton";
            this.freezePointsButton.Size = new System.Drawing.Size(94, 29);
            this.freezePointsButton.TabIndex = 12;
            this.freezePointsButton.Text = "freeze points";
            this.freezePointsButton.UseVisualStyleBackColor = true;
            this.freezePointsButton.Click += new System.EventHandler(this.freezePointsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.freezePointsButton);
            this.Controls.Add(this.throwableButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.pointsBox);
            this.Controls.Add(this.AmmoButton);
            this.Controls.Add(this.roundUpDown);
            this.Controls.Add(this.setRoundButton);
            this.Controls.Add(this.godmodeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CheckBox godmodeBox;
        private Button setRoundButton;
        private NumericUpDown roundUpDown;
        private Button AmmoButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox pointsBox;
        private Button cButton;
        private Button throwableButton;
        private Button freezePointsButton;
    }
}