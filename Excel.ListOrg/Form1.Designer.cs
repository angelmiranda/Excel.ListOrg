namespace Excel.ListOrg
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextORG = new System.Windows.Forms.TextBox();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextEnv = new System.Windows.Forms.TextBox();
            this.CheckActive = new System.Windows.Forms.CheckBox();
            this.openFileExcel = new System.Windows.Forms.OpenFileDialog();
            this.ExcelRootLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // TextORG
            // 
            this.TextORG.Location = new System.Drawing.Point(52, 12);
            this.TextORG.Margin = new System.Windows.Forms.Padding(2);
            this.TextORG.Name = "TextORG";
            this.TextORG.Size = new System.Drawing.Size(128, 20);
            this.TextORG.TabIndex = 1;
            this.TextORG.TextChanged += new System.EventHandler(this.TextVKORG_TextChanged);
            // 
            // TextDescription
            // 
            this.TextDescription.Location = new System.Drawing.Point(250, 12);
            this.TextDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(128, 20);
            this.TextDescription.TabIndex = 2;
            this.TextDescription.TextChanged += new System.EventHandler(this.TextDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id. Org";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Environment";
            // 
            // TextEnv
            // 
            this.TextEnv.Location = new System.Drawing.Point(452, 12);
            this.TextEnv.Margin = new System.Windows.Forms.Padding(2);
            this.TextEnv.Name = "TextEnv";
            this.TextEnv.Size = new System.Drawing.Size(128, 20);
            this.TextEnv.TabIndex = 5;
            this.TextEnv.TextChanged += new System.EventHandler(this.TextEnv_TextChanged);
            // 
            // CheckActive
            // 
            this.CheckActive.AutoSize = true;
            this.CheckActive.Checked = true;
            this.CheckActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckActive.Location = new System.Drawing.Point(584, 13);
            this.CheckActive.Margin = new System.Windows.Forms.Padding(2);
            this.CheckActive.Name = "CheckActive";
            this.CheckActive.Size = new System.Drawing.Size(106, 17);
            this.CheckActive.TabIndex = 7;
            this.CheckActive.Text = "Only Active orgs.";
            this.CheckActive.UseVisualStyleBackColor = true;
            this.CheckActive.CheckedChanged += new System.EventHandler(this.CheckActive_CheckedChanged);
            // 
            // openFileExcel
            // 
            this.openFileExcel.FileName = "openFileDialog1";
            // 
            // ExcelRootLink
            // 
            this.ExcelRootLink.AutoSize = true;
            this.ExcelRootLink.Location = new System.Drawing.Point(4, 15);
            this.ExcelRootLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExcelRootLink.Name = "ExcelRootLink";
            this.ExcelRootLink.Size = new System.Drawing.Size(59, 13);
            this.ExcelRootLink.TabIndex = 8;
            this.ExcelRootLink.TabStop = true;
            this.ExcelRootLink.Text = "Excel Root";
            this.ExcelRootLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExcelRootLink_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextORG);
            this.groupBox1.Controls.Add(this.CheckActive);
            this.groupBox1.Controls.Add(this.TextDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextEnv);
            this.groupBox1.Location = new System.Drawing.Point(9, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(856, 49);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExcelRootLink);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(856, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel data source";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 505);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "List Organizations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextORG;
        private System.Windows.Forms.TextBox TextDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextEnv;
        private System.Windows.Forms.CheckBox CheckActive;
        private System.Windows.Forms.OpenFileDialog openFileExcel;
        private System.Windows.Forms.LinkLabel ExcelRootLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

