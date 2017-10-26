using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalc2
{

    public partial class Form1 : Form
    {
        private bool last_number = false;
        private Calculator calc;

        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        public class Calculator
        {
            private int result = 0;
            private char last_operator = '+';

            public static int funct_calc(int a, int b, char op)
            {
                switch (op)
                {
                    case '+':
                        return a + b;
                    case '-':
                        return a - b;
                    case '/':
                        return a / b;
                    case '*':
                        return a * b;
                }
                throw new ArgumentException("Illegal operator");
            }

            public void set_last_operator(char op)
            {
                last_operator = op;
            }

            public void calculate(int num)
            {
                result = funct_calc(result, num, last_operator);
            }

            public int get_result()
            {
                return result;
            }

        }
      

        private void btnNumClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (last_number)
                txtres.Text = txtres.Text + button.Text;
            else
                txtres.Text = button.Text;

            last_number = true;
        }

        private void opClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char op = System.Convert.ToChar(button.Text);
            calc.calculate(Convert.ToInt32(txtres.Text));
            calc.set_last_operator(op);
            last_number = false;
        }

        private void btnEqual(object sender, EventArgs e)
        {
            calc.calculate(Convert.ToInt32(txtres.Text));
            txtres.Text = "" + calc.get_result();
            last_number = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
