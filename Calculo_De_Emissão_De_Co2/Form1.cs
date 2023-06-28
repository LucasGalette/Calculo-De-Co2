using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_De_Emissão_De_Co2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ValorFinal, LitrosGasolina, DensidadeGasolina, x;
            LitrosGasolina = Convert.ToDouble(txtLitrosGasolina.Text);
            DensidadeGasolina = Convert.ToDouble(txtDensidadeGasolina.Text);
            ValorFinal = LitrosGasolina * 0.82;
            ValorFinal *= DensidadeGasolina * 3.7;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i+1;
            }
            lblResultado2.Text = ValorFinal.ToString();
            lblResul.Text = "Resultado";
            progressBar1.Value = 0;
        }
    }
}
