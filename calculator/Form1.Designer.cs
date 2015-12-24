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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eval = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eval
            // 
            this.eval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.eval.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.eval.FlatAppearance.BorderSize = 0;
            this.eval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eval.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold);
            this.eval.ForeColor = System.Drawing.Color.White;
            this.eval.Location = new System.Drawing.Point(0, 446);
            this.eval.Name = "eval";
            this.eval.Size = new System.Drawing.Size(404, 115);
            this.eval.TabIndex = 0;
            this.eval.Text = "Evaluate";
            this.eval.UseVisualStyleBackColor = false;
            this.eval.Click += new System.EventHandler(this.EvalExpression);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputBox.Font = new System.Drawing.Font("Roboto", 72F);
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(404, 116);
            this.inputBox.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(0, 325);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(404, 115);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.EvalExpression);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(404, 561);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.eval);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "X Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eval;
        private System.Windows.Forms.TextBox inputBox;
        private Button clear;

    }
}

