using System.Linq;
using System.Windows.Forms;

namespace calculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 18);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 121);
            this.button2.Name = "button3";
            this.button2.Size = new System.Drawing.Size(40, 18);
            this.button2.TabIndex = 1;
            this.button2.Text = "3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 121);
            this.button3.Name = "button2";
            this.button3.Size = new System.Drawing.Size(40, 18);
            this.button3.TabIndex = 2;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 170);
            this.button4.Name = "button7";
            this.button4.Size = new System.Drawing.Size(40, 18);
            this.button4.TabIndex = 3;
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(131, 145);
            this.button5.Name = "button6";
            this.button5.Size = new System.Drawing.Size(40, 18);
            this.button5.TabIndex = 4;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.AutoEllipsis = true;
            this.button6.Location = new System.Drawing.Point(131, 170);
            this.button6.Name = "button9";
            this.button6.Size = new System.Drawing.Size(40, 18);
            this.button6.TabIndex = 5;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 170);
            this.button7.Name = "button8";
            this.button7.Size = new System.Drawing.Size(40, 18);
            this.button7.TabIndex = 6;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(85, 145);
            this.button8.Name = "button5";
            this.button8.Size = new System.Drawing.Size(40, 18);
            this.button8.TabIndex = 7;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(39, 145);
            this.button9.Name = "button4";
            this.button9.Size = new System.Drawing.Size(40, 18);
            this.button9.TabIndex = 8;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(39, 194);
            this.button10.Name = "button0";
            this.button10.Size = new System.Drawing.Size(40, 25);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 67);
            this.textBox1.TabIndex = 10;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(209, 302);
            this.button11.Name = "enterButton";
            this.button11.Size = new System.Drawing.Size(75, 42);
            this.button11.TabIndex = 11;
            this.button11.Text = "Enter";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(226, 110);
            this.button12.Name = "plusButton";
            this.button12.Size = new System.Drawing.Size(58, 42);
            this.button12.TabIndex = 12;
            this.button12.Text = "+";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(226, 158);
            this.button13.Name = "minusButton";
            this.button13.Size = new System.Drawing.Size(58, 42);
            this.button13.TabIndex = 13;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(226, 206);
            this.button14.Name = "multiplyButton";
            this.button14.Size = new System.Drawing.Size(58, 42);
            this.button14.TabIndex = 14;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(226, 254);
            this.button15.Name = "divideButton";
            this.button15.Size = new System.Drawing.Size(58, 42);
            this.button15.TabIndex = 15;
            this.button15.Text = "/";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 376);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            foreach (Button b in Controls.OfType<Button>())
            {
                b.Click += new System.EventHandler(this.button_clicked);
            }

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
    }
}

