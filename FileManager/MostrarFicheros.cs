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
    public partial class MostrarFicheros : Form
    {
        public MostrarFicheros()
        {
            InitializeComponent();
        }

        private void Procesar_Click(object sender, EventArgs e)
        {
            String rutaOrigen="";
            String rutaDestino = "";

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                rutaOrigen = folderBrowserDialog.SelectedPath;
            }

            DataTable table = new DataTable();

            table = Processor.ProcesaCarpetas(rutaOrigen);
            table.Merge(Processor.ProcesaFicheros(rutaOrigen));
 
            GridView.DataSource = table;

        }
    }
}
