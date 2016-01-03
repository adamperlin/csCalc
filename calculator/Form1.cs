using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpressionEvaluator;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EvalExpression(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "eval":

                    this.inputBox.Text = findResult(this.inputBox.Text);
                    break;
                case "clear":
                    this.inputBox.Text = "";
                    break;
            }
           
        }

        private void checkKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.inputBox.Text = findResult(this.inputBox.Text);
            }
        }
    
        private static string findResult(string input){
            return Solver.Evaluate(input);
        }

      
        
    }
}
