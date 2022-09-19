using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace klasaArraylist
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            Automobil a = new Automobil(txtBoxNovi.Text);
            listaAutomobila.Add(a);
            rtb.AppendText(listaAutomobila.IndexOf(a) 
                + 1 + ". " + a.DajMarku() + "\n");
            txtBoxNovi.Enabled = false;
            btnUnesi.Enabled = false;
            txtBoxNovi.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxNovi.Enabled = false;
            btnUnesi.Enabled = false;
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            txtBoxNovi.Enabled = true;
            btnUnesi.Enabled = true;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }
    }
}
