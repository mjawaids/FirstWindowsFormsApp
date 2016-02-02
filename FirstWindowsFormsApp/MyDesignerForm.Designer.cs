namespace FirstWindowsFormsApp
{
    partial class MyDesignerForm
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
            this.ShowMessageButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowMessageButton
            // 
            this.ShowMessageButton.Location = new System.Drawing.Point(12, 38);
            this.ShowMessageButton.Name = "ShowMessageButton";
            this.ShowMessageButton.Size = new System.Drawing.Size(177, 23);
            this.ShowMessageButton.TabIndex = 0;
            this.ShowMessageButton.Text = "Show Message";
            this.ShowMessageButton.UseVisualStyleBackColor = true;
            this.ShowMessageButton.Click += new System.EventHandler(this.ShowMessageButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.Location = new System.Drawing.Point(12, 64);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(177, 23);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "[Label]";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 12);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(177, 20);
            this.MessageTextBox.TabIndex = 2;
            // 
            // MyDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ShowMessageButton);
            this.Name = "MyDesignerForm";
            this.Text = "MyDesignerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowMessageButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
    }
}