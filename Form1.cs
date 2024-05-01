using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                ["user"] = "admin",
                ["user1"] = "admin1"
            };

            string inputLogin = textBox1.Text;
            string inputPass = textBox2.Text;

            if (dict.ContainsKey(inputLogin) && dict[inputLogin] == inputPass)
            {
                Form2 s = new Form2();
                s.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
