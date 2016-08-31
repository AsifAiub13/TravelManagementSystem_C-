namespace TreavelManagement.UI
{
    partial class btnLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnLogIn));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtLoginUserName = new MetroFramework.Controls.MetroTextBox();
            this.btnmainlogin = new MetroFramework.Controls.MetroButton();
            this.txtLogInPassword = new MetroFramework.Controls.MetroTextBox();
            this.rbtnAdmin = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnCustomer = new MetroFramework.Controls.MetroRadioButton();
            this.btnlogBack = new MetroFramework.Controls.MetroButton();
            this.lablelogin = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(411, 179);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "UserName";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(411, 235);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtLoginUserName.CustomButton.Image = null;
            this.txtLoginUserName.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtLoginUserName.CustomButton.Name = "";
            this.txtLoginUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLoginUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginUserName.CustomButton.TabIndex = 1;
            this.txtLoginUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginUserName.CustomButton.UseSelectable = true;
            this.txtLoginUserName.CustomButton.Visible = false;
            this.txtLoginUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLoginUserName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLoginUserName.Lines = new string[0];
            this.txtLoginUserName.Location = new System.Drawing.Point(496, 179);
            this.txtLoginUserName.MaxLength = 32767;
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.PasswordChar = '\0';
            this.txtLoginUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginUserName.SelectedText = "";
            this.txtLoginUserName.SelectionLength = 0;
            this.txtLoginUserName.SelectionStart = 0;
            this.txtLoginUserName.Size = new System.Drawing.Size(198, 23);
            this.txtLoginUserName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginUserName.TabIndex = 2;
            this.txtLoginUserName.UseCustomBackColor = true;
            this.txtLoginUserName.UseCustomForeColor = true;
            this.txtLoginUserName.UseSelectable = true;
            this.txtLoginUserName.UseStyleColors = true;
            this.txtLoginUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoginUserName.Click += new System.EventHandler(this.txtLoginUserName_Click);
            // 
            // btnmainlogin
            // 
            this.btnmainlogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnmainlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmainlogin.DisplayFocus = true;
            this.btnmainlogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnmainlogin.ForeColor = System.Drawing.Color.Black;
            this.btnmainlogin.Highlight = true;
            this.btnmainlogin.Location = new System.Drawing.Point(520, 330);
            this.btnmainlogin.Name = "btnmainlogin";
            this.btnmainlogin.Size = new System.Drawing.Size(174, 37);
            this.btnmainlogin.Style = MetroFramework.MetroColorStyle.Black;
            this.btnmainlogin.TabIndex = 4;
            this.btnmainlogin.Text = "Login";
            this.btnmainlogin.UseCustomBackColor = true;
            this.btnmainlogin.UseCustomForeColor = true;
            this.btnmainlogin.UseSelectable = true;
            this.btnmainlogin.UseStyleColors = true;
            this.btnmainlogin.Click += new System.EventHandler(this.btnmainlogin_Click);
            // 
            // txtLogInPassword
            // 
            this.txtLogInPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtLogInPassword.CustomButton.Image = null;
            this.txtLogInPassword.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.txtLogInPassword.CustomButton.Name = "";
            this.txtLogInPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogInPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogInPassword.CustomButton.TabIndex = 1;
            this.txtLogInPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogInPassword.CustomButton.UseSelectable = true;
            this.txtLogInPassword.CustomButton.Visible = false;
            this.txtLogInPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLogInPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtLogInPassword.Lines = new string[0];
            this.txtLogInPassword.Location = new System.Drawing.Point(496, 235);
            this.txtLogInPassword.MaxLength = 32767;
            this.txtLogInPassword.Name = "txtLogInPassword";
            this.txtLogInPassword.PasswordChar = '\0';
            this.txtLogInPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogInPassword.SelectedText = "";
            this.txtLogInPassword.SelectionLength = 0;
            this.txtLogInPassword.SelectionStart = 0;
            this.txtLogInPassword.Size = new System.Drawing.Size(198, 23);
            this.txtLogInPassword.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogInPassword.TabIndex = 5;
            this.txtLogInPassword.UseCustomBackColor = true;
            this.txtLogInPassword.UseCustomForeColor = true;
            this.txtLogInPassword.UseSelectable = true;
            this.txtLogInPassword.UseStyleColors = true;
            this.txtLogInPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogInPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogInPassword.Click += new System.EventHandler(this.txtLogInPassword_Click);
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(455, 100);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(59, 15);
            this.rbtnAdmin.TabIndex = 7;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseSelectable = true;
            this.rbtnAdmin.CheckedChanged += new System.EventHandler(this.rbtnAdmin_CheckedChanged);
            // 
            // rbtnCustomer
            // 
            this.rbtnCustomer.AutoSize = true;
            this.rbtnCustomer.Location = new System.Drawing.Point(558, 100);
            this.rbtnCustomer.Name = "rbtnCustomer";
            this.rbtnCustomer.Size = new System.Drawing.Size(75, 15);
            this.rbtnCustomer.TabIndex = 8;
            this.rbtnCustomer.Text = "Customer";
            this.rbtnCustomer.UseSelectable = true;
            this.rbtnCustomer.CheckedChanged += new System.EventHandler(this.rbtnCustomer_CheckedChanged);
            // 
            // btnlogBack
            // 
            this.btnlogBack.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnlogBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogBack.DisplayFocus = true;
            this.btnlogBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnlogBack.Highlight = true;
            this.btnlogBack.Location = new System.Drawing.Point(520, 386);
            this.btnlogBack.Name = "btnlogBack";
            this.btnlogBack.Size = new System.Drawing.Size(174, 39);
            this.btnlogBack.Style = MetroFramework.MetroColorStyle.Black;
            this.btnlogBack.TabIndex = 9;
            this.btnlogBack.Text = "Back";
            this.btnlogBack.UseCustomBackColor = true;
            this.btnlogBack.UseCustomForeColor = true;
            this.btnlogBack.UseSelectable = true;
            this.btnlogBack.UseStyleColors = true;
            this.btnlogBack.Click += new System.EventHandler(this.btnlogBack_Click);
            // 
            // lablelogin
            // 
            this.lablelogin.AutoSize = true;
            this.lablelogin.BackColor = System.Drawing.Color.White;
            this.lablelogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lablelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablelogin.ForeColor = System.Drawing.Color.Red;
            this.lablelogin.Location = new System.Drawing.Point(452, 131);
            this.lablelogin.Name = "lablelogin";
            this.lablelogin.Size = new System.Drawing.Size(217, 13);
            this.lablelogin.TabIndex = 10;
            this.lablelogin.Text = "Please fill up UserName and Password field!!";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(373, 343);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 448);
            this.Controls.Add(this.lablelogin);
            this.Controls.Add(this.btnlogBack);
            this.Controls.Add(this.rbtnCustomer);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.txtLogInPassword);
            this.Controls.Add(this.btnmainlogin);
            this.Controls.Add(this.txtLoginUserName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "btnLogIn";
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "LogIn";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtLoginUserName;
        private MetroFramework.Controls.MetroButton btnmainlogin;
        private MetroFramework.Controls.MetroTextBox txtLogInPassword;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroRadioButton rbtnAdmin;
        private MetroFramework.Controls.MetroRadioButton rbtnCustomer;
        private MetroFramework.Controls.MetroButton btnlogBack;
        private System.Windows.Forms.Label lablelogin;
    }
}