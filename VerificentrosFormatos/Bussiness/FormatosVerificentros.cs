using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerificentrosFormatos.Data;
using System.Windows.Forms;
using VerificentrosFormatos.Formatos;
using VerificentrosFormatos.Bussiness;

namespace VerificentrosFormatos.Bussiness
{
    public class FormatosVerificentros
    {
        public static void GenerarFormatos(int tipo, bool dinamometros, bool microbancas, bool opacimetros, bool tacometros)
        {
            try
            {
                var verificentros = VerificentrosManagement.GetAll();

                if (verificentros.Count > 0)
                {
                    Reporting.GenerarFormatos(verificentros, tipo, dinamometros, microbancas, opacimetros, tacometros);
                    MessageBox.Show("La creación de los formatos se realizo exitosamente.", "Verificentros App");
                }
                else
                {
                    MessageBox.Show("No se encontraron registros para procesar. Intente mas tarde.", "Verificentros App");
                }
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en GenerarFormatos() de FormatosVerificentros.", ex);
                throw ex;
            }
        }
    }
}