namespace SmallAndLargeGUI
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.numberTextBox1 = new System.Windows.Forms.TextBox();
            this.numberTextBox6 = new System.Windows.Forms.TextBox();
            this.numberTextBox2 = new System.Windows.Forms.TextBox();
            this.numberTextBox7 = new System.Windows.Forms.TextBox();
            this.numberTextBox3 = new System.Windows.Forms.TextBox();
            this.numberTextBox4 = new System.Windows.Forms.TextBox();
            this.numberTextBox5 = new System.Windows.Forms.TextBox();
            this.numberTextBox8 = new System.Windows.Forms.TextBox();
            this.numberTextBox9 = new System.Windows.Forms.TextBox();
            this.numberTextBox10 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(68, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(119, 13);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Enter 10 integer values:";
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Location = new System.Drawing.Point(10, 35);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox1.TabIndex = 1;
            // 
            // numberTextBox6
            // 
            this.numberTextBox6.Location = new System.Drawing.Point(10, 70);
            this.numberTextBox6.Name = "numberTextBox6";
            this.numberTextBox6.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox6.TabIndex = 2;
            // 
            // numberTextBox2
            // 
            this.numberTextBox2.Location = new System.Drawing.Point(60, 35);
            this.numberTextBox2.Name = "numberTextBox2";
            this.numberTextBox2.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox2.TabIndex = 3;
            // 
            // numberTextBox7
            // 
            this.numberTextBox7.Location = new System.Drawing.Point(60, 70);
            this.numberTextBox7.Name = "numberTextBox7";
            this.numberTextBox7.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox7.TabIndex = 4;
            // 
            // numberTextBox3
            // 
            this.numberTextBox3.Location = new System.Drawing.Point(110, 35);
            this.numberTextBox3.Name = "numberTextBox3";
            this.numberTextBox3.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox3.TabIndex = 5;
            // 
            // numberTextBox4
            // 
            this.numberTextBox4.Location = new System.Drawing.Point(160, 35);
            this.numberTextBox4.Name = "numberTextBox4";
            this.numberTextBox4.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox4.TabIndex = 6;
            // 
            // numberTextBox5
            // 
            this.numberTextBox5.Location = new System.Drawing.Point(210, 35);
            this.numberTextBox5.Name = "numberTextBox5";
            this.numberTextBox5.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox5.TabIndex = 7;
            // 
            // numberTextBox8
            // 
            this.numberTextBox8.Location = new System.Drawing.Point(110, 70);
            this.numberTextBox8.Name = "numberTextBox8";
            this.numberTextBox8.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox8.TabIndex = 8;
            // 
            // numberTextBox9
            // 
            this.numberTextBox9.Location = new System.Drawing.Point(160, 70);
            this.numberTextBox9.Name = "numberTextBox9";
            this.numberTextBox9.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox9.TabIndex = 9;
            // 
            // numberTextBox10
            // 
            this.numberTextBox10.Location = new System.Drawing.Point(210, 70);
            this.numberTextBox10.Name = "numberTextBox10";
            this.numberTextBox10.Size = new System.Drawing.Size(40, 20);
            this.numberTextBox10.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(92, 109);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(68, 154);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(124, 13);
            this.outputLabel1.TabIndex = 12;
            this.outputLabel1.Text = "The lowest number is ##";
            this.outputLabel1.Visible = false;
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(68, 178);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(128, 13);
            this.outputLabel2.TabIndex = 13;
            this.outputLabel2.Text = "The highest number is ##";
            this.outputLabel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 262);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numberTextBox10);
            this.Controls.Add(this.numberTextBox9);
            this.Controls.Add(this.numberTextBox8);
            this.Controls.Add(this.numberTextBox5);
            this.Controls.Add(this.numberTextBox4);
            this.Controls.Add(this.numberTextBox3);
            this.Controls.Add(this.numberTextBox7);
            this.Controls.Add(this.numberTextBox2);
            this.Controls.Add(this.numberTextBox6);
            this.Controls.Add(this.numberTextBox1);
            this.Controls.Add(this.infoLabel);
            this.Name = "Form1";
            this.Text = "Small and Large";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox numberTextBox1;
        private System.Windows.Forms.TextBox numberTextBox6;
        private System.Windows.Forms.TextBox numberTextBox2;
        private System.Windows.Forms.TextBox numberTextBox7;
        private System.Windows.Forms.TextBox numberTextBox3;
        private System.Windows.Forms.TextBox numberTextBox4;
        private System.Windows.Forms.TextBox numberTextBox5;
        private System.Windows.Forms.TextBox numberTextBox8;
        private System.Windows.Forms.TextBox numberTextBox9;
        private System.Windows.Forms.TextBox numberTextBox10;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label outputLabel1;
        private System.Windows.Forms.Label outputLabel2;
    }
}

