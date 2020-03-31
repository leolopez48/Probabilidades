using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Estadistica
{
    public partial class Estadística : Form
    {
        double p = 0;
        double cantidad = 0, n = 0;

        public Estadística()
        {
            InitializeComponent();
        }

        private void Estadística_Load(object sender, EventArgs e)
        {
            habilitar(false, false);
        }

        public void habilitar(bool estado, bool datos)
        {
            txtNumFila.Enabled = datos;
            txtNumColumna.Enabled = datos;
            txtNum.Enabled = estado;
            chkFila.Enabled = estado;
            chkColumna.Enabled = estado;
            btnEvaluar.Enabled = estado;
            chkMixto.Enabled = estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            error.Clear();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if(dataGridView1.Rows.Count != 0 )
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
            }
            if (Validar())
            {

                for(int i=0; i<=int.Parse(txtColumnas.Text); i++)
                {
                    if (i == 0)
                    {
                        dataGridView1.Columns.Add(i.ToString(), "");
                    }
                    else
                    {
                        dataGridView1.Columns.Add(i.ToString(), Interaction.InputBox("Digite el nombre de la columna " + i + ":", "Columnas"));
                    }
                }
                for (int i = 0; i < int.Parse(txtFilas.Text); i++)
                {

                    dataGridView1.Rows.Insert(i, Interaction.InputBox("Digite el nombre de la fila "+(i+1)+":", "Filas"));

                }
                habilitar(true, false);
            }
        }

        public bool Validar()
        {
            bool validado = true;
            if ( Regex.IsMatch(txtFilas.Text, @"^[a-zA-Z]+$") || txtFilas.Text == "" || int.Parse(txtFilas.Text) < 0)
            {
                validado = false;
                error.SetError(txtFilas, "Este valor es requerido");
            }
            if (Regex.IsMatch(txtColumnas.Text, @"^[a-zA-Z]+$") || txtColumnas.Text == "" || int.Parse(txtColumnas.Text) < 0)
            {
                validado = false;
                error.SetError(txtColumnas, "Este valor es requerido");
            }
            return validado;
        }

        public bool ValidarEvaluar()
        {
            bool validado = true;
            if (chkMixto.Checked)
            {
                return true;
            }
            if (Regex.IsMatch(txtNum.Text, @"^[a-zA-Z]+$") || txtNum.Text == "")
            {
                validado = false;
                error.SetError(txtNum, "Este valor es requerido");
            }
            if (Regex.IsMatch(txtNumFila.Text, @"^[a-zA-Z]+$") || txtNumFila.Text == "" || int.Parse(txtNumFila.Text)<=0 || int.Parse(txtNumFila.Text) > int.Parse(txtFilas.Text))
            {
                validado = false;
                error.SetError(txtNumFila, "Este valor es requerido");
                return validado;
            }
            if (Regex.IsMatch(txtNumColumna.Text, @"^[a-zA-Z]+$") || txtNumColumna.Text == "" || int.Parse(txtNumColumna.Text) <= 0 || int.Parse(txtNumColumna.Text) > int.Parse(txtColumnas.Text))
            {
                validado = false;
                error.SetError(txtNumColumna, "Este valor es requerido");
                return validado;
            }

            for (int i = 0; i < int.Parse(txtFilas.Text); i++)
            {
                for (int j = 1; j <= int.Parse(txtColumnas.Text); j++)
                {
                    
                    if(dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        MessageBox.Show("La tabla tiene algún valor vacío");
                        validado = false;
                        
                    }
                }
            }
                return validado;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColumna.Checked)
            {
                txtNumColumna.Enabled = true;
                chkFila.Enabled = false;
                chkMixto.Enabled = false;
                txtNumFila.Text = "1";
            }
            else
            {
                txtNumFila.Text = "";
                chkFila.Enabled = true;
                txtNumColumna.Enabled = false;
                chkMixto.Enabled = true;
            }
        }

        private void chkFila_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFila.Checked)
            {
                txtNumFila.Enabled = true;
                chkMixto.Enabled = false;
                chkColumna.Enabled = false;
                txtNumColumna.Text = "1";
            }
            else
            {
                txtNumColumna.Text = "";
                txtNumFila.Enabled = false;
                chkMixto.Enabled = true;
                chkColumna.Enabled = true;
            }
        }

        private void chkMixto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMixto.Checked)
            { 
                chkFila.Enabled = false;
                chkColumna.Enabled = false;
                txtNumColumna.Text = "1";
            }
            else
            {
                chkFila.Enabled = true;
                chkColumna.Enabled = true;
            }
        }


        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            error.Clear();
            cantidad = 0;
            if (ValidarEvaluar())
            {
                if (chkMixto.Checked)
                {
                    for (int i = 0; i < int.Parse(txtFilas.Text); i++)
                    {
                        for (int j = 1; j <= int.Parse(txtColumnas.Text); j++)
                        {
                            if (int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString()) == int.Parse(txtNum.Text))
                            {
                                cantidad++;
                            }              
                        }
                    }
                    n =(int.Parse(txtColumnas.Text) * int.Parse(txtFilas.Text));
                }
                else if (chkFila.Checked)
                {
                        for (int j = 1; j <= int.Parse(txtColumnas.Text); j++)
                        {
                            if (int.Parse(dataGridView1.Rows[(int.Parse(txtNumFila.Text)-1)].Cells[j].Value.ToString()) == int.Parse(txtNum.Text))
                            {
                                cantidad++;
                            }

                    }
                    n = int.Parse(txtFilas.Text);
                }
                else
                {
                    for (int j = 0; j < int.Parse(txtColumnas.Text); j++)
                    {

                        if (int.Parse(dataGridView1.Rows[j].Cells[int.Parse(txtNumColumna.Text)].Value.ToString()) == int.Parse(txtNum.Text))
                        {
                            cantidad++;
                        }
                        MessageBox.Show("Cantidad: " + cantidad.ToString());
                    }
                    n = int.Parse(txtColumnas.Text);
                }
                MessageBox.Show("Cantidad: " + cantidad.ToString(), "Prueba");
                p = (cantidad / n);
                MessageBox.Show("Probabillidad: " + p.ToString("N2"), "Probabilidad");
            }
        }

    }
}
