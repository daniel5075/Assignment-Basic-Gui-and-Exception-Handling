namespace Assignment_Basic_Gui_and_Exception_Handling
{
    partial class startMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startMenu));
            this.labelLevel = new System.Windows.Forms.Label();
            this.listLevel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Purple = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Black = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.Location = new System.Drawing.Point(11, 92);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(244, 26);
            this.labelLevel.TabIndex = 0;
            this.labelLevel.Text = "Choose your level 1-5";
            this.labelLevel.Click += new System.EventHandler(this.label1_Click);
            // 
            // listLevel
            // 
            this.listLevel.Location = new System.Drawing.Point(261, 98);
            this.listLevel.Name = "listLevel";
            this.listLevel.Size = new System.Drawing.Size(100, 20);
            this.listLevel.TabIndex = 3;
            this.listLevel.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Black);
            this.groupBox1.Controls.Add(this.Green);
            this.groupBox1.Controls.Add(this.Blue);
            this.groupBox1.Controls.Add(this.Purple);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What color do you want your snake?";
            // 
            // Purple
            // 
            this.Purple.AutoSize = true;
            this.Purple.Location = new System.Drawing.Point(7, 35);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(85, 24);
            this.Purple.TabIndex = 0;
            this.Purple.TabStop = true;
            this.Purple.Text = "Purple";
            this.Purple.UseVisualStyleBackColor = true;
            this.Purple.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(7, 66);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(70, 24);
            this.Blue.TabIndex = 1;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(7, 98);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(84, 24);
            this.Green.TabIndex = 2;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Black
            // 
            this.Black.AutoSize = true;
            this.Black.Location = new System.Drawing.Point(7, 128);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(78, 24);
            this.Black.TabIndex = 3;
            this.Black.TabStop = true;
            this.Black.Text = "Black";
            this.Black.UseVisualStyleBackColor = true;
            this.Black.CheckedChanged += new System.EventHandler(this.Black_CheckedChanged);
            // 
            // startMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listLevel);
            this.Controls.Add(this.labelLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "startMenu";
            this.Text = "Welcome to the Snake Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox listLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Black;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Purple;
    }
}

