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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox7.Checked && checkBox4.Checked && checkBox2.Checked && checkBox8.Checked)

            {
                MessageBox.Show(" looks like you,re having some serious symptoms it's better for you to contact with psycharist"
                    );

            }
            else
            {
                MessageBox.Show(" you're not having a disorder, but be gentle with yourself" +
                    " :) !  ");

            }
        }
    }
}
