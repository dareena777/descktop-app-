﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
           

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form7().Show();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();

        }
    }
    }

