namespace TreavelManagement.UI
{
    partial class AdminControl
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
            this.btnAdminAdd = new MetroFramework.Controls.MetroButton();
            this.btnAdminRefresh = new MetroFramework.Controls.MetroButton();
            this.BtnAdminDelete = new MetroFramework.Controls.MetroButton();
            this.btnAdminLogout = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnShowData = new MetroFramework.Controls.MetroButton();
            this.tavelagencyDataSet4 = new TreavelManagement.UI.tavelagencyDataSet4();
            this.addToursTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addToursTableTableAdapter = new TreavelManagement.UI.tavelagencyDataSet4TableAdapters.AddToursTableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addHotelCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDestinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selecttransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addTransportCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdminAdd
            // 
            this.btnAdminAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdminAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminAdd.DisplayFocus = true;
            this.btnAdminAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminAdd.Highlight = true;
            this.btnAdminAdd.Location = new System.Drawing.Point(539, 38);
            this.btnAdminAdd.Name = "btnAdminAdd";
            this.btnAdminAdd.Size = new System.Drawing.Size(129, 23);
            this.btnAdminAdd.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAdminAdd.TabIndex = 0;
            this.btnAdminAdd.Text = "Add";
            this.btnAdminAdd.UseCustomBackColor = true;
            this.btnAdminAdd.UseSelectable = true;
            this.btnAdminAdd.UseStyleColors = true;
            this.btnAdminAdd.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnAdminRefresh
            // 
            this.btnAdminRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdminRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminRefresh.DisplayFocus = true;
            this.btnAdminRefresh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdminRefresh.Highlight = true;
            this.btnAdminRefresh.Location = new System.Drawing.Point(540, 216);
            this.btnAdminRefresh.Name = "btnAdminRefresh";
            this.btnAdminRefresh.Size = new System.Drawing.Size(129, 27);
            this.btnAdminRefresh.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAdminRefresh.TabIndex = 6;
            this.btnAdminRefresh.Text = "Refresh";
            this.btnAdminRefresh.UseCustomBackColor = true;
            this.btnAdminRefresh.UseSelectable = true;
            this.btnAdminRefresh.UseStyleColors = true;
            this.btnAdminRefresh.Click += new System.EventHandler(this.btnAdminRefresh_Click);
            // 
            // BtnAdminDelete
            // 
            this.BtnAdminDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnAdminDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdminDelete.DisplayFocus = true;
            this.BtnAdminDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnAdminDelete.Highlight = true;
            this.BtnAdminDelete.Location = new System.Drawing.Point(680, 216);
            this.BtnAdminDelete.Name = "BtnAdminDelete";
            this.BtnAdminDelete.Size = new System.Drawing.Size(129, 27);
            this.BtnAdminDelete.Style = MetroFramework.MetroColorStyle.Black;
            this.BtnAdminDelete.TabIndex = 7;
            this.BtnAdminDelete.Text = "Delete";
            this.BtnAdminDelete.UseCustomBackColor = true;
            this.BtnAdminDelete.UseSelectable = true;
            this.BtnAdminDelete.UseStyleColors = true;
            this.BtnAdminDelete.Click += new System.EventHandler(this.BtnAdminDelete_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAdminLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogout.DisplayFocus = true;
            this.btnAdminLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAdminLogout.Highlight = true;
            this.btnAdminLogout.Location = new System.Drawing.Point(674, 38);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(129, 24);
            this.btnAdminLogout.Style = MetroFramework.MetroColorStyle.Black;
            this.btnAdminLogout.TabIndex = 8;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseCustomBackColor = true;
            this.btnAdminLogout.UseSelectable = true;
            this.btnAdminLogout.UseStyleColors = true;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.metroPanel1.BackgroundImage = global::TreavelManagement.UI.Properties.Resources.Admin_designstyle_jungle_m;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 67);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(791, 143);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addTourDataGridViewTextBoxColumn,
            this.addHotelDataGridViewTextBoxColumn,
            this.addHotelCostDataGridViewTextBoxColumn,
            this.addLocationDataGridViewTextBoxColumn,
            this.addDestinationDataGridViewTextBoxColumn,
            this.selecttransportDataGridViewTextBoxColumn,
            this.addTransportCostDataGridViewTextBoxColumn});
            this.metroGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroGrid1.DataSource = this.addToursTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 249);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(786, 290);
            this.metroGrid1.TabIndex = 9;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseStyleColors = true;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(626, 555);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(177, 23);
            this.btnShowData.TabIndex = 11;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseSelectable = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // tavelagencyDataSet4
            // 
            this.tavelagencyDataSet4.DataSetName = "tavelagencyDataSet4";
            this.tavelagencyDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addToursTableBindingSource
            // 
            this.addToursTableBindingSource.DataMember = "AddToursTable";
            this.addToursTableBindingSource.DataSource = this.tavelagencyDataSet4;
            // 
            // addToursTableTableAdapter
            // 
            this.addToursTableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addTourDataGridViewTextBoxColumn
            // 
            this.addTourDataGridViewTextBoxColumn.DataPropertyName = "AddTour";
            this.addTourDataGridViewTextBoxColumn.HeaderText = "Tour_Name";
            this.addTourDataGridViewTextBoxColumn.Name = "addTourDataGridViewTextBoxColumn";
            this.addTourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addHotelDataGridViewTextBoxColumn
            // 
            this.addHotelDataGridViewTextBoxColumn.DataPropertyName = "AddHotel";
            this.addHotelDataGridViewTextBoxColumn.HeaderText = "Hotel_name";
            this.addHotelDataGridViewTextBoxColumn.Name = "addHotelDataGridViewTextBoxColumn";
            this.addHotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addHotelCostDataGridViewTextBoxColumn
            // 
            this.addHotelCostDataGridViewTextBoxColumn.DataPropertyName = "AddHotelCost";
            this.addHotelCostDataGridViewTextBoxColumn.HeaderText = "Hotel_cost";
            this.addHotelCostDataGridViewTextBoxColumn.Name = "addHotelCostDataGridViewTextBoxColumn";
            this.addHotelCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addLocationDataGridViewTextBoxColumn
            // 
            this.addLocationDataGridViewTextBoxColumn.DataPropertyName = "AddLocation";
            this.addLocationDataGridViewTextBoxColumn.HeaderText = "Location_";
            this.addLocationDataGridViewTextBoxColumn.Name = "addLocationDataGridViewTextBoxColumn";
            this.addLocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addDestinationDataGridViewTextBoxColumn
            // 
            this.addDestinationDataGridViewTextBoxColumn.DataPropertyName = "AddDestination";
            this.addDestinationDataGridViewTextBoxColumn.HeaderText = "Destination_";
            this.addDestinationDataGridViewTextBoxColumn.Name = "addDestinationDataGridViewTextBoxColumn";
            this.addDestinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selecttransportDataGridViewTextBoxColumn
            // 
            this.selecttransportDataGridViewTextBoxColumn.DataPropertyName = "Selecttransport";
            this.selecttransportDataGridViewTextBoxColumn.HeaderText = "Select_transport";
            this.selecttransportDataGridViewTextBoxColumn.Name = "selecttransportDataGridViewTextBoxColumn";
            this.selecttransportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addTransportCostDataGridViewTextBoxColumn
            // 
            this.addTransportCostDataGridViewTextBoxColumn.DataPropertyName = "AddTransportCost";
            this.addTransportCostDataGridViewTextBoxColumn.HeaderText = "Transport_Cost";
            this.addTransportCostDataGridViewTextBoxColumn.Name = "addTransportCostDataGridViewTextBoxColumn";
            this.addTransportCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 611);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.btnAdminLogout);
            this.Controls.Add(this.BtnAdminDelete);
            this.Controls.Add(this.btnAdminRefresh);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnAdminAdd);
            this.Name = "AdminControl";
            this.Padding = new System.Windows.Forms.Padding(30, 70, 30, 30);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "AdminControl";
            this.Load += new System.EventHandler(this.AdminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tavelagencyDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addToursTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdminAdd;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnAdminRefresh;
        private MetroFramework.Controls.MetroButton BtnAdminDelete;
        private MetroFramework.Controls.MetroButton btnAdminLogout;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnShowData;
        private tavelagencyDataSet4 tavelagencyDataSet4;
        private System.Windows.Forms.BindingSource addToursTableBindingSource;
        private tavelagencyDataSet4TableAdapters.AddToursTableTableAdapter addToursTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addHotelCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDestinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selecttransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addTransportCostDataGridViewTextBoxColumn;
    }
}