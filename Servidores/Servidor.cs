using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Servidores
{
    public class Servidor
    {
        public static string ServidorActual()
        {
            string servidor = ".";
            string fichero = "./FicheroServidores/servidores.txt";
            string[] lineas = { };
            string[] lineasLeídas = { };
            if (!Directory.Exists("FicheroServidores"))
            {
                Directory.CreateDirectory("FicheroServidores.txt");
            }

            if (!File.Exists(fichero))
            {
                Array.Resize(ref lineas, lineas.Length + 1);
                lineas[lineas.Length - 1] = "LAPTOP-HJ21SE4T*LAPTOP-HJ21SE4";
               Array.Resize(ref lineas, lineas.Length + 1);
                lineas[lineas.Length - 1] = "\"4V-PRO-948*SQLEXPRESS";
            }
            else
            {
                lineasLeídas = File.ReadAllLines(fichero);
                // Primero analiza el fichero y lo deja con líneas válidas (
                foreach (string linea in lineasLeídas)
                {
                    List<string> datos = new List<string>(linea.Split('*'));

                    if (datos.Count == 2)
                    {
                       
                        Array.Resize(ref lineas, lineas.Length+1);
                        lineas[lineas.Length-1]=$"{datos[0]}*{datos[1]}";

                    }

                }
                if (!lineas.Contains("LAPTOP-HJ21SE4T*LAPTOP-HJ21SE4", StringComparer.OrdinalIgnoreCase)) {
                    Array.Resize(ref lineas, lineas.Length + 1);
                    lineas[lineas.Length - 1] = "LAPTOP-HJ21SE4T*LAPTOP-HJ21SE4";
                }
                if (!lineas.Contains("\"4V-PRO-948*SQLEXPRESS", StringComparer.OrdinalIgnoreCase))
                {
                    Array.Resize(ref lineas, lineas.Length + 1);
                    lineas[lineas.Length - 1] = "\"4V-PRO-948*SQLEXPRESS";
                }
                   
                File.WriteAllLines(fichero, lineas);
            } 
           

            // buscar el servidor
            foreach(string linea in lineas)
            {
                List<string> datos = new List<string>(linea.Split('*'));
                if (Environment.MachineName == datos[0])
                {
                    servidor = datos[1];
                    break;
                }
            }

            
            return servidor;
        }

       
    }
}
