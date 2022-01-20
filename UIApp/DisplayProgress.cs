using System.Windows.Forms;

namespace UIApp
{
    public partial class DisplayProgress : Form
    {
        public static DisplayProgress Instance { get; private set; }

        public DisplayProgress()
        {
            InitializeComponent();
            Instance = this;
            Instance.Hide();
            _progressBar.Value = 50;
        }
    }
}
