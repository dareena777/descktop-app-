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
    public partial class Form9 : Form
    { 
        public Form9()
        {  
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-23IKCPM6\DAREEN;Initial Catalog=login;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();

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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" select username ,password from users where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
            con.Open();

            int i = cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("welcome ");
                new Form1().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("error ");
                new Form9().Show();
                this.Hide();

            }

            //string username, password;
            //username = textBox1.Text;
            //password = textBox2.Text;
            //try
            //{

            //    string querry = "SELECT *FROM login_new WHERE username= '"+textBox1.Text+ "' AND password = '" +textBox2.Text +  "' ";
            //    SqlDataAdapter sda = new SqlDataAdapter(  querry, con );
            //    DataTable dtable = new DataTable();
            //    sda.Fill(dtable);

            //    if (dtable.Rows.Count > 0)
            //    {
            //        username = textBox1.Text;
            //        password = textBox2.Text;


            //        new Form1().Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show(" invalid login details", "", MessageBoxButtons.OK , MessageBoxIcon.Error);
            //        textBox1.Clear();
            //        textBox2.Clear();

            //        textBox1.Focus();

            //    }




            //}

            //catch
            //{
            //   // MessageBox.Show("error ");
            //}
            //finally
            //{
            //    con.Close();
            //}
        }
    }
}
