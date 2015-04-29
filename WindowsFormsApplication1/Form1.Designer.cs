namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.StudentsButton = new System.Windows.Forms.Button();
            this.ExamsButton = new System.Windows.Forms.Button();
            this.TrialsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(31, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(277, 150);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // StudentsButton
            // 
            this.StudentsButton.Location = new System.Drawing.Point(31, 168);
            this.StudentsButton.Name = "StudentsButton";
            this.StudentsButton.Size = new System.Drawing.Size(90, 23);
            this.StudentsButton.TabIndex = 5;
            this.StudentsButton.Text = "View Students";
            this.StudentsButton.Click += new System.EventHandler(this.StudentsButton_Click);
            // 
            // ExamsButton
            // 
            this.ExamsButton.Location = new System.Drawing.Point(122, 168);
            this.ExamsButton.Name = "ExamsButton";
            this.ExamsButton.Size = new System.Drawing.Size(90, 23);
            this.ExamsButton.TabIndex = 4;
            this.ExamsButton.Text = "View Exams";
            this.ExamsButton.Click += new System.EventHandler(this.ExamsButton_Click);
            // 
            // TrialsButton
            // 
            this.TrialsButton.Location = new System.Drawing.Point(218, 168);
            this.TrialsButton.Name = "TrialsButton";
            this.TrialsButton.Size = new System.Drawing.Size(90, 23);
            this.TrialsButton.TabIndex = 3;
            this.TrialsButton.Text = "View Trials";
            this.TrialsButton.UseVisualStyleBackColor = true;
            this.TrialsButton.Click += new System.EventHandler(this.TrialsButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(341, 273);
            this.Controls.Add(this.TrialsButton);
            this.Controls.Add(this.ExamsButton);
            this.Controls.Add(this.StudentsButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button StudentsButton;
        private System.Windows.Forms.Button ExamsButton;
        private System.Windows.Forms.Button TrialsButton;
    }
}

