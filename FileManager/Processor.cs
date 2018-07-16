using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManager
{
    public class Processor : Object
    {
        public Processor()
        {
        }

        public static DataTable ProcesaCarpetas (String ruta)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Nombre");
            table.Columns.Add("Atributo");
            table.Columns.Add("Extensión");
            table.Columns.Add("Fecha Creación");

            var subcarpetas = Directory.EnumerateDirectories(ruta);

            foreach (String c in subcarpetas)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(c);
                String nombreCarpeta = directoryInfo.FullName;
                DateTime fechaCreacion = directoryInfo.CreationTime;
                FileAttributes tipoFichero = directoryInfo.Attributes;
                String ext = directoryInfo.Extension;
                String[] fila = new string[4];
                fila[0] = nombreCarpeta;
                fila[1] = tipoFichero.ToString();
                fila[2] = ext;
                fila[3] = fechaCreacion.ToString();

                table.Rows.Add(fila);

            }
            return table;
        }
        public static DataTable ProcesaFicheros(String ruta)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Nombre");
            table.Columns.Add("Atributo");
            table.Columns.Add("Extensión");
            table.Columns.Add("Fecha Creación");

            var ficheros = Directory.EnumerateFiles(ruta);

            foreach (String f in ficheros)
            {
                FileInfo fileInfo = new FileInfo(f);
                String nombreFichero = fileInfo.FullName;
                DateTime fechaCreacion = fileInfo.CreationTime;
                FileAttributes tipoFichero = fileInfo.Attributes;
                String ext = fileInfo.Extension;
                String[] fila = new string[4];
                fila[0] = nombreFichero;
                fila[1] = tipoFichero.ToString();
                fila[2] = ext;
                fila[3] = fechaCreacion.ToString();

                table.Rows.Add(fila);
            }
            return table;
        }
    }
}
