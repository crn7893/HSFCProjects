namespace StackQueueProject
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
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ModeSwitchButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.ForeColor = System.Drawing.Color.Indigo;
            this.AddButton.Location = new System.Drawing.Point(150, 120);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 39);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.ForeColor = System.Drawing.Color.Indigo;
            this.RemoveButton.Location = new System.Drawing.Point(550, 120);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 39);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(287, 350);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(221, 20);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.Text = "Click to type";
            // 
            // ModeSwitchButton
            // 
            this.ModeSwitchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ModeSwitchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModeSwitchButton.ForeColor = System.Drawing.Color.Indigo;
            this.ModeSwitchButton.Location = new System.Drawing.Point(350, 206);
            this.ModeSwitchButton.Name = "ModeSwitchButton";
            this.ModeSwitchButton.Size = new System.Drawing.Size(100, 39);
            this.ModeSwitchButton.TabIndex = 3;
            this.ModeSwitchButton.Text = "Switch to queue";
            this.ModeSwitchButton.UseVisualStyleBackColor = false;
            this.ModeSwitchButton.Click += new System.EventHandler(this.ModeSwitchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModeSwitchButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button ModeSwitchButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

