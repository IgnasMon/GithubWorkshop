namespace WeLearntoUseGithubTheGayWay
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
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.Answer_text = new System.Windows.Forms.TextBox();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_multiply
            // 
            this.button_multiply.Location = new System.Drawing.Point(171, 110);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(40, 29);
            this.button_multiply.TabIndex = 10;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divide
            // 
            this.button_divide.Location = new System.Drawing.Point(217, 110);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(42, 29);
            this.button_divide.TabIndex = 11;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(217, 160);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(42, 29);
            this.button_plus.TabIndex = 12;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(171, 160);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(40, 29);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // Answer_text
            // 
            this.Answer_text.Location = new System.Drawing.Point(31, 33);
            this.Answer_text.Name = "Answer_text";
            this.Answer_text.Size = new System.Drawing.Size(294, 27);
            this.Answer_text.TabIndex = 14;
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(31, 112);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(125, 27);
            this.Input1.TabIndex = 15;
            this.Input1.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(31, 160);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(125, 27);
            this.Input2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Answer_text);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_multiply);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_multiply;
        private Button button_divide;
        private Button button_plus;
        private Button button_minus;
        private TextBox Answer_text;
        private TextBox Input1;
        private TextBox Input2;
    }
}