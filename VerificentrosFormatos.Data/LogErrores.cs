using System;
using System.IO;

namespace VerificentrosFormatos.Data
{
    public class LogErrores
    {
        public static void Write(string message, Exception ex)
        {
            try
            {
                string appPath = AppDomain.CurrentDomain.BaseDirectory;

                using (StreamWriter writer = new StreamWriter(appPath + "\\Errores\\LogErrores_" + DateTime.Now.ToString("dd-MM-yyyy") + ".txt", true))
                {
                    if (ex != null)
                    {
                        writer.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " | " + message + " | " + "Error: [" + ex.ToString() + "]");
                    }
                    else
                    {
                        writer.WriteLine(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " | " + message + " | ");
                    }

                    writer.WriteLine(Environment.NewLine);
                    writer.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}