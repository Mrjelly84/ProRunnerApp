using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProRunnerApp
{
    public  partial class CreateRunFrm : Form
    {
        public CreateRunFrm()
        {
            InitializeComponent();
            dateTimePicker1.Visible = true;

            // Define the columns for the DataGridView
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Terrain", "Terrain");
            dataGridView1.Columns.Add("Weather", "Weather");
            dataGridView1.Columns.Add("Distance", "Distance(Meters)");
            dataGridView1.Columns.Add("Date", "Date");
            // Load existing data from the text files
            string[] files = Directory.GetFiles(Application.StartupPath, "*.txt");
            foreach (string file in files)
            {
                string filename = Path.GetFileNameWithoutExtension(file);
               
                using (StreamReader reader = File.OpenText(file))
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    dataGridView1.Rows.Add(filename, values[0], values[1], values[2], values[3]);

                    

                }

            }

        }




        private void mtxtDistance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = double.Parse(mtxtDistance.Text);
                mtxtDistance.Text = string.Format("{0:0.00}", value);
            }
            catch (FormatException)
            {
                mtxtDistance.Text = "";
            }

        }


        private void cbTerrain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbWeather_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the selected terrain and weather values
            string terrain = cbTerrain.SelectedItem.ToString();
            string weather = cbWeather.SelectedItem.ToString();

            // Get the input distance value from the masked text box
            double distance = double.Parse(mtxtDistance.Text);

            //Get Date
            string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

            // Get the filename from the text box
            string filename = txtFileName.Text;

            // Create a text file to store the data
            string filePath = Path.Combine(Application.StartupPath, $"{filename}.txt");
            using (StreamWriter writer = File.CreateText(filePath))
            {
                // Write the selected terrain, weather, and distance values to the file
                writer.WriteLine($" {terrain}, {weather},  {distance}, {date}");
            }
            // Add a row to the DataGridView with the filename and data
            dataGridView1.Rows.Add(filename, terrain, weather, distance, date.ToString());

            MessageBox.Show("Data saved successfully!");

            // Clear the text boxes and reset the comboboxes
            txtFileName.Clear();
            mtxtDistance.Clear();
            cbTerrain.SelectedIndex = -1;
            cbWeather.SelectedIndex = -1;

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
