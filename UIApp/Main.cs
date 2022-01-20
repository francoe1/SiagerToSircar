using CoreApp.Helpers;
using System;
using System.Windows.Forms;

namespace UIApp
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
            DisplayProgress.Instance.Show();
            string file = null;
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Abrir Retención";
                dialog.DefaultExt = "txt";
                if (dialog.ShowDialog() == DialogResult.OK) file = dialog.FileName;
            }

            try
            {
                if (file != null)
                {
                    var convert = ConvertHelpers.Retenciones_SIAGER_SIRCAR(file);
                    MessageBox.Show($"Se procesaron {convert.Output.Length} registros");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Grave");
            }
            finally
            {
                DisplayProgress.Instance.Hide();
            }
        }

        private void OnPercepciones(object sender, EventArgs e)
        {
            DisplayProgress.Instance.Show();
            string file = null;
            using (FileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Abrir Percepción";
                dialog.DefaultExt = "txt";
                if (dialog.ShowDialog() == DialogResult.OK) file = dialog.FileName;
            }
            try
            {
                if (file != null)
                {
                    var convert = ConvertHelpers.Percepciones_SIAGER_SIRCAR(file);
                    MessageBox.Show($"Se procesaron {convert.Output.Length} registros");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Grave");
            }
            finally
            {
                DisplayProgress.Instance.Hide();
            }
        }
    }
}
