using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();
        MemberObject GetMemberByID (int MemberID);
        void AddMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int MemberID);
        
        List<MemberObject> SearchMembers(int? MemberID, String MemberName);
    }
}
