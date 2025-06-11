namespace ProRunnerApp
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            panel1 = new Panel();
            lblCurrent = new Label();
            label4 = new Label();
            btnManageRuns = new Button();
            btnGetLocation = new Button();
            btnCreateRun = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            dgvRunHistory = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRunHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(lblCurrent);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnManageRuns);
            panel1.Controls.Add(btnGetLocation);
            panel1.Controls.Add(btnCreateRun);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // lblCurrent
            // 
            resources.ApplyResources(lblCurrent, "lblCurrent");
            lblCurrent.Name = "lblCurrent";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // btnManageRuns
            // 
            resources.ApplyResources(btnManageRuns, "btnManageRuns");
            btnManageRuns.Name = "btnManageRuns";
            btnManageRuns.UseVisualStyleBackColor = true;
            btnManageRuns.Click += btnManageRuns_Click;
            // 
            // btnGetLocation
            // 
            resources.ApplyResources(btnGetLocation, "btnGetLocation");
            btnGetLocation.Name = "btnGetLocation";
            btnGetLocation.UseVisualStyleBackColor = true;
            btnGetLocation.Click += btnGetLocation_Click;
            // 
            // btnCreateRun
            // 
            resources.ApplyResources(btnCreateRun, "btnCreateRun");
            btnCreateRun.Name = "btnCreateRun";
            btnCreateRun.UseVisualStyleBackColor = true;
            btnCreateRun.Click += btnCreateRun_Click;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label3);
            panel2.Name = "panel2";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2025_06_11_111743;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_06_11_111743;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(dgvRunHistory);
            panel4.Controls.Add(label2);
            panel4.Name = "panel4";
            // 
            // dgvRunHistory
            // 
            dgvRunHistory.AllowUserToAddRows = false;
            dgvRunHistory.AllowUserToDeleteRows = false;
            dgvRunHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRunHistory.BackgroundColor = Color.LightGray;
            dgvRunHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgvRunHistory, "dgvRunHistory");
            dgvRunHistory.Name = "dgvRunHistory";
            dgvRunHistory.ReadOnly = true;
            dgvRunHistory.ShowCellToolTips = false;
            dgvRunHistory.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // MainFrm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MainFrm";
            ShowIcon = false;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRunHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnGetLocation;
        private Button btnCreateRun;
        private Panel panel4;
        private Button btnManageRuns;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCurrent;
        private DataGridView dataGridView1;
        private DataGridView dgvRunHistory;
    }
}
