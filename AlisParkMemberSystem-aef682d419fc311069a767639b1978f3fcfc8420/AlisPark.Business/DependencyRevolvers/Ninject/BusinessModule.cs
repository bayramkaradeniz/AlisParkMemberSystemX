using AlisPark.Business.Abstract;
using AlisPark.Business.Concerete;
using AlisPark.Business.Concrete;
using AlisPark.DataAccess.Abstract;
using AlisPark.DataAccess.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlisPark.Business.DependencyRevolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ILogEntryService>().To<LogEntryManager>().InSingletonScope();
            Bind<ILogEntryDal>().To<EfLogEntryDal>().InSingletonScope();

            Bind<IWorkerService>().To<WorkerManager>().InSingletonScope();
            Bind<IWorkerDal>().To<EfWorkerDal>().InSingletonScope();

            Bind<ICompanyService>().To<CompanyManager>().InSingletonScope();
            Bind<ICompanyDal>().To<EfCompanyDal>().InSingletonScope();

            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<ILogEntryService>().To<LogEntryManager>().InSingletonScope();
            Bind<ILogEntryDal>().To<EfLogEntryDal>().InSingletonScope();

            Bind<IWorkerService>().To<WorkerManager>().InSingletonScope();
            Bind<IWorkerDal>().To<EfWorkerDal>().InSingletonScope();

            Bind<ICompanyService>().To<CompanyManager>().InSingletonScope();
            Bind<ICompanyDal>().To<EfCompanyDal>().InSingletonScope();

            Bind<IMailSenderService>().To<MailManager>().InSingletonScope();
            Bind<IMailSenderDal>().To<EfMailSender>().InSingletonScope();

            Bind<ITableService>().To<TableManager>().InSingletonScope();
            Bind<ITableDal>().To<EfTableDal>().InSingletonScope();

            Bind<ITableEventService>().To<TableEventManager>().InSingletonScope();
            Bind<ITableEventDal>().To<EfTableEventDal>().InSingletonScope();

            Bind<IOrderService>().To<OrderManager>().InSingletonScope();
            Bind<IOrderDal>().To<EfOrderDal>().InSingletonScope();
        }
    }
}
