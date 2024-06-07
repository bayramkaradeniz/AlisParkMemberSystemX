using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Abstract
{

    public interface IMemberService
    {
        List<Member> GetAll();
        List<Member> GetProductsByCategory(int categoryId);
        List<Member> GetProductsByMemberName(string memberName);
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);
    }


}
