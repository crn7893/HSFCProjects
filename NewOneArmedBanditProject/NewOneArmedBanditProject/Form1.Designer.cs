namespace NewOneArmedBanditProject
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
            this.slotBoxLast = new System.Windows.Forms.PictureBox();
            this.slotBoxMiddle = new System.Windows.Forms.PictureBox();
            this.slotBox1 = new System.Windows.Forms.PictureBox();
            this.spinButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slotBoxLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBoxMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // slotBoxLast
            // 
            this.slotBoxLast.InitialImage = global::NewOneArmedBanditProject.Properties.Resources.raspberry_Image;
            this.slotBoxLast.Location = new System.Drawing.Point(557, 58);
            this.slotBoxLast.Name = "slotBoxLast";
            this.slotBoxLast.Size = new System.Drawing.Size(275, 302);
            this.slotBoxLast.TabIndex = 2;
            this.slotBoxLast.TabStop = false;
            // 
            // slotBoxMiddle
            // 
            this.slotBoxMiddle.InitialImage = global::NewOneArmedBanditProject.Properties.Resources.Strawberry_Image;
            this.slotBoxMiddle.Location = new System.Drawing.Point(292, 58);
            this.slotBoxMiddle.Name = "slotBoxMiddle";
            this.slotBoxMiddle.Size = new System.Drawing.Size(259, 302);
            this.slotBoxMiddle.TabIndex = 1;
            this.slotBoxMiddle.TabStop = false;
            // 
            // slotBox1
            // 
            this.slotBox1.InitialImage = global::NewOneArmedBanditProject.Properties.Resources.Pikachu_Win;
            this.slotBox1.Location = new System.Drawing.Point(3, 58);
            this.slotBox1.Name = "slotBox1";
            this.slotBox1.Size = new System.Drawing.Size(283, 302);
            this.slotBox1.TabIndex = 0;
            this.slotBox1.TabStop = false;
            // 
            // spinButton
            // 
            this.spinButton.BackgroundImage = global::NewOneArmedBanditProject.Properties.Resources.Pikachu_Win;
            this.spinButton.Location = new System.Drawing.Point(357, 390);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(150, 30);
            this.spinButton.TabIndex = 3;
            this.spinButton.Text = "Spin to win!";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.slotBoxLast);
            this.Controls.Add(this.slotBoxMiddle);
            this.Controls.Add(this.slotBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slotBoxLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBoxMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slotBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox slotBox1;
        private System.Windows.Forms.PictureBox slotBoxMiddle;
        private System.Windows.Forms.PictureBox slotBoxLast;
        private System.Windows.Forms.Button spinButton;
    }
}

