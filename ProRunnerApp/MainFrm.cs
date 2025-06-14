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
        public MainFrm()
        {
            InitializeComponent();

            dgvRunHistory.Columns.Add("Name", "Name");
            dgvRunHistory.Columns.Add("Terrain", "Terrain");
            dgvRunHistory.Columns.Add("Weather", "Weather");
            dgvRunHistory.Columns.Add("Distance", "Distance(Meters)");
            dgvRunHistory.Columns.Add("Date", "Date");

            string[] files = Directory.GetFiles(Application.StartupPath, "*.txt");
            foreach (string file in files)
            {
                string filename = Path.GetFileNameWithoutExtension(file);

                using (StreamReader reader = File.OpenText(file))
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    dgvRunHistory.Rows.Add(filename, values[0], values[1], values[2], values[3]);
                }
            }
        }

        private void btnCreateRun_Click(object sender, EventArgs e)
        {
            // Pass 'this' as the required 'mainForm' parameter
            CreateRunFrm createRunForm = new CreateRunFrm(this);
            createRunForm.ShowDialog();
        }

        private void btnManageRuns_Click(object sender, EventArgs e)
        {
            // displays ManageRunsFms
            ManageRunsFrm manageRunsForm = new ManageRunsFrm();
            manageRunsForm.ShowDialog();
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

        // Add this method to MainFrm to reload the DataGridView
        public void ReloadRunHistory()
        {
            dgvRunHistory.Rows.Clear();
            string[] files = Directory.GetFiles(Application.StartupPath, "*.txt");
            foreach (string file in files)
            {
                using (StreamReader reader = File.OpenText(file))
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