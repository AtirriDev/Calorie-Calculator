using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Calorias
{
    public partial class FrmCalcularCalorias : Form
    {
        Double Peso = 0;
        Double Altura = 0;
        Double Edad = 0;
        Double Mtb = 0;
        Double MtbBasal = 0;
        Double Deficit = 0;
        Double Superavit = 0;







        public FrmCalcularCalorias()
        {


            InitializeComponent();
        }

        private void FrmCalcularCalorias_Load(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtAltura.Text!=""&&txtEdad.Text!=""&& txtPeso.Text!="")
            {
                Peso = Convert.ToDouble(txtPeso.Text);
                Altura = Convert.ToDouble(txtAltura.Text);
                Edad = Convert.ToDouble(txtEdad.Text);
                if (Peso <= 45 || Altura <= 120 || Edad <= 15)
                {
                    MessageBox.Show("No se puede realizar los calculos con esos parametros","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rdbHombre.Checked)
                    {
                        MtbBasal = (10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5;
                        Mtb = (10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5;
                        Deficit = (10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5;
                        Superavit = (10 * Peso) + (6.25 * Altura) - (5 * Edad) + 5;
                    }
                    if (rdbMujer.Checked)
                    {
                        MtbBasal = (10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161;

                        Mtb = (10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161;
                        Deficit = (10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161;
                        Superavit = (10 * Peso) + (6.25 * Altura) - (5 * Edad) - 161;




                    }


                    if (rdbActividadSedentaria.Checked)
                    {
                        MtbBasal = MtbBasal * 1.2;
                        Deficit = Mtb * 1.2 - 250;
                        Superavit = Mtb * 1.2 + 500;

                    }
                    if (rdbActividadModerado.Checked)
                    {
                        MtbBasal = MtbBasal * 1.5;
                        Deficit = Mtb * 1.4 - 350;
                        Superavit = Mtb * 1.4 + 500;

                    }
                    if (rdbActividadAlta.Checked)
                    {
                        MtbBasal = MtbBasal * 1.8;
                        Deficit = Mtb * 1.8 - 500;
                        Superavit = Mtb * 1.8 + 500;
                    }





                    txtMetBasal.Text = Convert.ToString(Mtb) + " Calorias  ";

                    txtMantenimiento.Text = Convert.ToString(MtbBasal) + " Calorias  ";

                    txtSuperavit.Text = Convert.ToString(Superavit) + " Calorias  ";

                    txtDeficit.Text = Convert.ToString(Deficit) + " Calorias  ";

                    btnReset.Enabled = true;
                }
                
            }
            else
            {
                MessageBox.Show("Por favor complete los campos para poder realizar el calculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }







        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMetBasal.Text = "";

            txtMantenimiento.Text = "";

            txtSuperavit.Text = "";

            txtDeficit.Text = "";

            txtPeso.Text = "";
            txtAltura.Text = "";
            txtEdad.Text = "";

            btnReset.Enabled = false;
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    } 
        
 }

