using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_1l
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void change(object sender, EventArgs e)
        {
            panel1.BackColor = Color.GreenYellow;
        }

        private void change2(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Gray;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Hide();
        }

        private void done(object sender, EventArgs e)
        {
            label5.Show();
        }

       
    }
}
