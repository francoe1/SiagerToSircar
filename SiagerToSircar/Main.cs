using System;
using System.Windows.Forms;

namespace SiagerToSircar
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            _btnPercepciones.Click += OnPercepciones;
            _btnRetenciones.Click += OnRetenciones;
        }

        private void OnRetenciones(object sender, EventArgs e)
        {
            string file = null;
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Abrir Retención";
                dialog.DefaultExt = "txt";
                if (dialog.ShowDialog() == DialogResult.OK) file = dialog.FileName;
            }

            if (file != null) Program.ConvertRetenciones(file);
        }

        private void OnPercepciones(object sender, EventArgs e)
        {
            string file = null;
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Abrir Percepción";
                dialog.DefaultExt = "txt";
                if (dialog.ShowDialog() == DialogResult.OK) file = dialog.FileName;
            }

            if (file != null) Program.ConvertPercepciones(file);
        }
    }
}
