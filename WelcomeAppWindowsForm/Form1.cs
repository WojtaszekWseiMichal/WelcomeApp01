using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeAppWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelStatement1.Text = "Welcome, " + textBoxName.Text + " " + textboxSurrname.Text + " !";
            int age = Convert.ToInt32(textBoxAge.Text);
            if (age < 67) labelStatement2.Text = String.Format("To become pensioner you will need to work for next {0} years", 67 - age);
            else if (age == 67) labelStatement2.Text = "This year you will become pensioner !";
            else labelStatement2.Text = "You are pensioner already !";
        }
    }
}
