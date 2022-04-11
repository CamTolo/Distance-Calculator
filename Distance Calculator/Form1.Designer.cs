
namespace Distance_Calculator
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
            this.vehicleSpeedLabel = new System.Windows.Forms.Label();
            this.hoursTraveledLabel = new System.Windows.Forms.Label();
            this.vehicleSpeedTextBox = new System.Windows.Forms.TextBox();
            this.hoursTraveledTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.creationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vehicleSpeedLabel
            // 
            this.vehicleSpeedLabel.AutoSize = true;
            this.vehicleSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleSpeedLabel.Location = new System.Drawing.Point(48, 52);
            this.vehicleSpeedLabel.Name = "vehicleSpeedLabel";
            this.vehicleSpeedLabel.Size = new System.Drawing.Size(171, 16);
            this.vehicleSpeedLabel.TabIndex = 0;
            this.vehicleSpeedLabel.Text = "Vehicle Speed in MPH: ";
            // 
            // hoursTraveledLabel
            // 
            this.hoursTraveledLabel.AutoSize = true;
            this.hoursTraveledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTraveledLabel.Location = new System.Drawing.Point(95, 88);
            this.hoursTraveledLabel.Name = "hoursTraveledLabel";
            this.hoursTraveledLabel.Size = new System.Drawing.Size(124, 16);
            this.hoursTraveledLabel.TabIndex = 1;
            this.hoursTraveledLabel.Text = "Hours Traveled: ";
            // 
            // vehicleSpeedTextBox
            // 
            this.vehicleSpeedTextBox.Location = new System.Drawing.Point(271, 52);
            this.vehicleSpeedTextBox.Name = "vehicleSpeedTextBox";
            this.vehicleSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicleSpeedTextBox.TabIndex = 2;
            // 
            // hoursTraveledTextBox
            // 
            this.hoursTraveledTextBox.Location = new System.Drawing.Point(271, 88);
            this.hoursTraveledTextBox.Name = "hoursTraveledTextBox";
            this.hoursTraveledTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursTraveledTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(123, 304);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(246, 304);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 15;
            this.outputListBox.Location = new System.Drawing.Point(98, 127);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(248, 152);
            this.outputListBox.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(372, 191);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // creationLabel
            // 
            this.creationLabel.AutoSize = true;
            this.creationLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.creationLabel.Font = new System.Drawing.Font("PenultimateLight", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.creationLabel.Location = new System.Drawing.Point(290, 330);
            this.creationLabel.Name = "creationLabel";
            this.creationLabel.Size = new System.Drawing.Size(157, 15);
            this.creationLabel.TabIndex = 9;
            this.creationLabel.Text = "Designed by: Cam Tolo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 348);
            this.Controls.Add(this.creationLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hoursTraveledTextBox);
            this.Controls.Add(this.vehicleSpeedTextBox);
            this.Controls.Add(this.hoursTraveledLabel);
            this.Controls.Add(this.vehicleSpeedLabel);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehicleSpeedLabel;
        private System.Windows.Forms.Label hoursTraveledLabel;
        private System.Windows.Forms.TextBox vehicleSpeedTextBox;
        private System.Windows.Forms.TextBox hoursTraveledTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label creationLabel;
    }
}

