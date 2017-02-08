using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerificentrosFormatos.Data;

namespace VerificentrosFormatos
{
    public partial class NuevoVerificentro : Form
    {
        public NuevoVerificentro()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(numeroCentro.Text))
                {
                    MessageBox.Show("Proporcione el numero de centro", "Verificentros App");
                    return;
                }

                if (string.IsNullOrEmpty(razonSocial.Text))
                {
                    MessageBox.Show("Proporcione la razon social", "Verificentros App");
                    return;
                }

                if (string.IsNullOrEmpty(siglas.Text))
                {
                    MessageBox.Show("Proporcione las siglas", "Verificentros App");
                    return;
                }

                if (dgvRepresentantes.Rows.Count == 0)
                {
                    MessageBox.Show("Debe proporcionar al menos 1 Representante Legal", "Verificentros App");
                    return;
                }

                if (dgvLineas.Rows.Count == 0)
                {
                    MessageBox.Show("Debe proporcionar al menos 1 Línea", "Verificentros App");
                    return;
                }

                if (dgvGabinetes.Rows.Count == 0)
                {
                    MessageBox.Show("Debe proporcionar al menos 1 Gabinete", "Verificentros App");
                    return;
                }

                List<RepresentantesLegales> representales = new List<RepresentantesLegales>();

                foreach (DataGridViewRow rowRepresente in dgvRepresentantes.Rows)
                {
                    representales.Add(new RepresentantesLegales()
                    {
                        nombres = (string)rowRepresente.Cells[1].Value,
                        apPaterno = (string)rowRepresente.Cells[2].Value,
                        apMaterno = (string)rowRepresente.Cells[3].Value,
                        fechaAlta = DateTime.Now,
                        idUsuarioAlta = 1
                    }
                    );
                }

                System.Globalization.CultureInfo cultureinfo = new System.Globalization.CultureInfo("es-MX");

                Nullable<DateTime> fecha = null;

                List<Gabinetes> gabinetes = new List<Gabinetes>();

                foreach (DataGridViewRow rowGabinete in dgvGabinetes.Rows)
                {
                    if (rowGabinete.Cells[5].Value != null)
                        fecha = DateTime.ParseExact(rowGabinete.Cells[5].Value.ToString(), "dd/MM/yyyy", cultureinfo);
                    else
                        fecha = null;

                    gabinetes.Add(new Gabinetes()
                    {
                        marca = (string)rowGabinete.Cells[2].Value,
                        modelo = (string)rowGabinete.Cells[3].Value,
                        serie = (string)rowGabinete.Cells[4].Value,
                        fechaInstalacion = fecha,
                        fechaAlta = DateTime.Now,
                        idUsuarioAlta = 1
                    }
                    );
                }

                List<Dinamometros> dinamometros = new List<Dinamometros>();

                foreach (DataGridViewRow rowDinamometro in dgvDinamometros.Rows)
                {
                    if (rowDinamometro.Cells[5].Value != null)
                        fecha = DateTime.ParseExact(rowDinamometro.Cells[5].Value.ToString(), "dd/MM/yyyy", cultureinfo);
                    else
                        fecha = null;

                    dinamometros.Add(new Dinamometros()
                    {
                        marca = (string)rowDinamometro.Cells[2].Value,
                        modelo = (string)rowDinamometro.Cells[3].Value,
                        serie = (string)rowDinamometro.Cells[4].Value,
                        fechaInstalacion = fecha,
                        fechaAlta = DateTime.Now,
                        idUsuarioAlta = 1
                    }
                    );
                }

                List<Microbancas> microbancas = new List<Microbancas>();

                foreach (DataGridViewRow rowMicrobanca in dvgMicrobancas.Rows)
                {
                    if (rowMicrobanca.Cells[6].Value != null)
                        fecha = DateTime.ParseExact(rowMicrobanca.Cells[6].Value.ToString(), "dd/MM/yyyy", cultureinfo);
                    else
                        fecha = null;

                    microbancas.Add(new Microbancas()
                    {
                        marca = (string)rowMicrobanca.Cells[2].Value,
                        modelo = (string)rowMicrobanca.Cells[3].Value,
                        version = (string)rowMicrobanca.Cells[4].Value,
                        serie = (string)rowMicrobanca.Cells[5].Value,
                        fechaInstalacion = fecha,
                        numeroFactura = (string)rowMicrobanca.Cells[7].Value,
                        fechaAlta = DateTime.Now,
                        idUsuarioAlta = 1
                    }
                    );
                }

                List<Opacimetros> opacimetros = new List<Opacimetros>();

                foreach (DataGridViewRow rowOpacimetros in dgvOpacimetros.Rows)
                {
                    if (rowOpacimetros.Cells[5].Value != null)
                        fecha = DateTime.ParseExact(rowOpacimetros.Cells[5].Value.ToString(), "dd/MM/yyyy", cultureinfo);
                    else
                        fecha = null;

                    opacimetros.Add(new Opacimetros()
                    {
                        marca = (string)rowOpacimetros.Cells[2].Value,
                        modelo = (string)rowOpacimetros.Cells[3].Value,
                        serie = (string)rowOpacimetros.Cells[4].Value,
                        fechaInstalacion = fecha,
                        numeroFactura = (string)rowOpacimetros.Cells[6].Value,
                        fechaAlta = DateTime.Now,
                        idUsuarioAlta = 1
                    }
                    );
                }

                List<Tacometros> tacometros = new List<Tacometros>();

