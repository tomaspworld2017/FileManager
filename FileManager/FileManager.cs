using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class FileManager : Form
    {
        public FileManager()
        {
            InitializeComponent();
        }

        private void BuscarArchivosMenu_Click(object sender, EventArgs e)
        {
            MostrarFicheros mostrarFicheros = new MostrarFicheros();
            mostrarFicheros.MdiParent = this;
            mostrarFicheros.Show();
            
        }
    }
    }

