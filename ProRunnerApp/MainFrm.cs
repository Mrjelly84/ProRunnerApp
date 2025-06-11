namespace ProRunnerApp
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void btnCreateRun_Click(object sender, EventArgs e)
        {
            // displays CreateRunFrm when the button is clicked
            CreateRunFrm createRunForm = new CreateRunFrm();
            createRunForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Add logic for managing runs here
            MessageBox.Show("Manage Runs button clicked!");
        }
        private void btnManageRuns_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Manage Runs button clicked!");
        }
    }
}
