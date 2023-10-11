using BussinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public bool InsertOrUpdate { get; set; }
        public MemberObject memberInfo { get; set; }
        public IMemberRepository MemberRepository { get; set; }

        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtID.Text = memberInfo.MemberID.ToString();
                txtname.Text = memberInfo.MemberName.ToString();
                txtEmai.Text = memberInfo.Email.ToString();
                txtPass.Text = memberInfo.password.ToString();
                txtCity.Text = memberInfo.City.ToString();
                txtCountry.Text = memberInfo.Country.ToString();

            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtname.Text,
                    Email = txtEmai.Text,
                    password = txtPass.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository1 memberRepository1 = new MemberRepository1();
                    memberRepository1.AddMember(member);
                    this.Hide();

                }
                else
                {
                    MemberRepository1 memberRepository1 = new MemberRepository1();

                    memberRepository1.UpdateMember(member);
                    this.Hide();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Member" : "Update a member");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
