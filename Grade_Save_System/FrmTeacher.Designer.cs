namespace Grade_Save_System
{
    partial class FrmTeacher
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblLeftovers = new System.Windows.Forms.Label();
            this.LblPassing = new System.Windows.Forms.Label();
            this.LblAvarage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLSTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSchoolDataSet = new Grade_Save_System.DbSchoolDataSet();
            this.tBLSTUDENTTableAdapter = new Grade_Save_System.DbSchoolDataSetTableAdapters.TBLSTUDENTTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MskNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(79, 114);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(104, 26);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(79, 85);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(104, 22);
            this.TxtSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(79, 57);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(104, 22);
            this.TxtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // MskNumber
            // 
            this.MskNumber.Location = new System.Drawing.Point(79, 27);
            this.MskNumber.Mask = "0000";
            this.MskNumber.Name = "MskNumber";
            this.MskNumber.Size = new System.Drawing.Size(104, 22);
            this.MskNumber.TabIndex = 1;
            this.MskNumber.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtExam3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.TxtExam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtExam1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(231, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exams";
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(80, 83);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(104, 22);
            this.TxtExam3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Exam3:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(80, 114);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(104, 26);
            this.BtnUpdate.TabIndex = 6;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(80, 55);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(104, 22);
            this.TxtExam2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam2:";
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(80, 27);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(104, 22);
            this.TxtExam1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Exam1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblLeftovers);
            this.groupBox3.Controls.Add(this.LblPassing);
            this.groupBox3.Controls.Add(this.LblAvarage);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(458, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 166);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // LblLeftovers
            // 
            this.LblLeftovers.AutoSize = true;
            this.LblLeftovers.Location = new System.Drawing.Point(98, 86);
            this.LblLeftovers.Name = "LblLeftovers";
            this.LblLeftovers.Size = new System.Drawing.Size(19, 15);
            this.LblLeftovers.TabIndex = 10;
            this.LblLeftovers.Text = "00";
            // 
            // LblPassing
            // 
            this.LblPassing.AutoSize = true;
            this.LblPassing.Location = new System.Drawing.Point(98, 58);
            this.LblPassing.Name = "LblPassing";
            this.LblPassing.Size = new System.Drawing.Size(19, 15);
            this.LblPassing.TabIndex = 9;
            this.LblPassing.Text = "00";
            // 
            // LblAvarage
            // 
            this.LblAvarage.AutoSize = true;
            this.LblAvarage.Location = new System.Drawing.Point(98, 32);
            this.LblAvarage.Name = "LblAvarage";
            this.LblAvarage.Size = new System.Drawing.Size(19, 15);
            this.LblAvarage.TabIndex = 8;
            this.LblAvarage.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Leftovers:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Passing:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Avarage:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(4, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(675, 189);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.sTUDENTNUMBERDataGridViewTextBoxColumn,
            this.sTUDENTNAMEDataGridViewTextBoxColumn,
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn,
            this.eXAM1DataGridViewTextBoxColumn,
            this.eXAM2DataGridViewTextBoxColumn,
            this.eXAM3DataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLSTUDENTBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // sTUDENTNUMBERDataGridViewTextBoxColumn
            // 
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "STUDENTNUMBER";
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.HeaderText = "STUDENTNUMBER";
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.Name = "sTUDENTNUMBERDataGridViewTextBoxColumn";
            // 
            // sTUDENTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTNAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTNAMEDataGridViewTextBoxColumn";
            // 
            // sTUDENTSURNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENTSURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENTSURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.Name = "sTUDENTSURNAMEDataGridViewTextBoxColumn";
            // 
            // eXAM1DataGridViewTextBoxColumn
            // 
            this.eXAM1DataGridViewTextBoxColumn.DataPropertyName = "EXAM1";
            this.eXAM1DataGridViewTextBoxColumn.HeaderText = "EXAM1";
            this.eXAM1DataGridViewTextBoxColumn.Name = "eXAM1DataGridViewTextBoxColumn";
            // 
            // eXAM2DataGridViewTextBoxColumn
            // 
            this.eXAM2DataGridViewTextBoxColumn.DataPropertyName = "EXAM2";
            this.eXAM2DataGridViewTextBoxColumn.HeaderText = "EXAM2";
            this.eXAM2DataGridViewTextBoxColumn.Name = "eXAM2DataGridViewTextBoxColumn";
            // 
            // eXAM3DataGridViewTextBoxColumn
            // 
            this.eXAM3DataGridViewTextBoxColumn.DataPropertyName = "EXAM3";
            this.eXAM3DataGridViewTextBoxColumn.HeaderText = "EXAM3";
            this.eXAM3DataGridViewTextBoxColumn.Name = "eXAM3DataGridViewTextBoxColumn";
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewCheckBoxColumn
            // 
            this.sTATUSDataGridViewCheckBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.Name = "sTATUSDataGridViewCheckBoxColumn";
            // 
            // tBLSTUDENTBindingSource
            // 
            this.tBLSTUDENTBindingSource.DataMember = "TBLSTUDENT";
            this.tBLSTUDENTBindingSource.DataSource = this.dbSchoolDataSet;
            // 
            // dbSchoolDataSet
            // 
            this.dbSchoolDataSet.DataSetName = "DbSchoolDataSet";
            this.dbSchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSTUDENTTableAdapter
            // 
            this.tBLSTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 373);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher";
            this.Load += new System.EventHandler(this.FrmTeacher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSchoolDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblLeftovers;
        private System.Windows.Forms.Label LblPassing;
        private System.Windows.Forms.Label LblAvarage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbSchoolDataSet dbSchoolDataSet;
        private System.Windows.Forms.BindingSource tBLSTUDENTBindingSource;
        private DbSchoolDataSetTableAdapters.TBLSTUDENTTableAdapter tBLSTUDENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSDataGridViewCheckBoxColumn;
    }
}