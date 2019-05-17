using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosNumeros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void bValorarNumeros_Click(object sender, EventArgs e)
        {
            /* SE VA CAPTAR LO TECLEADO POR EL USUARIO EN LAS 
             * DOS CAJAS DE TEXTO. COMPROBANDO QUE SOLO TECLEE NÚMEROS */

            bool noError1 = int.TryParse(tDato1.Text, out int valor1);
            bool noError2 = int.TryParse(tDato2.Text, out int valor2);

            if(noError1 && noError2)
            {
                if(valor1 < valor2)
                {
                    lbSalida.Items.Add(valor1 + " es MENOR que " + valor2);
                }
                else if (valor1 > valor2)
                {
                    lbSalida.Items.Add(valor1 + " es MAYOR que " + valor2);
                }
                else
                {
                    lbSalida.Items.Add(valor1 + " es IGUAL que " + valor2);
                }
            }
            else if(!noError1 && !noError2)
            {
                MessageBox.Show("EL PRIMER Y SEGUNDO DATO NO ES UN NÚMERO");
            }
            else if(!noError1)
            {
                MessageBox.Show("EL PRIMER DATO NO ES UN NÚMERO");
            }
            else if(!noError2)
            {
                MessageBox.Show("EL SEGUNDO DATO NO ES UN NÚMERO");
            }




        }
    }
}
