namespace BusinessLayer
{
    public partial class Member
    {
       
        public Member() 
        { 
            Orders = new HashSet<Order>();
        }
        public int MemberId { get; set; }
        public String Email { get; set; }
        public String CompanyName { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public String Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}