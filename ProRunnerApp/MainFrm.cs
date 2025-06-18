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

            // Add initialization for dgvTopScore
            dgvTopScore.Columns.Add("Name", "Name");
            dgvTopScore.Columns.Add("Terrain", "Terrain");
            dgvTopScore.Columns.Add("Weather", "Weather");
            dgvTopScore.Columns.Add("Distance", "Distance(Meters)");
            dgvTopScore.Columns.Add("Date", "Date");

            ReloadRunHistory();
            ReloadTopScores(); // <-- Add this line
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
            manageRunsFrm.RunHistoryChanged += (s, ev) =>
            {
                _runHistoryChanged = true;
                ReloadTopScores(); // Add this line to update dgvTopScore
            };
            _runHistoryChanged = false;
            manageRunsFrm.ShowDialog();
            if (_runHistoryChanged)
                ReloadRunHistory();
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
            manageRunsFrm.RunHistoryChanged += (s, ev) =>
            {
                _runHistoryChanged = true;
                ReloadTopScores(); // Add this line to update dgvTopScore
            };
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
                var runs = new List<string[]>();
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (values.Length >= 5)
                        {
                            runs.Add(values);
                        }
                    }
                }

                // Sort runs by date (newest first, index 4)
                runs.Sort((a, b) =>
                {
                    DateTime dateA, dateB;
                    DateTime.TryParse(a[4], out dateA);
                    DateTime.TryParse(b[4], out dateB);
                    return dateB.CompareTo(dateA); // Descending
                });

                foreach (var values in runs)
                {
                    dgvRunHistory.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                }
            }
        }

        public void ReloadTopScores()
        {
            dgvTopScore.Rows.Clear();
            string filePath = Path.Combine(Application.StartupPath, "RunHistory.txt");
            if (File.Exists(filePath))
            {
                var runs = new List<string[]>();
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (values.Length >= 5)
                        {
                            runs.Add(values);
                        }
                    }
                }

                // Sort runs by distance (index 3), descending (top distance first)
                runs.Sort((a, b) =>
                {
                    double distA = 0, distB = 0;
                    double.TryParse(a[3], out distA);
                    double.TryParse(b[3], out distB);
                    return distB.CompareTo(distA); // Descending
                });

                foreach (var values in runs)
                {
                    dgvTopScore.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                }
            }
        }
    }
}