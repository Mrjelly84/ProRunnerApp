using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProRunnerApp
{
    public partial class ManageRunsFrm : Form
    {
        public ManageRunsFrm()
        {
            InitializeComponent();

            dgvResults.Columns.Add("Name", "Name");
            dgvResults.Columns.Add("Terrain", "Terrain");
            dgvResults.Columns.Add("Weather", "Weather");
            dgvResults.Columns.Add("Distance", "Distance(Meters)");
            dgvResults.Columns.Add("Date", "Date");

            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;

            ReloadRunHistory();
        }

        public void ReloadRunHistory()
        {
            dgvResults.Rows.Clear();
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
                            dgvResults.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                        }
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch(txtSearch.Text.Trim().ToLower());
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch(txtSearch.Text.Trim().ToLower());
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch(txtSearch.Text.Trim().ToLower());
        }

        private void PerformSearch(string searchTerm)
        {
            dgvResults.Rows.Clear();
            if (string.IsNullOrEmpty(searchTerm))
            {
                ReloadRunHistory();
                return;
            }
            string filePath = Path.Combine(Application.StartupPath, "RunHistory.txt");
            if (File.Exists(filePath))
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        if (values.Length >= 5 && values[0].ToLower().Contains(searchTerm))
                        {
                            dgvResults.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
