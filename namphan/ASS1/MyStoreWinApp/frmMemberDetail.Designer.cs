namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtname = new TextBox();
            txtEmai = new TextBox();
            txtPass = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "MemberID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "MemberName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 235);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 284);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // txtID
            // 
            txtID.Location = new Point(119, 23);
            txtID.Name = "txtID";
            txtID.Size = new Size(181, 27);
            txtID.TabIndex = 6;
            // 
            // txtname
            // 
            txtname.Location = new Point(119, 76);
            txtname.Name = "txtname";
            txtname.Size = new Size(181, 27);
            txtname.TabIndex = 7;
            // 
            // txtEmai
            // 
            txtEmai.Location = new Point(119, 126);
            txtEmai.Name = "txtEmai";
            txtEmai.Size = new Size(181, 27);
            txtEmai.TabIndex = 8;
            txtEmai.TextChanged += textBox3_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(119, 180);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(181, 27);
            txtPass.TabIndex = 9;
            txtPass.TextChanged += textBox4_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(119, 232);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(181, 27);
            txtCity.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(119, 281);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(181, 27);
            txtCountry.TabIndex = 11;
            // 
            // btSave
            // 
            btSave.Location = new Point(55, 343);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 12;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(206, 343);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 395);
            Controls.Add(btnCancel);
            Controls.Add(btSave);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPass);
            Controls.Add(txtEmai);
            Controls.Add(txtname);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtname;
        private TextBox txtEmai;
        private TextBox txtPass;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btSave;
        private Button btnCancel;
    }
}