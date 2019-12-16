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

        

        euromilhoes E = new euromilhoes();

        private void estrela(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Text = E.estrela(Convert.ToInt32(temp.Tag)-1);
            label63.Text = E.listaest;
        }

        private void numeros(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Text = E.numero(Convert.ToInt32(temp.Tag)-1);
            teste.Text = E.listanum;
        }

        private void Label63_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] n = E.nsorteia;
            int[] est = E.esorteia ;
            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();
            e1.Text = est[0].ToString();
            e2.Text = est[1].ToString();
        }
    }
}
