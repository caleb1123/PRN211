using BussinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository1();
        bool isLoggedIn;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }



        private bool Login(string email, string password)
        {
            isLoggedIn = true;
            var mems = memberRepository.GetMembers();
            MemberObject member = mems.FirstOrDefault(m => m.Email.ToLower() == email.ToLower() && m.password == password);
            if (member != null)
            {
                member.role = "user"; // set the role of the logged-in member
                this.Hide();
                frmMemberManagerment fm = new frmMemberManagerment(member);
                fm.Show(this);

                return true;
            }
            else
            {
                // Login failed
                // You can display an error message to the user or perform any necessary actions
                return false;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var mems = memberRepository.GetMembers();
            List<MemberObject> memList = mems.OrderByDescending(mems => mems.MemberName).ToList();
            if (txtEmail.Text == "admin@fstore.com" && txtPass.Text == "admin@@")
            {
                IConfiguration config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
                var adminUser = config["AdminAccount:Email"];
                var password = config["AdminAccount:Password"];
                if (adminUser == txtEmail.Text && password == txtPass.Text)
                {
                    this.Hide();
                    frmMemberManagerment fm = new frmMemberManagerment();
                    fm.Show(this);

                }
                else
                {
                    MessageBox.Show("Login Fail!!!");
                }
            }
            else 
            {
                Login(txtEmail.Text, txtPass.Text);


            }
           


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}