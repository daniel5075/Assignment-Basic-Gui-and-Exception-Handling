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
            // startMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 575);
            this.Controls.Add(this.listLevel);
            this.Controls.Add(this.labelLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "startMenu";
            this.Text = "Welcome to the Snake Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox listLevel;
    }
}

