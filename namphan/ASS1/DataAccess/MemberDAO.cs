
using BussinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> memberList = new List<MemberObject>()
        {
            
            new MemberObject{MemberID = 2,MemberName = "Ngo Trung Kien", Email = "kien@fstore.com", password = "123", City = "Bien Hoa", Country="VietNam",role="user"},
            new MemberObject{MemberID = 3,MemberName = "Donal Trump", Email = "trump@fstore.com", password = "trump@@", City = "New York", Country="US",role="user"}
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get { 
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }                 
                }
        }

        public List<MemberObject> GetMemberList => memberList;

        public MemberObject GetMemberByID(int MemberID)
        {
            MemberObject memberObject = memberList.SingleOrDefault(pro => pro.MemberID == MemberID);

            return memberObject;
        }

        public void AddMember(MemberObject memberObject)
        {
            MemberObject pro = GetMemberByID(memberObject.MemberID);
            if(pro == null)
            {
                memberList.Add(memberObject);

            }
            else
            {
                throw new Exception("Member is already!!!");
            }


        }

        public void Update(MemberObject memberObject)
        {
            MemberObject mUpdate = GetMemberByID(memberObject.MemberID);
            if(mUpdate != null)
            {
                var index = memberList.IndexOf(mUpdate);
                memberList[index] = memberObject;


            }
            else { throw new Exception("Member is not exists!!!"); }

        }

        public void Delete(int memberID)
        {
            MemberObject mRemove = GetMemberByID(memberID);
            if( mRemove != null)
            {
                memberList.Remove(mRemove);

            }else { throw new Exception("Member is not exists!!!"); }

        }
        public List<MemberObject> SearchMember(int? memberID, string memberName)

        {
            var result = MemberDAO.Instance.GetMemberList;

            if (memberID.HasValue)
            {
                result = result.Where(m => m.MemberID == memberID.Value).ToList();
            }

            if (!string.IsNullOrEmpty(memberName))
            {
                result = result.Where(m => m.MemberName.ToLower().Contains(memberName.ToLower())).ToList();
            }

            return result;
        }
    }

}
