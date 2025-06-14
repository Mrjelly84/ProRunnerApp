namespace ProRunnerApp
{
    public partial class CreateRunFrm : Form
    {
        private Form _mainForm;

        public CreateRunFrm(Form mainForm)
        {
            _mainForm = mainForm;
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
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        // Ensure there are at least 5 values (Name, Terrain, Weather, Distance, Date)
                        if (values.Length >= 5)
                        {
                            dataGridView1.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                        }
                    }
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (_mainForm is MainFrm mainFrm)
            {
                mainFrm.ReloadRunHistory();
                mainFrm.Show();
            }
            else
            {
                _mainForm?.Show();
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
            // Validate fields are filled in
            if (string.IsNullOrWhiteSpace(txtFileName.Text) || cbTerrain.SelectedIndex == -1 || cbWeather.SelectedIndex == -1 || string.IsNullOrWhiteSpace(mtxtDistance.Text))
            {
                MessageBox.Show("Please fill in all fields before saving.");
                return;
            }

            // Get the selected terrain and weather values
            string terrain = cbTerrain.SelectedItem.ToString();
            string weather = cbWeather.SelectedItem.ToString();

            // Get the input distance value from the masked text box
            double distance = double.Parse(mtxtDistance.Text);

            // Get Date
            string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");

            // Get the person's name from the text box
            string name = txtFileName.Text.Trim();

            // Create or append to the person's text file
            string filePath = Path.Combine(Application.StartupPath, $"{name}.txt");
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                // Write the run data as a new line
                writer.WriteLine($"{name},{terrain},{weather},{distance},{date}");
            }

            // Add a row to the DataGridView with the data
            dataGridView1.Rows.Add(name, terrain, weather, distance, date);

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
