using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerificentrosFormatos.Bussiness;
using System.Diagnostics;
using System.Configuration;

namespace VerificentrosFormatos
{
    public partial class ProcesamientoMasivo : Form
    {
        public ProcesamientoMasivo()
        {
            InitializeComponent();
        }
        private void ProcesamientoMasivo_Load(object sender, EventArgs e)
        {
            ddlTipo.DisplayMember = "valor";
            ddlTipo.ValueMember = "clave";

            ddlTipo.Items.Add(new Item() { clave = 1, valor = "Word" });
            ddlTipo.Items.Add(new Item() { clave = 2, valor = "PDF" });
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlTipo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar al menos un tipo de exportación", "Verificentros App");
                    return;
                }

                if (!chkDinamometros.Checked && !chkMicrobancas.Checked && !chkOpacimetros.Checked && !chkOpacimetros.Checked && !chkTacometros.Checked)
                {
                    MessageBox.Show("Debe seleccionar al menos un formato", "Verificentros App");
                    return;
                }

                btnProcesar.Enabled = false;
                FormatosVerificentros.GenerarFormatos(((Item)ddlTipo.SelectedItem).clave, chkDinamometros.Checked, chkMicrobancas.Checked, chkOpacimetros.Checked, chkTacometros.Checked);
                string pathPrints = ConfigurationManager.AppSettings["pathPrints"].ToString();
                Process.Start(pathPrints);
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en btnProcesar_Click() de ProcesamientoMasivo.", ex);
                MessageBox.Show("Ocurrio un error al intentar generar los formatos. Intente mas tarde.", "Verificentros App");
            }
            finally
            {
                btnProcesar.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bienvenida inicio = new Bienvenida();
            inicio.Show();
        }

        
    }
}