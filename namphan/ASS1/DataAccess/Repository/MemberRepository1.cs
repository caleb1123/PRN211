using BussinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess.Repository
{
    public class MemberRepository1 : IMemberRepository
    {
        public void AddMember(MemberObject member) => MemberDAO.Instance.AddMember(member);


        public void DeleteMember(int MemberID) => MemberDAO.Instance.Delete(MemberID);


        public MemberObject GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);
        

        public IEnumerable<MemberObject> GetMembers() =>  MemberDAO.Instance.GetMemberList;

        public List<MemberObject> SearchMembers(int? MemberID, string MemberName) => MemberDAO.Instance.SearchMember(MemberID, MemberName);


        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

    }
}
