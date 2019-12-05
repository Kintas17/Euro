using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int nestrela = 0, nnumeros = 0;        
        
        

        

        private void estrela(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Text == "X")
            {
                temp.Text = "";
                nestrela--;
            }
            else if (nestrela<2)
            {
                temp.Text = "X";
                nestrela++;
            }
            teste.Text = temp.Tag.ToString();
        }

        private void numeros(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Text == "X")
            {
                temp.Text = "";
                nnumeros--;
            }
            else if (nnumeros < 5)
            {
                temp.Text = "X";
                nnumeros++;7
            }
            teste.Text = temp.Tag.ToString();
        }

        private void Label63_Click(object sender, EventArgs e)
        {

        }
    }
}
