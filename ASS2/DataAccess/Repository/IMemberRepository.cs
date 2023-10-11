using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        Member GetMemberById(int memberId);
        IEnumerable<Member> GetAllMembers();
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberId);
    }
}
