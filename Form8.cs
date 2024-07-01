using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace visiual_prog
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-23IKCPM6\DAREEN;Initial Catalog=login;Integrated Security=True");

        

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text )
            {
                MessageBox.Show("password doesn't match please enter again  ","regestration faild ");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
            }
            else if (textBox1.Text=="" || textBox2.Text =="" || textBox3.Text=="" )
            {
                MessageBox.Show("please enter vaild information ");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(" insert into users (username , password ) values( '"+textBox1.Text + "',''"+textBox2.Text + "  )  " , con);
                int i = cmd.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                MessageBox.Show("your account was succesfully created  ", "successfully registered ");




            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';

            }
            else
            {
                textBox2.PasswordChar = '*';
            }

        }
    }
}
