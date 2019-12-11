namespace MedicalStore
{
    partial class Tests
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTestName = new System.Windows.Forms.ComboBox();
            this.cmbTestGroup = new System.Windows.Forms.ComboBox();
            this.tblGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalManagementDbDataSet7 = new MedicalStore.HospitalManagementDbDataSet7();
            this.tblGroupTableAdapter = new MedicalStore.HospitalManagementDbDataSet7TableAdapters.tblGroupTableAdapter();
            this.checkedListBoxTest = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxSelectedTests = new System.Windows.Forms.CheckedListBox();
            this.btnTests = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.testId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementDbDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Group";
            // 
            // cmbTestName
            // 
            this.cmbTestName.FormattingEnabled = true;
            this.cmbTestName.Location = new System.Drawing.Point(539, 48);
            this.cmbTestName.Name = "cmbTestName";
            this.cmbTestName.Size = new System.Drawing.Size(121, 21);
            this.cmbTestName.TabIndex = 2;
            // 
            // cmbTestGroup
            // 
            this.cmbTestGroup.DataSource = this.tblGroupBindingSource;
            this.cmbTestGroup.DisplayMember = "GroupName";
            this.cmbTestGroup.FormattingEnabled = true;
            this.cmbTestGroup.Location = new System.Drawing.Point(189, 48);
            this.cmbTestGroup.Name = "cmbTestGroup";
            this.cmbTestGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbTestGroup.TabIndex = 3;
            this.cmbTestGroup.ValueMember = "GroupId";
            this.cmbTestGroup.SelectedIndexChanged += new System.EventHandler(this.cmbTestGroup_SelectedIndexChanged);
            // 
            // tblGroupBindingSource
            // 
            this.tblGroupBindingSource.DataMember = "tblGroup";
            this.tblGroupBindingSource.DataSource = this.hospitalManagementDbDataSet7;
            // 
            // hospitalManagementDbDataSet7
            // 
            this.hospitalManagementDbDataSet7.DataSetName = "HospitalManagementDbDataSet7";
            this.hospitalManagementDbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGroupTableAdapter
            // 
            this.tblGroupTableAdapter.ClearBeforeFill = true;
            // 
            // checkedListBoxTest
            // 
            this.checkedListBoxTest.FormattingEnabled = true;
            this.checkedListBoxTest.Location = new System.Drawing.Point(54, 121);
            this.checkedListBoxTest.Name = "checkedListBoxTest";
            this.checkedListBoxTest.Size = new System.Drawing.Size(10, 244);
            this.checkedListBoxTest.TabIndex = 4;
            this.checkedListBoxTest.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTest_SelectedIndexChanged);
            // 
            // checkedListBoxSelectedTests
            // 
            this.checkedListBoxSelectedTests.FormattingEnabled = true;
            this.checkedListBoxSelectedTests.Location = new System.Drawing.Point(82, 121);
            this.checkedListBoxSelectedTests.Name = "checkedListBoxSelectedTests";
            this.checkedListBoxSelectedTests.Size = new System.Drawing.Size(10, 244);
            this.checkedListBoxSelectedTests.TabIndex = 5;
            // 
            // btnTests
            // 
            this.btnTests.Location = new System.Drawing.Point(330, 384);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(129, 32);
            this.btnTests.TabIndex = 6;
            this.btnTests.Text = "Select Tests";
            this.btnTests.UseVisualStyleBackColor = true;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.testId,
            this.TestName,
            this.price,
            this.groupId});
            this.dataGridView1.Location = new System.Drawing.Point(189, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 244);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick_1);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // testId
            // 
            this.testId.HeaderText = "testId";
            this.testId.Name = "testId";
            // 
            // TestName
            // 
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // groupId
            // 
            this.groupId.HeaderText = "group Id";
            this.groupId.Name = "groupId";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(731, 121);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(508, 244);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "testId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Test Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "group Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.checkedListBoxSelectedTests);
            this.Controls.Add(this.checkedListBoxTest);
            this.Controls.Add(this.cmbTestGroup);
            this.Controls.Add(this.cmbTestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tests";
            this.Text = "Tests";
            this.Load += new System.EventHandler(this.Tests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalManagementDbDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTestName;
        private System.Windows.Forms.ComboBox cmbTestGroup;
        private HospitalManagementDbDataSet7 hospitalManagementDbDataSet7;
        private System.Windows.Forms.BindingSource tblGroupBindingSource;
        private HospitalManagementDbDataSet7TableAdapters.tblGroupTableAdapter tblGroupTableAdapter;
        private System.Windows.Forms.CheckedListBox checkedListBoxTest;
        private System.Windows.Forms.CheckedListBox checkedListBoxSelectedTests;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn testId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupId;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}