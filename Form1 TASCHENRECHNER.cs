using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            // Variablen deklariert
            double eingabe1 = Convert.ToDouble(txtEingabe.Text);
            double eingabe2 = Convert.ToDouble(txtEingabe2.text);
            double ergebnis = 0;

            // Variablen rechnen

            ergebnis = eingabe1 + eingabe2;

            //Ergebnis anzeigen

            txtAusgabe.Text = ergebnis.ToString();
        }
        
