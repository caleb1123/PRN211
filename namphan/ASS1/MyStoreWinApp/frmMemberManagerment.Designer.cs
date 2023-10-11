namespace MyStoreWinApp
{
    partial class frmMemberManagerment
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
            btnexit = new Button();
            lblID = new Label();
            lblname = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            lblPass = new Label();
            lblConuntry = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnadd = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            dgvMemberList = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnfilter = new Button();
            btnSort = new Button();
            cbmCity = new ComboBox();
            cbmCountry = new ComboBox();
            btnLoadUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.Black;
            btnexit.ForeColor = SystemColors.ButtonHighlight;
            btnexit.Location = new Point(907, 223);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 29);
            btnexit.TabIndex = 0;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.White;
            lblID.Location = new Point(11, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(80, 20);
            lblID.TabIndex = 1;
            lblID.Text = "MemberID";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.BackColor = Color.White;
            lblname.Location = new Point(11, 59);
            lblname.Name = "lblname";
            lblname.Size = new Size(105, 20);
            lblname.TabIndex = 2;
            lblname.Text = "MemberName";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.Location = new Point(11, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.White;
            lblCity.Location = new Point(378, 61);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.White;
            lblPass.Location = new Point(378, 11);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 5;
            lblPass.Text = "Password";
            // 
            // lblConuntry
            // 
            lblConuntry.AutoSize = true;
            lblConuntry.BackColor = Color.White;
            lblConuntry.Location = new Point(378, 117);
            lblConuntry.Name = "lblConuntry";
            lblConuntry.Size = new Size(60, 20);
            lblConuntry.TabIndex = 6;
            lblConuntry.Text = "Country";
            // 
            // txtID
            // 
            txtID.Location = new Point(123, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(107, 27);
            txtID.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 27);
            txtName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(123, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(469, 11);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(234, 27);
            txtPass.TabIndex = 10;
            txtPass.TextChanged += textBox4_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(469, 59);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(234, 27);
            txtCity.TabIndex = 11;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(469, 112);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(234, 27);
            txtCountry.TabIndex = 12;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Transparent;
            btnadd.Location = new Point(710, 12);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(120, 36);
            btnadd.TabIndex = 13;
            btnadd.Text = "Add Member";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Location = new Point(710, 112);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 36);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Transparent;
            btnLoad.Location = new Point(710, 61);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(120, 36);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load Member";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(11, 259);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(986, 215);
            dgvMemberList.TabIndex = 19;
            dgvMemberList.CellContentClick += dgvMemberList_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 212);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(156, 27);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(186, 212);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnfilter
            // 
            btnfilter.Location = new Point(591, 201);
            btnfilter.Name = "btnfilter";
            btnfilter.Size = new Size(94, 29);
            btnfilter.TabIndex = 22;
            btnfilter.Text = "Filter";
            btnfilter.UseVisualStyleBackColor = true;
            btnfilter.Click += btnfilter_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(314, 212);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 23;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // cbmCity
            // 
            cbmCity.FormattingEnabled = true;
            cbmCity.Location = new Point(469, 165);
            cbmCity.Name = "cbmCity";
            cbmCity.Size = new Size(151, 28);
            cbmCity.TabIndex = 24;
            cbmCity.Text = "City";
            // 
            // cbmCountry
            // 
            cbmCountry.FormattingEnabled = true;
            cbmCountry.Location = new Point(639, 165);
            cbmCountry.Name = "cbmCountry";
            cbmCountry.Size = new Size(151, 28);
            cbmCountry.TabIndex = 25;
            cbmCountry.Text = "Country";
            // 
            // btnLoadUser
            // 
            btnLoadUser.BackColor = Color.Transparent;
            btnLoadUser.Location = new Point(710, 201);
            btnLoadUser.Name = "btnLoadUser";
            btnLoadUser.Size = new Size(120, 36);
            btnLoadUser.TabIndex = 26;
            btnLoadUser.Text = "Load User";
            btnLoadUser.UseVisualStyleBackColor = false;
            btnLoadUser.Click += btnLoadUser_Click;
            // 
            // frmMemberManagerment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 485);
            Controls.Add(btnLoadUser);
            Controls.Add(cbmCountry);
            Controls.Add(cbmCity);
            Controls.Add(btnSort);
            Controls.Add(btnfilter);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnadd);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblConuntry);
            Controls.Add(lblPass);
            Controls.Add(lblCity);
            Controls.Add(lblEmail);
            Controls.Add(lblname);
            Controls.Add(lblID);
            Controls.Add(btnexit);
            Name = "frmMemberManagerment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Managerment";
            Load += frmMemberManagerment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnexit;
        private Label lblID;
        private Label lblname;
        private Label lblEmail;
        private Label lblCity;
        private Label lblPass;
        private Label lblConuntry;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPass;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnadd;
        private Button btnDelete;
        private Button btnLoad;
        private ColumnHeader MemberName;
        private ColumnHeader Email;
        private ColumnHeader City;
        private ColumnHeader Country;
        public ColumnHeader MemberID;
        private DataGridView dgvMemberList;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnfilter;
        private Button btnSort;
        private ComboBox cbmCity;
        private ComboBox cbmCountry;
        private Button btnLoadUser;
    }
}