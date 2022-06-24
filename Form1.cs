using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal numberGrade = Convert.ToDecimal(NumberGrade.Text);
            string letterGrade = "";
            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87) //calc to letter grade
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79) //calc to letter grade
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67) //calc to letter grade 
            {
                letterGrade = "D";
            }
            else //calc to letter grade if number not above its an F
            {
                letterGrade = "F";
            }
            {
                LetterGrade.Text = letterGrade; 
            }
            { 
                NumberGrade.Focus(); 
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
