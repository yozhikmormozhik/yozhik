using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yozh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       public int acount(string str)
        {
            int i = 0;
                for (int l = 0; str.Length > l; l++)
                {
                    if (str[l] == 'а') i++;
                }
            return i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = acount(textBox1.Text.ToString()).ToString();
        }
    }
}
