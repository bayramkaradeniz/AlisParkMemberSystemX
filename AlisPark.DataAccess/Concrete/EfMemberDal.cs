using AlisPark.DataAccess.Abstract;
using AlisPark.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.DataAccess.Concrete
{
    public class EfMemberDal : EfEntityRepositoryBase<Member, AlisParkContext>, IMemberDal
    {
    }
}
