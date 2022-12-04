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
            this.ammoBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.godmodeBox = new System.Windows.Forms.CheckBox();
            this.setRoundButton = new System.Windows.Forms.Button();
            this.roundUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxRoundButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pointsBox = new System.Windows.Forms.CheckBox();
            this.secondAmmoBox = new System.Windows.Forms.CheckBox();
            this.throwablesBox = new System.Windows.Forms.CheckBox();
            this.cButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roundUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ammoBox
            // 
            this.ammoBox.AutoSize = true;
            this.ammoBox.Location = new System.Drawing.Point(23, 19);
            this.ammoBox.Name = "ammoBox";
            this.ammoBox.Size = new System.Drawing.Size(141, 24);
            this.ammoBox.TabIndex = 0;
            this.ammoBox.Text = "unlimited ammo";
            this.ammoBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
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
            this.roundUpDown.ValueChanged += new System.EventHandler(this.roundUpDown_ValueChanged);
            // 
            // maxRoundButton
            // 
            this.maxRoundButton.Location = new System.Drawing.Point(250, 67);
            this.maxRoundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maxRoundButton.Name = "maxRoundButton";
            this.maxRoundButton.Size = new System.Drawing.Size(186, 31);
            this.maxRoundButton.TabIndex = 6;
            this.maxRoundButton.Text = "setMaxRound";
            this.maxRoundButton.UseVisualStyleBackColor = true;
            this.maxRoundButton.Click += new System.EventHandler(this.endRoundButton_Click);
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
            // secondAmmoBox
            // 
            this.secondAmmoBox.AutoSize = true;
            this.secondAmmoBox.Location = new System.Drawing.Point(23, 49);
            this.secondAmmoBox.Name = "secondAmmoBox";
            this.secondAmmoBox.Size = new System.Drawing.Size(190, 24);
            this.secondAmmoBox.TabIndex = 8;
            this.secondAmmoBox.Text = "secondUnlimited ammo";
            this.secondAmmoBox.UseVisualStyleBackColor = true;
            // 
            // throwablesBox
            // 
            this.throwablesBox.AutoSize = true;
            this.throwablesBox.Location = new System.Drawing.Point(23, 148);
            this.throwablesBox.Name = "throwablesBox";
            this.throwablesBox.Size = new System.Drawing.Size(171, 24);
            this.throwablesBox.TabIndex = 9;
            this.throwablesBox.Text = "unlimited throwables";
            this.throwablesBox.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "1 health zombies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(721, 49);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(48, 20);
            this.roundLabel.TabIndex = 12;
            this.roundLabel.Text = "round";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.throwablesBox);
            this.Controls.Add(this.secondAmmoBox);
            this.Controls.Add(this.pointsBox);
            this.Controls.Add(this.maxRoundButton);
            this.Controls.Add(this.roundUpDown);
            this.Controls.Add(this.setRoundButton);
            this.Controls.Add(this.godmodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ammoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox ammoBox;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private CheckBox godmodeBox;
        private Button setRoundButton;
        private NumericUpDown roundUpDown;
        private Button maxRoundButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CheckBox pointsBox;
        private CheckBox secondAmmoBox;
        private CheckBox throwablesBox;
        private Button cButton;
        private Button button1;
        private Label roundLabel;
    }
}