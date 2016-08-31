namespace TreavelManagement.UI
{
    partial class Choose_Your_Tour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.tavelagencyDataSet3 = new TreavelManagement.UI.tavelagencyDataSet3();
            this.addToursTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addToursTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSet3TableAdapters.AddToursTableTableAdapter();
            this.addTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecttransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTransportCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
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
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addTourDataGridViewTextBoxColumn,
            this.addHotelDataGridViewTextBoxColumn,
            this.addHotelCostDataGridViewTextBoxColumn,
            this.addLocationDataGridViewTextBoxColumn,
            this.addDestinationDataGridViewTextBoxColumn,
            this.selecttransportDataGridViewTextBoxColumn,
            this.addTransportCostDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.addToursTableBindingSource;
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
            this.metroGrid1.Location = new System.Drawing.Point(24, 64);
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
            this.metroGrid1.Size = new System.Drawing.Size(599, 299);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.Location = new System.Drawing.Point(24, 399);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(146, 31);
            this.metroButtonBack.TabIndex = 2;
            this.metroButtonBack.Text = "Back";
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // tavelagencyDataSet3
            // 
            this.tavelagencyDataSet3.DataSetName = "tavelagencyDataSet3";
            this.tavelagencyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToursTableBindingSource
            // 
            this.addToursTableBindingSource.DataMember = "AddToursTable";
            this.addToursTableBindingSource.DataSource = this.tavelagencyDataSet3;
            // 
            // addToursTableTableAdapter
            // 
            this.addToursTableTableAdapter.ClearBeforeFill = true;
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
            this.selecttransportDataGridViewTextBoxColumn.HeaderText = "Transport Type";
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
            // Choose_Your_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 493);
            this.Controls.Add(this.metroButtonBack);
            this.Controls.Add(this.metroGrid1);
            this.Name = "Choose_Your_Tour";
            this.Text = "Choose Your Tour";
            this.Load += new System.EventHandler(this.Choose_Your_Tour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton metroButtonBack;
        private tavelagencyDataSet3 tavelagencyDataSet3;
        private System.Windows.Forms.BindingSource addToursTableBindingSource;
        private tavelagencyDataSet3TableAdapters.AddToursTableTableAdapter addToursTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecttransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTransportCostDataGridViewTextBoxColumn;
    }
}