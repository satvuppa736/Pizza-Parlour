namespace Pizza_Parlour
{
    partial class pizzaParlour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaParlour));
            this.welcolmeLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.meaninglessLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcolmeLabel
            // 
            this.welcolmeLabel.AutoSize = true;
            this.welcolmeLabel.Font = new System.Drawing.Font("Tekton Pro Cond", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcolmeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.welcolmeLabel.Location = new System.Drawing.Point(12, 29);
            this.welcolmeLabel.Name = "welcolmeLabel";
            this.welcolmeLabel.Size = new System.Drawing.Size(314, 35);
            this.welcolmeLabel.TabIndex = 0;
            this.welcolmeLabel.Text = "Welcome to Dave\'s Pizza Parlour";
            this.welcolmeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(378, 109);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(142, 47);
            this.inputBox.TabIndex = 1;
            // 
            // meaninglessLabel
            // 
            this.meaninglessLabel.AutoSize = true;
            this.meaninglessLabel.Font = new System.Drawing.Font("Tekton Pro Cond", 16F, System.Drawing.FontStyle.Bold);
            this.meaninglessLabel.Location = new System.Drawing.Point(30, 125);
            this.meaninglessLabel.Name = "meaninglessLabel";
            this.meaninglessLabel.Size = new System.Drawing.Size(342, 27);
            this.meaninglessLabel.TabIndex = 2;
            this.meaninglessLabel.Text = "Please enter a diameter amount for your pizza!";
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Transparent;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(378, 194);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(142, 32);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Price!";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Tekton Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(30, 254);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 25);
            this.outputLabel.TabIndex = 4;
            // 
            // pizzaParlour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 358);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.meaninglessLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.welcolmeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pizzaParlour";
            this.Text = "Pizza Parlour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcolmeLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label meaninglessLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

