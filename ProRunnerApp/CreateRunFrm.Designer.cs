namespace ProRunnerApp
{
    partial class CreateRunFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRunFrm));
            panel3 = new Panel();
            picCRR = new PictureBox();
            label1 = new Label();
            picCRL = new PictureBox();
            pnlCreateRun = new Panel();
            label5 = new Label();
            txtFileName = new TextBox();
            mtxtDistance = new MaskedTextBox();
            btnSave = new Button();
            label4 = new Label();
            label3 = new Label();
            cbWeather = new ComboBox();
            lblTerrain = new Label();
            cbTerrain = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCRR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCRL).BeginInit();
            pnlCreateRun.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(picCRR);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(picCRL);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // picCRR
            // 
            picCRR.Image = Properties.Resources.Screenshot_2025_06_11_111743;
            resources.ApplyResources(picCRR, "picCRR");
            picCRR.Name = "picCRR";
            picCRR.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // picCRL
            // 
            picCRL.Image = Properties.Resources.Screenshot_2025_06_11_111743;
            resources.ApplyResources(picCRL, "picCRL");
            picCRL.Name = "picCRL";
            picCRL.TabStop = false;
            // 
            // pnlCreateRun
            // 
            resources.ApplyResources(pnlCreateRun, "pnlCreateRun");
            pnlCreateRun.BackColor = Color.LightGray;
            pnlCreateRun.Controls.Add(label5);
            pnlCreateRun.Controls.Add(txtFileName);
            pnlCreateRun.Controls.Add(mtxtDistance);
            pnlCreateRun.Controls.Add(btnSave);
            pnlCreateRun.Controls.Add(label4);
            pnlCreateRun.Controls.Add(label3);
            pnlCreateRun.Controls.Add(cbWeather);
            pnlCreateRun.Controls.Add(lblTerrain);
            pnlCreateRun.Controls.Add(cbTerrain);
            pnlCreateRun.Controls.Add(label2);
            pnlCreateRun.Name = "pnlCreateRun";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // txtFileName
            // 
            resources.ApplyResources(txtFileName, "txtFileName");
            txtFileName.Name = "txtFileName";
            // 
            // mtxtDistance
            // 
            resources.ApplyResources(mtxtDistance, "mtxtDistance");
            mtxtDistance.InsertKeyMode = InsertKeyMode.Overwrite;
            mtxtDistance.Name = "mtxtDistance";
            mtxtDistance.ValidatingType = typeof(int);
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // cbWeather
            // 
            resources.ApplyResources(cbWeather, "cbWeather");
            cbWeather.FormattingEnabled = true;
            cbWeather.Items.AddRange(new object[] { resources.GetString("cbWeather.Items"), resources.GetString("cbWeather.Items1"), resources.GetString("cbWeather.Items2"), resources.GetString("cbWeather.Items3") });
            cbWeather.Name = "cbWeather";
            cbWeather.SelectedIndexChanged += cbWeather_SelectedIndexChanged;
            // 
            // lblTerrain
            // 
            resources.ApplyResources(lblTerrain, "lblTerrain");
            lblTerrain.Name = "lblTerrain";
            // 
            // cbTerrain
            // 
            resources.ApplyResources(cbTerrain, "cbTerrain");
            cbTerrain.FormattingEnabled = true;
            cbTerrain.Items.AddRange(new object[] { resources.GetString("cbTerrain.Items"), resources.GetString("cbTerrain.Items1"), resources.GetString("cbTerrain.Items2") });
            cbTerrain.Name = "cbTerrain";
            cbTerrain.SelectedIndexChanged += cbTerrain_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(dataGridView1);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = Color.Red;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CreateRunFrm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            Controls.Add(panel1);
            Controls.Add(pnlCreateRun);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateRunFrm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCRR).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCRL).EndInit();
            pnlCreateRun.ResumeLayout(false);
            pnlCreateRun.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private PictureBox picCRR;
        private Label label1;
        private PictureBox picCRL;
        private Panel pnlCreateRun;
        private Label label2;
        private ComboBox cbTerrain;
        private Label lblTerrain;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private ComboBox cbWeather;
        private DataGridView dataGridView1;
        private Button btnSave;
        private MaskedTextBox mtxtDistance;
        private Label label5;
        private TextBox txtFileName;
    }
}