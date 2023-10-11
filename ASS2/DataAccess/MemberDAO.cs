using BusinessLayer;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance;
        private static readonly object instanceLock = new object();
        private SaleManageDBContext context = new SaleManageDBContext();
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        

        public Member SignIn (String email , String password)
        {
            return context.Members.
                FirstOrDefault(member => member.Email.Equals(email)
                                            && member.Password.Equals(password));
        }

        public List<Member> GetMembers()
        {
            return context.Members.ToList();
        }

        public Member GetMemberbyid(int id) 
        {
            return context.Members.SingleOrDefault(mb => mb.MemberId == id);
        }
        public void AddMember (Member member)
        {
            Member member1 = GetMemberbyid(member.MemberId);
            if(member1 == null) 
            {
                context.Members.Add(member1);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Add Fail");
            }
        }
        public void RemoveMember (Member member)
        {
            Member member1 = GetMemberbyid(member.MemberId);
            if(member != null)
            {
                context.Members.Remove(member);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Not Exist");
            }
        }
        public void UpdateMember (Member member)
        {
            var m = GetMembers();
            if(m != null)
            {
                Member member1 = GetMemberbyid(member.MemberId);
                if(member1 != null)
                {
                    member1.Email = member.Email;
                    member1.CompanyName = member.CompanyName;
                    member1.City = member.City;
                    member1.Country = member.Country;
                    member1.Password = member.Password;
                    context.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Member does not exists");
            }
           

        }
    }
}