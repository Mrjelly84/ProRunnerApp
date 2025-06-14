using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProRunnerApp;

namespace ProRunnerApp
{
    public partial class MainFrm : Form
    {
        private bool _runHistoryChanged = false;

        public MainFrm()
        {
            InitializeComponent();

            dgvRunHistory.Columns.Add("Name", "Name");
            dgvRunHistory.Columns.Add("Terrain", "Terrain");
            dgvRunHistory.Columns.Add("Weather", "Weather");
            dgvRunHistory.Columns.Add("Distance", "Distance(Meters)");
            dgvRunHistory.Columns.Add("Date", "Date");

            ReloadRunHistory();
        }

        private void btnCreateRun_Click(object sender, EventArgs e)
        {
            // Pass 'this' as the required 'mainForm' parameter
            CreateRunFrm createRunForm = new CreateRunFrm(this);
            createRunForm.ShowDialog();
        }

        private void btnManageRuns_Click(object sender, EventArgs e)
        {
            var manageRunsFrm = new ManageRunsFrm();
            manageRunsFrm.RunHistoryChanged += (s, ev) => _runHistoryChanged = true;
            _runHistoryChanged = false;
            manageRunsFrm.ShowDialog();
            if (_runHistoryChanged)
                ReloadRunHistory();
        }

        private void btnGetLocation_Click(object sender, EventArgs e)
        {
            lblCurrent.Text = "(no location logic  yet)";
        }

        private void btnOpenCreateRun_Click(object sender, EventArgs e)
        {
            var createRunFrm = new CreateRunFrm(this);
            this.Hide();
            createRunFrm.Show();
        }

        private void btnOpenManageRuns_Click(object sender, EventArgs e)
        {
            var manageRunsFrm = new ManageRunsFrm();
            manageRunsFrm.RunHistoryChanged += (s, ev) => _runHistoryChanged = true;
            _runHistoryChanged = false;
            manageRunsFrm.ShowDialog();
            if (_runHistoryChanged)
                ReloadRunHistory();
        }

        // Add this method to MainFrm to reload the DataGridView
        public void ReloadRunHistory()
        {
            dgvRunHistory.Rows.Clear();
            string filePath = Path.Combine(Application.StartupPath, "RunHistory.txt");
            if (File.Exists(filePath))
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (values.Length >= 5)
                        {
                            dgvRunHistory.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                        }
                    }
                }
            }
        }
    }
}