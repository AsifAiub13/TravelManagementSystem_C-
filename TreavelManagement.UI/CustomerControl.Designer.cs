namespace TreavelManagement.UI
{
    partial class CustomerControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncustLogout = new MetroFramework.Controls.MetroButton();
            this.metroGridShowTours = new MetroFramework.Controls.MetroGrid();
            this.btnShowTours = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.custregTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tavelagencyDataSet1 = new TreavelManagement.UI.tavelagencyDataSet1();
            this.custregTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSet1TableAdapters.custregTableTableAdapter();
            this.metrotxtBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.addToursTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tavelagencyDataSet2 = new TreavelManagement.UI.tavelagencyDataSet2();
            this.addToursTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSet2TableAdapters.AddToursTableTableAdapter();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.metroButtonConfirm = new MetroFramework.Controls.MetroButton();
            this.metroButtonShowTours = new MetroFramework.Controls.MetroButton();
            this.addTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecttransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTransportCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridShowTours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custregTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // btncustLogout
            // 
            this.btncustLogout.Location = new System.Drawing.Point(751, 32);
            this.btncustLogout.Name = "btncustLogout";
            this.btncustLogout.Size = new System.Drawing.Size(98, 34);
            this.btncustLogout.TabIndex = 2;
            this.btncustLogout.Text = "Logout";
            this.btncustLogout.UseSelectable = true;
            this.btncustLogout.Click += new System.EventHandler(this.btncustLogout_Click);
            // 
            // metroGridShowTours
            // 
            this.metroGridShowTours.AllowUserToAddRows = false;
            this.metroGridShowTours.AllowUserToDeleteRows = false;
            this.metroGridShowTours.AllowUserToResizeRows = false;
            this.metroGridShowTours.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridShowTours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridShowTours.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridShowTours.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridShowTours.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridShowTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridShowTours.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridShowTours.EnableHeadersVisualStyles = false;
            this.metroGridShowTours.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridShowTours.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridShowTours.Location = new System.Drawing.Point(435, 479);
            this.metroGridShowTours.Name = "metroGridShowTours";
            this.metroGridShowTours.ReadOnly = true;
            this.metroGridShowTours.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridShowTours.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridShowTours.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridShowTours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridShowTours.Size = new System.Drawing.Size(391, 205);
            this.metroGridShowTours.TabIndex = 6;
            this.metroGridShowTours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridShowTours_CellContentClick);
            // 
            // btnShowTours
            // 
            this.btnShowTours.Location = new System.Drawing.Point(593, 32);
            this.btnShowTours.Name = "btnShowTours";
            this.btnShowTours.Size = new System.Drawing.Size(137, 34);
            this.btnShowTours.TabIndex = 7;
            this.btnShowTours.Text = "Show Tours";
            this.btnShowTours.UseSelectable = true;
            this.btnShowTours.Click += new System.EventHandler(this.btnShowTours_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(709, 217);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 34);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Show Details";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(15, 156);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(827, 55);
            this.metroGrid1.TabIndex = 10;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // custregTableBindingSource
            // 
            this.custregTableBindingSource.DataMember = "custregTable";
            this.custregTableBindingSource.DataSource = this.tavelagencyDataSet1;
            // 
            // tavelagencyDataSet1
            // 
            this.tavelagencyDataSet1.DataSetName = "tavelagencyDataSet1";
            this.tavelagencyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // custregTableTableAdapter
            // 
            this.custregTableTableAdapter.ClearBeforeFill = true;
            // 
            // metrotxtBox
            // 
            // 
            // 
            // 
            this.metrotxtBox.CustomButton.Image = null;
            this.metrotxtBox.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.metrotxtBox.CustomButton.Name = "";
            this.metrotxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metrotxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metrotxtBox.CustomButton.TabIndex = 1;
            this.metrotxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metrotxtBox.CustomButton.UseSelectable = true;
            this.metrotxtBox.CustomButton.Visible = false;
            this.metrotxtBox.Lines = new string[0];
            this.metrotxtBox.Location = new System.Drawing.Point(175, 87);
            this.metrotxtBox.MaxLength = 32767;
            this.metrotxtBox.Name = "metrotxtBox";
            this.metrotxtBox.PasswordChar = '\0';
            this.metrotxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metrotxtBox.SelectedText = "";
            this.metrotxtBox.SelectionLength = 0;
            this.metrotxtBox.SelectionStart = 0;
            this.metrotxtBox.Size = new System.Drawing.Size(153, 23);
            this.metrotxtBox.TabIndex = 12;
            this.metrotxtBox.UseSelectable = true;
            this.metrotxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metrotxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metrotxtBox.Click += new System.EventHandler(this.metrotxtBox_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Enter your UserName";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(105, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Red;
            this.metroLabel3.Location = new System.Drawing.Point(23, 65);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(327, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "For Security Please enter Username, Password again";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(176, 116);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox1.TabIndex = 15;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.addToursTableBindingSource;
            this.metroComboBox1.DisplayMember = "AddTour";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(34, 257);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(193, 29);
            this.metroComboBox1.TabIndex = 17;
            this.metroComboBox1.UseSelectable = true;
            // 
            // addToursTableBindingSource
            // 
            this.addToursTableBindingSource.DataMember = "AddToursTable";
            this.addToursTableBindingSource.DataSource = this.tavelagencyDataSet2;
            // 
            // tavelagencyDataSet2
            // 
            this.tavelagencyDataSet2.DataSetName = "tavelagencyDataSet2";
            this.tavelagencyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToursTableTableAdapter
            // 
            this.addToursTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToAddRows = false;
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addTourDataGridViewTextBoxColumn,
            this.addHotelDataGridViewTextBoxColumn,
            this.addHotelCostDataGridViewTextBoxColumn,
            this.addLocationDataGridViewTextBoxColumn,
            this.addDestinationDataGridViewTextBoxColumn,
            this.selecttransportDataGridViewTextBoxColumn,
            this.addTransportCostDataGridViewTextBoxColumn});
            this.metroGrid2.DataSource = this.addToursTableBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(23, 297);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.ReadOnly = true;
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(819, 77);
            this.metroGrid2.TabIndex = 18;
            // 
            // metroButtonConfirm
            // 
            this.metroButtonConfirm.Location = new System.Drawing.Point(721, 384);
            this.metroButtonConfirm.Name = "metroButtonConfirm";
            this.metroButtonConfirm.Size = new System.Drawing.Size(121, 34);
            this.metroButtonConfirm.TabIndex = 19;
            this.metroButtonConfirm.Text = "Confirm";
            this.metroButtonConfirm.UseSelectable = true;
            this.metroButtonConfirm.Click += new System.EventHandler(this.metroButtonConfirm_Click);
            // 
            // metroButtonShowTours
            // 
            this.metroButtonShowTours.Location = new System.Drawing.Point(257, 257);
            this.metroButtonShowTours.Name = "metroButtonShowTours";
            this.metroButtonShowTours.Size = new System.Drawing.Size(121, 34);
            this.metroButtonShowTours.TabIndex = 20;
            this.metroButtonShowTours.Text = "Show Tours";
            this.metroButtonShowTours.UseSelectable = true;
            this.metroButtonShowTours.Click += new System.EventHandler(this.metroButtonShowTours_Click);
            // 
            // addTourDataGridViewTextBoxColumn
            // 
            this.addTourDataGridViewTextBoxColumn.DataPropertyName = "AddTour";
            this.addTourDataGridViewTextBoxColumn.HeaderText = "Tour Name";
            this.addTourDataGridViewTextBoxColumn.Name = "addTourDataGridViewTextBoxColumn";
            this.addTourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addHotelDataGridViewTextBoxColumn
            // 
            this.addHotelDataGridViewTextBoxColumn.DataPropertyName = "AddHotel";
            this.addHotelDataGridViewTextBoxColumn.HeaderText = "Hotel Name";
            this.addHotelDataGridViewTextBoxColumn.Name = "addHotelDataGridViewTextBoxColumn";
            this.addHotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addHotelCostDataGridViewTextBoxColumn
            // 
            this.addHotelCostDataGridViewTextBoxColumn.DataPropertyName = "AddHotelCost";
            this.addHotelCostDataGridViewTextBoxColumn.HeaderText = "Hotel Cost";
            this.addHotelCostDataGridViewTextBoxColumn.Name = "addHotelCostDataGridViewTextBoxColumn";
            this.addHotelCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addLocationDataGridViewTextBoxColumn
            // 
            this.addLocationDataGridViewTextBoxColumn.DataPropertyName = "AddLocation";
            this.addLocationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.addLocationDataGridViewTextBoxColumn.Name = "addLocationDataGridViewTextBoxColumn";
            this.addLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addDestinationDataGridViewTextBoxColumn
            // 
            this.addDestinationDataGridViewTextBoxColumn.DataPropertyName = "AddDestination";
            this.addDestinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.addDestinationDataGridViewTextBoxColumn.Name = "addDestinationDataGridViewTextBoxColumn";
            this.addDestinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selecttransportDataGridViewTextBoxColumn
            // 
            this.selecttransportDataGridViewTextBoxColumn.DataPropertyName = "Selecttransport";
            this.selecttransportDataGridViewTextBoxColumn.HeaderText = "Transport";
            this.selecttransportDataGridViewTextBoxColumn.Name = "selecttransportDataGridViewTextBoxColumn";
            this.selecttransportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addTransportCostDataGridViewTextBoxColumn
            // 
            this.addTransportCostDataGridViewTextBoxColumn.DataPropertyName = "AddTransportCost";
            this.addTransportCostDataGridViewTextBoxColumn.HeaderText = "Transport Cost";
            this.addTransportCostDataGridViewTextBoxColumn.Name = "addTransportCostDataGridViewTextBoxColumn";
            this.addTransportCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 464);
            this.Controls.Add(this.metroButtonShowTours);
            this.Controls.Add(this.metroButtonConfirm);
            this.Controls.Add(this.metroGrid2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metrotxtBox);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnShowTours);
            this.Controls.Add(this.metroGridShowTours);
            this.Controls.Add(this.btncustLogout);
            this.Name = "CustomerControl";
            this.Text = "CustomerControl";
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridShowTours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custregTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btncustLogout;
        private MetroFramework.Controls.MetroGrid metroGridShowTours;
        private MetroFramework.Controls.MetroButton btnShowTours;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private tavelagencyDataSet1 tavelagencyDataSet1;
        private System.Windows.Forms.BindingSource custregTableBindingSource;
        private tavelagencyDataSet1TableAdapters.custregTableTableAdapter custregTableTableAdapter;
        private MetroFramework.Controls.MetroTextBox metrotxtBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private tavelagencyDataSet2 tavelagencyDataSet2;
        private System.Windows.Forms.BindingSource addToursTableBindingSource;
        private tavelagencyDataSet2TableAdapters.AddToursTableTableAdapter addToursTableTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private MetroFramework.Controls.MetroButton metroButtonConfirm;
        private MetroFramework.Controls.MetroButton metroButtonShowTours;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecttransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTransportCostDataGridViewTextBoxColumn;
    }
}