using BussinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyStoreWinApp
{
    public partial class frmMemberManagerment : Form
    {
        public frmMemberManagerment(MemberObject member)
        {
            InitializeComponent();
            loggedInMember = member;
            if (loggedInMember.role != "admin")
            {
                btnadd.Enabled = false;
                btnDelete.Enabled = false;
                btnLoad.Enabled = false;
                btnSort.Enabled = false;

            }
        }
        public frmMemberManagerment()
        {
            InitializeComponent();
            btnLoadUser.Enabled = false;

        }

        IMemberRepository memberRepository = new MemberRepository1();
        BindingSource source;
        private MemberObject loggedInMember;
        public BindingSource BindingSource { get; private set; }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void frmMemberManagerment_Load(object sender, EventArgs e)

        {
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellContentClick;
            GetCityAndCountryList();
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPass.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtCountry.ReadOnly = true;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                memberInfo = GetMemberObject(),
                MemberRepository = memberRepository


            };

            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;

            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject memberObject = null;
            try
            {
                memberObject = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    password = txtPass.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,


                };


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member!!");
            }
            return memberObject;

        }

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;

        }


        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();


                txtID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPass.DataBindings.Add("Text", source, "password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;

                }

            }
            catch (Exception ex) { }



        }
        public void LoadMemberList1()
        {
            var members = memberRepository.GetMemberByID(loggedInMember.MemberID);
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();


                txtID.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPass.DataBindings.Add("Text", source, "password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                

            }
            catch (Exception ex) { }



        }
        public void LoadLoggedInMemberInfo()
        {
            txtID.Text = loggedInMember.MemberID.ToString();
            txtName.Text = loggedInMember.MemberName;
            txtEmail.Text = loggedInMember.Email;
            txtPass.Text = loggedInMember.password;
            txtCity.Text = loggedInMember.City;
            txtCountry.Text = loggedInMember.Country;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
             LoadMemberList(); 

        }

        private void btnadd_Click(object sender, EventArgs e)
        {


            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Delete a member!!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*txtID.Text = txtSearch.Text;


            int? memberID = null;
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                memberID = int.Parse(txtID.Text);
            }

            string memberName = txtName.Text;

            List<MemberObject> searchResult = new List<MemberObject>();

            foreach (MemberObject member in MemberDAO.Instance.GetMemberList)
            {
                if (memberID.HasValue && member.MemberID != memberID.Value)
                {
                    continue;
                }

                if (!string.IsNullOrEmpty(memberName) && !member.MemberName.ToLower().Contains(memberName.ToLower()))
                {
                    continue;
                }

                searchResult.Add(member);
            }

            dgvMemberList.DataSource = searchResult;*/
            String name = txtSearch.Text;
            Search(name);


        }
        private void Search(string searchQuery)
        {
            var mems = memberRepository.GetMembers();
            List<MemberObject> searchResult = mems.Where(m => m.MemberName.ToLower().Contains(searchQuery.ToLower()) || m.MemberID.ToString().Contains(searchQuery)).ToList();
            try
            {
                BindingSource = new BindingSource();
                BindingSource.DataSource = searchResult;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", BindingSource, "MemberID");
                txtName.DataBindings.Add("Text", BindingSource, "MemberName");
                txtEmail.DataBindings.Add("Text", BindingSource, "Email");
                txtPass.DataBindings.Add("Text", BindingSource, "Password");
                txtCity.DataBindings.Add("Text", BindingSource, "City");
                txtCountry.DataBindings.Add("Text", BindingSource, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = BindingSource;
                if (searchResult.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Members");
            }
        }
        private void SearchByName(string memberName)
        {
            var mems = memberRepository.GetMembers();
            List<MemberObject> searchResult = mems.Where(m => m.MemberName.ToLower().Contains(memberName.ToLower())).ToList();

            BindingSource = new BindingSource();
            BindingSource.DataSource = searchResult;

            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPass.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCountry.DataBindings.Clear();

            txtID.DataBindings.Add("Text", BindingSource, "MemberID");
            txtName.DataBindings.Add("Text", BindingSource, "MemberName");
            txtEmail.DataBindings.Add("Text", BindingSource, "Email");
            txtPass.DataBindings.Add("Text", BindingSource, "Password");
            txtCity.DataBindings.Add("Text", BindingSource, "City");
            txtCountry.DataBindings.Add("Text", BindingSource, "Country");

            dgvMemberList.DataSource = null;
            dgvMemberList.DataSource = BindingSource;

            if (searchResult.Count() == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void GetCityAndCountryList()
        {
            var mems = memberRepository.GetMembers();
            cbmCity.SelectedItem = 0;
            cbmCountry.SelectedItem = 0;
            cbmCity.Items.Clear();
            cbmCountry.Items.Clear();
            cbmCity.Items.Add(string.Empty);
            cbmCountry.Items.Add(string.Empty);
            foreach (var member in mems)
            {
                if (!cbmCity.Items.Contains(member.City) && member.City != "")
                {
                    cbmCity.Items.Add(member.City);
                }
                if (!cbmCountry.Items.Contains(member.Country) && member.Country != "")
                {
                    cbmCountry.Items.Add(member.Country);
                }
            }
        }

        private void FilterCityAndCountry(string city, string country)
        {
            try
            {
                var mems = memberRepository.GetMembers();
                List<MemberObject> memList = new List<MemberObject>();
                foreach (var member in mems)
                {
                    if (city.Equals(string.Empty))
                    {
                        if (member.Country.Equals(country))
                        {
                            memList.Add(member);
                        }
                    }
                    if (country.Equals(string.Empty))
                    {
                        if (member.City.Equals(city))
                        {
                            memList.Add(member);
                        }
                    }
                    if (!city.Equals(string.Empty) && !country.Equals(string.Empty))
                    {
                        if (member.City.Equals(city) && member.Country.Equals(country))
                        {
                            memList.Add(member);
                        }
                    }
                }

                BindingSource = new BindingSource();
                BindingSource.DataSource = memList;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", BindingSource, "MemberID");
                txtName.DataBindings.Add("Text", BindingSource, "MemberName");
                txtEmail.DataBindings.Add("Text", BindingSource, "Email");
                txtPass.DataBindings.Add("Text", BindingSource, "Password");
                txtCity.DataBindings.Add("Text", BindingSource, "City");
                txtCountry.DataBindings.Add("Text", BindingSource, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = BindingSource;
                if (memList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;

                }
                else
                {

                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter City and Country");
            }
        }

        private void btnfilter_Click(object sender, EventArgs e)
        {
            string city = string.Empty;
            string country = string.Empty;
            if (cbmCity.SelectedItem != null)
            {
                city = cbmCity.SelectedItem.ToString();
            }
            if (cbmCountry.SelectedItem != null)
            {
                country = cbmCountry.SelectedItem.ToString();
            }
            if (city.Equals("") && country.Equals(""))
            {
                LoadMemberList();
            }
            else
            {
                FilterCityAndCountry(city, country);
            }
        }
        private void SortDescByName()
        {
            var mems = memberRepository.GetMembers();
            List<MemberObject> memList = mems.OrderByDescending(mems => mems.MemberName).ToList();
            try
            {
                BindingSource = new BindingSource();
                BindingSource.DataSource = memList;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPass.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", BindingSource, "MemberID");
                txtName.DataBindings.Add("Text", BindingSource, "MemberName");
                txtEmail.DataBindings.Add("Text", BindingSource, "Email");
                txtPass.DataBindings.Add("Text", BindingSource, "Password");
                txtCity.DataBindings.Add("Text", BindingSource, "City");
                txtCountry.DataBindings.Add("Text", BindingSource, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = BindingSource;
                if (memList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;

                }
                else
                {

                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sort Member descending by Name");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            
                SortDescByName();
            
            

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        public void search()
        {




        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

            }
        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            LoadMemberList1();
        }
    }
}
