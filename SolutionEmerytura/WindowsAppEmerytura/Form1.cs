using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppEmerytura
{
    public partial class Form1 : Form
    {
        const int wiekEmerytalny = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string imie = textBoxImie.Text;
            int wiek = int.Parse( textBoxWiek.Text );
            if (wiek < wiekEmerytalny)
                labelWynik.Text = $"Zostało Ci do emerytury {wiekEmerytalny - wiek} lat";
            else
                labelWynik.Text = "Jesteś emerytem :) ";
        }
    }
}
