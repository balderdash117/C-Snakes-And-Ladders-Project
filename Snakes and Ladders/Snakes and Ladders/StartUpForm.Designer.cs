namespace Snakes_and_Ladders
{
    partial class StartUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpForm));
            this.ButtonBegin = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.Label();
            this.player1BG = new System.Windows.Forms.GroupBox();
            this.player2BG = new System.Windows.Forms.GroupBox();
            this.player3GB = new System.Windows.Forms.GroupBox();
            this.player4GB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.player1name = new System.Windows.Forms.TextBox();
            this.player2name = new System.Windows.Forms.TextBox();
            this.player3name = new System.Windows.Forms.TextBox();
            this.player4name = new System.Windows.Forms.TextBox();
            this.player3image = new System.Windows.Forms.Button();
            this.player1image = new System.Windows.Forms.Button();
            this.player2image = new System.Windows.Forms.Button();
            this.player4image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.player1BG.SuspendLayout();
            this.player2BG.SuspendLayout();
            this.player3GB.SuspendLayout();
            this.player4GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBegin
            // 
            this.ButtonBegin.Location = new System.Drawing.Point(846, 424);
            this.ButtonBegin.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBegin.Name = "ButtonBegin";
            this.ButtonBegin.Size = new System.Drawing.Size(198, 65);
            this.ButtonBegin.TabIndex = 0;
            this.ButtonBegin.Text = "Begin";
            this.ButtonBegin.UseVisualStyleBackColor = true;
            this.ButtonBegin.Click += new System.EventHandler(this.ButtonBegin_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(423, 147);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(112, 31);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the numbner of players";
            // 
            // options
            // 
            this.options.AutoSize = true;
            this.options.Location = new System.Drawing.Point(12, 93);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(86, 25);
            this.options.TabIndex = 3;
            this.options.Text = "Options";
            // 
            // player1BG
            // 
            this.player1BG.Controls.Add(this.player1image);
            this.player1BG.Controls.Add(this.player1name);
            this.player1BG.Controls.Add(this.label5);
            this.player1BG.Location = new System.Drawing.Point(66, 204);
            this.player1BG.Name = "player1BG";
            this.player1BG.Size = new System.Drawing.Size(218, 204);
            this.player1BG.TabIndex = 8;
            this.player1BG.TabStop = false;
            this.player1BG.Text = "Player 1";
            // 
            // player2BG
            // 
            this.player2BG.Controls.Add(this.player2image);
            this.player2BG.Controls.Add(this.player2name);
            this.player2BG.Controls.Add(this.label4);
            this.player2BG.Location = new System.Drawing.Point(318, 204);
            this.player2BG.Name = "player2BG";
            this.player2BG.Size = new System.Drawing.Size(218, 204);
            this.player2BG.TabIndex = 9;
            this.player2BG.TabStop = false;
            this.player2BG.Text = "Player 2";
            // 
            // player3GB
            // 
            this.player3GB.Controls.Add(this.player3image);
            this.player3GB.Controls.Add(this.player3name);
            this.player3GB.Controls.Add(this.label3);
            this.player3GB.Location = new System.Drawing.Point(570, 204);
            this.player3GB.Name = "player3GB";
            this.player3GB.Size = new System.Drawing.Size(218, 204);
            this.player3GB.TabIndex = 9;
            this.player3GB.TabStop = false;
            this.player3GB.Text = "Player 3";
            // 
            // player4GB
            // 
            this.player4GB.Controls.Add(this.player4image);
            this.player4GB.Controls.Add(this.player4name);
            this.player4GB.Controls.Add(this.label2);
            this.player4GB.Location = new System.Drawing.Point(822, 204);
            this.player4GB.Name = "player4GB";
            this.player4GB.Size = new System.Drawing.Size(218, 204);
            this.player4GB.TabIndex = 9;
            this.player4GB.TabStop = false;
            this.player4GB.Text = "Player 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // player1name
            // 
            this.player1name.Location = new System.Drawing.Point(29, 65);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(153, 31);
            this.player1name.TabIndex = 2;
            // 
            // player2name
            // 
            this.player2name.Location = new System.Drawing.Point(24, 65);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(153, 31);
            this.player2name.TabIndex = 3;
            // 
            // player3name
            // 
            this.player3name.Location = new System.Drawing.Point(26, 65);
            this.player3name.Name = "player3name";
            this.player3name.Size = new System.Drawing.Size(153, 31);
            this.player3name.TabIndex = 3;
            // 
            // player4name
            // 
            this.player4name.Location = new System.Drawing.Point(26, 65);
            this.player4name.Name = "player4name";
            this.player4name.Size = new System.Drawing.Size(153, 31);
            this.player4name.TabIndex = 4;
            // 
            // player3image
            // 
            this.player3image.Location = new System.Drawing.Point(26, 117);
            this.player3image.Name = "player3image";
            this.player3image.Size = new System.Drawing.Size(163, 51);
            this.player3image.TabIndex = 4;
            this.player3image.Text = "Change Image";
            this.player3image.UseVisualStyleBackColor = true;
            // 
            // player1image
            // 
            this.player1image.Location = new System.Drawing.Point(29, 117);
            this.player1image.Name = "player1image";
            this.player1image.Size = new System.Drawing.Size(163, 51);
            this.player1image.TabIndex = 5;
            this.player1image.Text = "Change Image";
            this.player1image.UseVisualStyleBackColor = true;
            // 
            // player2image
            // 
            this.player2image.Location = new System.Drawing.Point(24, 117);
            this.player2image.Name = "player2image";
            this.player2image.Size = new System.Drawing.Size(163, 51);
            this.player2image.TabIndex = 6;
            this.player2image.Text = "Change Image";
            this.player2image.UseVisualStyleBackColor = true;
            // 
            // player4image
            // 
            this.player4image.Location = new System.Drawing.Point(26, 117);
            this.player4image.Name = "player4image";
            this.player4image.Size = new System.Drawing.Size(163, 51);
            this.player4image.TabIndex = 7;
            this.player4image.Text = "Change Image";
            this.player4image.UseVisualStyleBackColor = true;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1057, 502);
            this.Controls.Add(this.player4GB);
            this.Controls.Add(this.player3GB);
            this.Controls.Add(this.player2BG);
            this.Controls.Add(this.player1BG);
            this.Controls.Add(this.options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ButtonBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartUpForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.player1BG.ResumeLayout(false);
            this.player1BG.PerformLayout();
            this.player2BG.ResumeLayout(false);
            this.player2BG.PerformLayout();
            this.player3GB.ResumeLayout(false);
            this.player3GB.PerformLayout();
            this.player4GB.ResumeLayout(false);
            this.player4GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBegin;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label options;
        private System.Windows.Forms.GroupBox player1BG;
        private System.Windows.Forms.Button player1image;
        private System.Windows.Forms.TextBox player1name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox player2BG;
        private System.Windows.Forms.Button player2image;
        private System.Windows.Forms.TextBox player2name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox player3GB;
        private System.Windows.Forms.Button player3image;
        private System.Windows.Forms.TextBox player3name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox player4GB;
        private System.Windows.Forms.Button player4image;
        private System.Windows.Forms.TextBox player4name;
        private System.Windows.Forms.Label label2;
    }
}