using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VerificentrosFormatos.Bussiness;

namespace VerificentrosFormatos.Data
{
    public class VerificentrosManagement
    {
        public static async Task<int> Create(Verificentros verificentro)
        {
            try
            {
                using (var context = new VerificentrosDB())
                {
                    context.Verificentros.Add(verificentro);
                    return await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en Create() de VerificentrosManagement.", ex);
                throw ex;
            }
        }
        public static List<VerificentrosDTO> GetAll()
        {
            try
            {
                using (var context = new VerificentrosDB())
                {
                    var verificentros = (from v in context.Verificentros
                                         select new VerificentrosDTO()
                                         {
                                             idVerificentro = v.idVerificentro,
                                             numeroCentro = v.numeroCentro,
                                             siglas = v.siglas,
                                             razonSocial = v.razonSocial,
                                             total = v.total,
                                             fechaAlta = v.fechaAlta,
                                             idUsuarioAlta = v.idUsuarioAlta,
                                             Lineas =
                                                        (
                                                            from l in context.Lineas
                                                            where l.idVerificentro == v.idVerificentro
                                                            select new LineasDTO()
                                                            {
                                                                idLinea = l.idLinea,
                                                                idVerificentro = l.idVerificentro,
                                                                numero = l.numero,
                                                                combustible = l.combustible,
                                                                tipo    = l.tipo,
                                                                fechaAlta = l.fechaAlta,
                                                                idUsuarioAlta = l.idUsuarioAlta
                                                            }
                                                        ).ToList()
                                         }
                    ).ToList();

                    return verificentros;
                }
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en GetAll() de VerificentrosManagement.", ex);
                throw ex;
            }
        }
        public static VerificentrosDTO GetByNumero(string numeroCentro)
        {
            try
            {
                using (var context = new VerificentrosDB())
                {
                    var verificentro = (from v in context.Verificentros
                                         where v.numeroCentro == numeroCentro
                                         select new VerificentrosDTO()
                                         {
                                             idVerificentro = v.idVerificentro,
                                             numeroCentro = v.numeroCentro,
                                             siglas = v.siglas,
                                             razonSocial = v.razonSocial,
                                             total = v.total,
                                             fechaAlta = v.fechaAlta,
                                             idUsuarioAlta = v.idUsuarioAlta,
                                             Lineas =
                                                        (
                                                            from l in context.Lineas
                                                            where l.idVerificentro == v.idVerificentro
                                                            select new LineasDTO()
                                                            {
                                                                idLinea = l.idLinea,
                                                                idVerificentro = l.idVerificentro,
                                                                numero = l.numero,
                                                                combustible = l.combustible,
                                                                tipo = l.tipo,
                                                                fechaAlta = l.fechaAlta,
                                                                idUsuarioAlta = l.idUsuarioAlta
                                                            }
                                                        ).ToList()
                                         }
                    ).FirstOrDefault();

                    return verificentro;
                }
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en GetByNumero() de VerificentrosManagement.", ex);
                throw ex;
            }
        }
        public static DataTable GetReporte(string numeroCentro, string linea)
        {
            try
            {
                List<ParameterIn> parameters = new List<ParameterIn>()
                {
                    new ParameterIn() { Name = "numeroCentro", Value = numeroCentro, DBType = DbType.String },
                    new ParameterIn() { Name = "linea", Value = linea, DBType = DbType.String }
                };

                return ExecuteDataTable("SP_GetReporteByNumeroLinea", parameters.ToArray());
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en GetReporte() de VerificentrosManagement.", ex);
                throw ex;
            }
        }
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Verificentros"].ConnectionString;
        }
        private static DataTable ExecuteDataTable(string nameStoredProcedure, ParameterIn[] arrayParametersIn = null)
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(nameStoredProcedure, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (arrayParametersIn != null)
                        {
                            foreach (ParameterIn parameter in arrayParametersIn)
                            {
                                cmd.Parameters.AddWithValue(parameter.Name, parameter.Value);
                            }
                        }

                        con.Open();

                        using (var da = new SqlDataAdapter(cmd))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            da.Fill(table);
                        }
                    }

                    if (con.State != ConnectionState.Closed)
                        con.Close();
                }

                return table;
            }
            catch (Exception ex)
            {
                LogErrores.Write("Error en ExecuteDataTable() de VerificentrosManagement.", ex);
                throw (ex);
            }
        }
    }
}