                foreach (DataGridViewRow rowTacometros in dgvTacometros.Rows)
                {
                    if (rowTacometros.Cells[6].Value != null)
                        fecha = DateTime.ParseExact(rowTacometros.Cells[6].Value.ToString(), "dd/MM/yyyy", cultureinfo);
                    else
                        fecha = null;

                    tacometros.Add(new Tacometros()
                    {
                        tipo = (string)rowTacometros.Cells[2].Value,
                        marca = (string)rowTacometros.Cells[3].Value,
                        modelo = (string)rowTacometros.Cells[4].Value,
                        serie = (string)rowTacometros.Cells[5].Value,
                        fechaInstalacion = fecha,
                        numeroFactura = (string)rowTacometros.Cells[7].Value,
                        fechaAlta = DateTime.Now,
                        idUsuarioAlta = 1
                    }
                    );
                }

                List<Lineas> lineas = new List<Lineas>();

                foreach (DataGridViewRow rowLinea in dgvLineas.Rows)
                {
                    lineas.Add(new Lineas()
                    {
                        numero = (string)rowLinea.Cells[1].Value,
                        combustible = (string)rowLinea.Cells[2].Value,
                        tipo = (string)rowLinea.Cells[3].Value,
                        fechaAlta = DateTime.Now,
                        idUsuarioAlta = 1,
                        Gabinetes = gabinetes,
                        Dinamometros = dinamometros,
                        Microbancas = microbancas,
                        Opacimetros = opacimetros,
                        Tacometros = tacometros
                    }
                    );
                }

                Verificentros newVerificentro = new Verificentros()
                {
                    numeroCentro = numeroCentro.Text,
                    razonSocial = razonSocial.Text,
                    siglas = siglas.Text,
                    total = string.IsNullOrEmpty(totalLineas.Text) ? 0 : int.Parse(totalLineas.Text),
                    fechaAlta = DateTime.Now,
                    idUsuarioAlta = 1,
                    RepresentantesLegales = representales,
                    Lineas = lineas
                };

                int resultado = await VerificentrosManagement.Create(newVerificentro);

                if (resultado > 0)
                {
                    MessageBox.Show("La creación del Verificentro se realizo exitosamente", "Verificentros App");
                }
                else
                {
                    MessageBox.Show("No se pudo crear el Verificentro. Intente mas tarde.", "Verificentros App");
                }

                this.Hide();
                Bienvenida inicio = new Bienvenida();
                inicio.Show();
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en btnGuardar_Click() de NuevoVerificentro.", ex);
                MessageBox.Show("Ocurrio un error al intentar crear el Verificentro. Intente mas tarde.", "Verificentros App");
                this.Hide();
                Bienvenida inicio = new Bienvenida();
                inicio.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bienvenida inicio = new Bienvenida();
            inicio.Show();
        }

        private void btnAgregarRepresentante_Click(object sender, EventArgs e)
        {
            dgvRepresentantes.Rows.Add();
        }

        private void NuevoVerificentro_Load(object sender, EventArgs e)
        {
            dgvRepresentantes.Rows.Clear();
            dgvLineas.Rows.Clear();
            dgvGabinetes.Rows.Clear();
            dgvDinamometros.Rows.Clear();
            dvgMicrobancas.Rows.Clear();
            dgvOpacimetros.Rows.Clear();
            dgvTacometros.Rows.Clear();
        }

        private void dgvRepresentantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvRepresentantes.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvLineas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvLineas.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAgregarLineas_Click(object sender, EventArgs e)
        {
            Button eliminarGabi = new Button();
            eliminarGabi.Text = "Eliminar";
            eliminarGabi.Width = 100;
            dgvLineas.Rows.Add(eliminarGabi, (dgvLineas.Rows.Count + 1).ToString(), string.Empty, string.Empty);
            totalLineas.Text = dgvLineas.Rows.Count.ToString();
        }

        private void dgvTacometros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvTacometros.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAgregarTaco_Click(object sender, EventArgs e)
        {
            Button eliminarGabi = new Button();
            eliminarGabi.Text = "Eliminar";
            eliminarGabi.Width = 100;
            dgvTacometros.Rows.Add(eliminarGabi, (dgvTacometros.Rows.Count + 1).ToString(), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        private void dgvOpacimetros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvOpacimetros.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAgregarOpa_Click(object sender, EventArgs e)
        {
            Button eliminarGabi = new Button();
            eliminarGabi.Text = "Eliminar";
            eliminarGabi.Width = 100;
            dgvOpacimetros.Rows.Add(eliminarGabi, (dgvOpacimetros.Rows.Count + 1).ToString(), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        private void btnAgregarMicro_Click(object sender, EventArgs e)
        {
            Button eliminarGabi = new Button();
            eliminarGabi.Text = "Eliminar";
            eliminarGabi.Width = 100;
            dvgMicrobancas.Rows.Add(eliminarGabi, (dvgMicrobancas.Rows.Count + 1).ToString(), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        private void dvgMicrobancas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dvgMicrobancas.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAgregarDina_Click(object sender, EventArgs e)
        {
            Button eliminarGabi = new Button();
            eliminarGabi.Text = "Eliminar";
            eliminarGabi.Width = 100;
            dgvDinamometros.Rows.Add(eliminarGabi, (dgvDinamometros.Rows.Count + 1).ToString(), string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        private void dgvDinamometros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvDinamometros.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnAgregarGabinete_Click(object sender, EventArgs e)
        {
            Button eliminarGabi = new Button();
            eliminarGabi.Text = "Eliminar";
            eliminarGabi.Width = 100;
            dgvGabinetes.Rows.Add(eliminarGabi, (dgvGabinetes.Rows.Count + 1).ToString(), string.Empty, string.Empty, string.Empty);
        }

        private void dgvGabinetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgvGabinetes.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}