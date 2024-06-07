using AlisPark.Business.Abstract;
using AlisPark.Business.Utilities;
using AlisPark.Business.ValidationRules.FluentValidation;
using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.Concrete
{

    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        public List<Member> GetAll()
        {
            //Business code            
            return _memberDal.GetAll(); 
        }

        public List<Member> GetProductsByCategory(int categoryId)
        {
            return _memberDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Member> GetProductsByMemberName(string memberName)
        {
            return _memberDal.GetAll(p => p.MemberName.ToLower().Contains(memberName.ToLower()));
        }

        public void Add(Member member)
        {
            ValidationTools.FluentValidate(new MemberValidator(), member);
            _memberDal.Add(member);
        }

        public void Update(Member member)
        {
            ValidationTools.FluentValidate(new MemberValidator(), member);
            _memberDal.Update(member);
        }

        public void Delete(Member member)
        {
            try
            {
                _memberDal.Delete(member);
            }
            catch
            {
                throw new Exception("Silme gerçekleşemedi");
            }

        }
    }
}
