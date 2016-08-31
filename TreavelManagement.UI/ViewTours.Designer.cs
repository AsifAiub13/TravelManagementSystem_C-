namespace TreavelManagement.UI
{
    partial class ViewTours
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnback = new MetroFramework.Controls.MetroButton();
            this.addToursTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tavelagencyDataSet = new TreavelManagement.UI.tavelagencyDataSet();
            this.addToursTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSetTableAdapters.AddToursTableTableAdapter();
            this.metroViewToursGrid = new MetroFramework.Controls.MetroGrid();
            this.btnShowTours = new MetroFramework.Controls.MetroButton();
            this.addTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecttransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTransportCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroViewToursGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(33, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(544, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Right Now These Exciting Packages are Available!! Grab Now!!";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(23, 436);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(150, 36);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseSelectable = true;
            this.btnback.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // addToursTableBindingSource
            // 
            this.addToursTableBindingSource.DataMember = "AddToursTable";
            this.addToursTableBindingSource.DataSource = this.tavelagencyDataSet;
            // 
            // tavelagencyDataSet
            // 
            this.tavelagencyDataSet.DataSetName = "tavelagencyDataSet";
            this.tavelagencyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToursTableTableAdapter
            // 
            this.addToursTableTableAdapter.ClearBeforeFill = true;
            // 
            // metroViewToursGrid
            // 
            this.metroViewToursGrid.AllowUserToAddRows = false;
            this.metroViewToursGrid.AllowUserToDeleteRows = false;
            this.metroViewToursGrid.AllowUserToResizeRows = false;
            this.metroViewToursGrid.AutoGenerateColumns = false;
            this.metroViewToursGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroViewToursGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroViewToursGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroViewToursGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroViewToursGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroViewToursGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroViewToursGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addTourDataGridViewTextBoxColumn,
            this.addHotelDataGridViewTextBoxColumn,
            this.addHotelCostDataGridViewTextBoxColumn,
            this.addLocationDataGridViewTextBoxColumn,
            this.addDestinationDataGridViewTextBoxColumn,
            this.selecttransportDataGridViewTextBoxColumn,
            this.addTransportCostDataGridViewTextBoxColumn});
            this.metroViewToursGrid.DataSource = this.addToursTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroViewToursGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroViewToursGrid.EnableHeadersVisualStyles = false;
            this.metroViewToursGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroViewToursGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroViewToursGrid.Location = new System.Drawing.Point(33, 115);
            this.metroViewToursGrid.Name = "metroViewToursGrid";
            this.metroViewToursGrid.ReadOnly = true;
            this.metroViewToursGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroViewToursGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroViewToursGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroViewToursGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroViewToursGrid.Size = new System.Drawing.Size(685, 309);
            this.metroViewToursGrid.TabIndex = 3;
            this.metroViewToursGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroViewToursGrid_CellContentClick);
            // 
            // btnShowTours
            // 
            this.btnShowTours.Location = new System.Drawing.Point(596, 436);
            this.btnShowTours.Name = "btnShowTours";
            this.btnShowTours.Size = new System.Drawing.Size(122, 36);
            this.btnShowTours.TabIndex = 4;
            this.btnShowTours.Text = "Show Tours";
            this.btnShowTours.UseSelectable = true;
            this.btnShowTours.Click += new System.EventHandler(this.btnShowTours_Click);
            // 
            // addTourDataGridViewTextBoxColumn
            // 
            this.addTourDataGridViewTextBoxColumn.DataPropertyName = "AddTour";
            this.addTourDataGridViewTextBoxColumn.HeaderText = "Tour name";
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
            // ViewTours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 495);
            this.Controls.Add(this.btnShowTours);
            this.Controls.Add(this.metroViewToursGrid);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ViewTours";
            this.Text = "ViewTours";
            this.Load += new System.EventHandler(this.ViewTours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroViewToursGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnback;
        private tavelagencyDataSet tavelagencyDataSet;
        private System.Windows.Forms.BindingSource addToursTableBindingSource;
        private tavelagencyDataSetTableAdapters.AddToursTableTableAdapter addToursTableTableAdapter;
        private MetroFramework.Controls.MetroGrid metroViewToursGrid;
        private MetroFramework.Controls.MetroButton btnShowTours;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecttransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTransportCostDataGridViewTextBoxColumn;
    }
}