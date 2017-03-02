using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;
using VerificentrosFormatos.Data;
using VerificentrosFormatos.Bussiness;

namespace VerificentrosFormatos.Formatos
{
    public class Reporting
    {
        public static void GenerarFormatos(List<VerificentrosDTO> verificentros, int tipo, bool dinamometros, bool microbancas, bool opacimetros, bool tacometros)
        {
            try
            {
                string pathReports = ConfigurationManager.AppSettings["pathReports"].ToString();
                string pathPrints = ConfigurationManager.AppSettings["pathPrints"].ToString();

                foreach (VerificentrosDTO v in verificentros)
                {
                    foreach (LineasDTO l in v.Lineas)
                    {
                        DataTable dtReporte = VerificentrosManagement.GetReporte(v.numeroCentro, l.numero);

                        if (dtReporte.Rows.Count > 1)
                        {
                            foreach (DataRow row in dtReporte.Rows)
                            {
                                DataTable dtLinea = dtReporte.Copy();
                                dtLinea.Clear();
                                dtLinea.ImportRow(row);

                                ReportDataSource dataSource = new ReportDataSource("dsReportes", dtLinea);

                                if (dinamometros)
                                {
                                    GenerateReport("dinamometro.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                                }
                                if (microbancas)
                                {
                                    GenerateReport("microbancas.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                                }
                                if (opacimetros)
                                {
                                    GenerateReport("opacimetros.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                                }
                                if (tacometros)
                                {
                                    GenerateReport("tacometros.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                                }
                            }
                           
                        }
                        else
                        {
                            ReportDataSource dataSource = new ReportDataSource("dsReportes", dtReporte);

                            if (dinamometros)
                            {
                                GenerateReport("dinamometro.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                            }
                            if (microbancas)
                            {
                                GenerateReport("microbancas.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                            }
                            if (opacimetros)
                            {
                                GenerateReport("opacimetros.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                            }
                            if (tacometros)
                            {
                                GenerateReport("tacometros.rdlc", dataSource, pathReports, pathPrints, v.numeroCentro, v.siglas, l.numero, tipo, dinamometros, microbancas, opacimetros, tacometros);
                            }
                        }

                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el proceso de impresión de formatos. Intente mas tarde.", "Verificentros App");
                throw ex;
            }
        }
        private static void GenerateReport(string nameRTP, ReportDataSource dataSource, string pathReports, string pathPrints, string numeroCentro, string siglas, int linea, int tipo, bool dinamometros, bool microbancas, bool opacimetros, bool tacometros)
        {
            Warning[] warnings;
            string[] streamids;
            ReportViewer ReportViewer1 = new ReportViewer();

            try
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.Dispose();
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.ReportPath = pathReports + nameRTP;

                ReportViewer1.LocalReport.DataSources.Add(dataSource);
                ReportViewer1.LocalReport.Refresh();

                string mimeType = string.Empty;
                string encoding = string.Empty;
                string ext = string.Empty;
                string format = string.Empty;

                string fileName = string.Empty;
                string prefix = string.Empty;

                switch (nameRTP)
                {
                    case "dinamometro.rdlc":
                        prefix = "Dinamometro_";
                        break;
                    case "microbancas.rdlc":
                        prefix = "Microbanca_";
                        break;
                    case "opacimetros.rdlc":
                        prefix = "Opacimetros_";
                        break;
                    case "tacometros.rdlc":
                        prefix = "Tacometro_";
                        break;
                }

                // Word, PDF, Excel and Image.
                if (tipo == 1)
                {
                    byte[] bytes = ReportViewer1.LocalReport.Render("Word", null, out mimeType, out encoding, out ext, out streamids, out warnings);

                    fileName = fileName = pathPrints + prefix + siglas + numeroCentro + "_" + linea + "_" + Guid.NewGuid().ToString() + ".doc";

                    using (FileStream fs = File.Create(fileName))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Flush();
                        fs.Close();
                    }

                    bytes = null;
                }
                else
                {
                    byte[] bytes = ReportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out ext, out streamids, out warnings);

                    fileName = fileName = pathPrints + prefix + siglas + numeroCentro + "_" + linea + "_" + Guid.NewGuid().ToString() + ".pdf";

                    using (FileStream fs = File.Create(fileName))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Flush();
                        fs.Close();
                    }

                    bytes = null;
                }
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en GenerateReport() de Reporting.", ex);
                throw ex;
            }
            finally
            {
                warnings = null;
                streamids = null;
                ReportViewer1.Dispose();
                GC.Collect();
            }
        }
    }
}