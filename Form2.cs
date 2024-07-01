using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visiual_prog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked && checkBox7.Checked && checkBox4.Checked && checkBox2.Checked)

            {
                MessageBox.Show(" looks like you,re having some serious symptoms it's better for you to contact with psycharist"
                    );

            }
            else
            {
                MessageBox.Show(" you don't seem depressed maybe it's just a bad mood , hope you feel better soon :) !  ");

            }
        }
    }
}
