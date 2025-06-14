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
        public event EventHandler? RunHistoryChanged;

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

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            PerformSearch(txtSearch.Text.Trim().ToLower());
        }

        private void txtSearch_KeyDown(object? sender, KeyEventArgs e)
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
            if (dgvResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a run to edit.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvResults.SelectedRows[0];

            // Get current values
            string oldName = selectedRow.Cells[0].Value?.ToString() ?? "";
            string oldTerrain = selectedRow.Cells[1].Value?.ToString() ?? "";
            string oldWeather = selectedRow.Cells[2].Value?.ToString() ?? "";
            string oldDistance = selectedRow.Cells[3].Value?.ToString() ?? "";
            string oldDate = selectedRow.Cells[4].Value?.ToString() ?? "";

            // Show input dialogs for editing (replace with your own edit form if available)
            string newName = Prompt.ShowDialog("Edit Name:", "Edit Run", oldName);
            if (newName == null) return;
            string newTerrain = Prompt.ShowDialog("Edit Terrain:", "Edit Run", oldTerrain);
            if (newTerrain == null) return;
            string newWeather = Prompt.ShowDialog("Edit Weather:", "Edit Run", oldWeather);
            if (newWeather == null) return;
            string newDate = Prompt.ShowDialog("Edit Date:", "Edit Run", oldDate);
            if (newDate == null) return;

            // Update DataGridView
            selectedRow.Cells[0].Value = newName;
            selectedRow.Cells[1].Value = newTerrain;
            selectedRow.Cells[2].Value = newWeather;
            selectedRow.Cells[4].Value = newDate;

            // Save all rows back to file
            string filePath = Path.Combine(Application.StartupPath, "RunHistory.txt");
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (DataGridViewRow row in dgvResults.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string[] values = new string[5];
                        for (int i = 0; i < 5; i++)
                            values[i] = row.Cells[i].Value?.ToString() ?? "";
                        writer.WriteLine(string.Join(",", values));
                    }
                }
            }

            MessageBox.Show("Run updated successfully.", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OnRunHistoryChanged();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a run to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete the selected run?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Remove selected row
                dgvResults.Rows.Remove(dgvResults.SelectedRows[0]);
                // Save remaining rows back to file
                string filePath = Path.Combine(Application.StartupPath, "RunHistory.txt");
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach (DataGridViewRow row in dgvResults.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] values = new string[5];
                            for (int i = 0; i < 5; i++)
                                values[i] = row.Cells[i].Value?.ToString() ?? "";
                            writer.WriteLine(string.Join(",", values));
                        }
                    }
                }
                MessageBox.Show("Run deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OnRunHistoryChanged();
            }
        }

        private void OnRunHistoryChanged()
        {
            RunHistoryChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
